﻿using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Reportes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Almacen
{
    public class ServicioInventarios
    {
        private IBaseDeDatos _baseDatos;
        public List<Inventario> ListaInventario { get; set; }

        public ServicioInventarios(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultaInventario(int idProducto, bool esValuado)
        {
            IDbConnection conexion = null;
            ListaInventario = new List<Inventario>();

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_Inventario", conexion);

                if (idProducto > 0)
                {
                    IDataParameter parametroIdProducto = _baseDatos.CrearParametro("@IdProducto", idProducto, ParameterDirection.Input);
                    comando.Parameters.Add(parametroIdProducto);
                }

                IDataParameter parametroEsvaluado = _baseDatos.CrearParametro("@EsValuado", esValuado, ParameterDirection.Input);
                comando.Parameters.Add(parametroEsvaluado);


                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Inventario inventario = new Inventario();

                    inventario.IdFamiliaProducto = (int)lector["IdFamiliaProducto"];
                    inventario.Familia = lector["Familia"].ToString();
                    inventario.Prioridad = (int)lector["Prioridad"];
                    inventario.IdProducto = (int)lector["IdProducto"];
                    inventario.Producto = lector["Producto"].ToString();
                    inventario.ClaveProducto = lector["ClaveProducto"].ToString();
                    inventario.Existencia = (decimal)lector["Existencia"];
                    inventario.PrecioVenta = (decimal)lector["PrecioVenta"];
                    inventario.UPrecioEntrada = (decimal)lector["UPrecioEntrada"];

                    ListaInventario.Add(inventario);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la Información del inventario.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
        }
    }
}

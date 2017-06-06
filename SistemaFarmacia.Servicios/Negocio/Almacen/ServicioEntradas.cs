using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Almacen
{
    public class ServicioEntradas
    {
        private IBaseDeDatos _baseDatos;
        public List<EntradaProductoListado> ListaEntradasProductos { get; set; }

        public ServicioEntradas(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarEntradasCabecera(int anio)
        {
            ListaEntradasProductos = new List<EntradaProductoListado>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_EntradasProductos", conexion);

                IDataParameter parametroAnio = _baseDatos.CrearParametro("@Anio", anio, ParameterDirection.Input);
                comando.Parameters.Add(parametroAnio);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    EntradaProductoListado entrada = new EntradaProductoListado();

                    entrada.IdEntradaProducto = (int)lector["IdEntradaProducto"];
                    entrada.IdProveedor = (int)lector["IdProveedor"];
                    entrada.RazonSocial = lector["RazonSocial"].ToString();
                    entrada.IdProducto = (int)lector["IdProducto"];
                    entrada.ClaveProducto = lector["ClaveProducto"].ToString();
                    entrada.Descripcion = lector["Descripcion"].ToString();
                    entrada.Cantidad = (decimal)lector["Cantidad"];
                    entrada.Precio = (decimal)lector["Precio"];
                    entrada.Fecha = (DateTime)lector["Fecha"];
                    

                    ListaEntradasProductos.Add(entrada);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de entradas.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();

                conexion.Dispose();
            }
        }
    }
}

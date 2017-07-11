using ProInnotec.Core.Entidades.Datos;
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
    public class ServicioKardex
    {
        private IBaseDeDatos _baseDatos;

        public List<KardexEntidad> ListaKardex { get; set; }

        public ServicioKardex(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultaKardex(DateTime fechaInicio, DateTime fechaFinal, int idProducto)
        {
            IDbConnection conexion = null;
            ListaKardex = new List<KardexEntidad>();

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_Kardex", conexion);

                IDataParameter parametroFechaInicial = _baseDatos.CrearParametro("@FechaInicial", fechaInicio, ParameterDirection.Input);
                comando.Parameters.Add(parametroFechaInicial);

                IDataParameter parametroFechaFinal = _baseDatos.CrearParametro("@FechaFinal", fechaFinal, ParameterDirection.Input);
                comando.Parameters.Add(parametroFechaFinal);

                if(idProducto > 0)
                {
                    IDataParameter parametroIdProducto = _baseDatos.CrearParametro("@IdProducto", idProducto, ParameterDirection.Input);
                    comando.Parameters.Add(parametroIdProducto);
                }
                
                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    KardexEntidad kardex = new KardexEntidad();

                    kardex.TipoMovimiento = lector["TipoMovimiento"].ToString();
                    kardex.IdRegistro = (Int64)lector["IdRegistro"];
                    kardex.Fecha = (DateTime)lector["Fecha"];
                    kardex.IdUsuarioKardex = (int)lector["IdUsuario"];
                    kardex.UsuarioKardex = lector["Usuario"].ToString();
                    kardex.IdRegistroDetalle = (Int64)lector["IdRegistroDetalle"];
                    kardex.DescripcionRegistro = lector["DescripcionRegistro"].ToString();
                    kardex.Cantidad = (decimal)lector["Cantidad"];
                    kardex.IdProducto = (int)lector["IdProducto"];
                    kardex.Producto = lector["Producto"].ToString();
                    kardex.ClaveProducto = lector["ClaveProducto"].ToString();
                    kardex.IdFamiliaProducto = (int)lector["IdFamiliaProducto"];
                    kardex.Familia = lector["Familia"].ToString();
                    kardex.Prioridad = (int)lector["Prioridad"];
                    kardex.PrecioRegistro = (decimal)lector["PrecioRegistro"];
                    kardex.PrecioVenta = (decimal)lector["PrecioVenta"];
                    kardex.IdTipoAjuste = (int)lector["IdTipoAjuste"];
                    kardex.TipoAjuste = lector["TipoAjuste"].ToString();

                    ListaKardex.Add(kardex);
                }

                lector.Close();

                return null;
            }
            catch(Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la Información del kardex.", excepcionCapturada);
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

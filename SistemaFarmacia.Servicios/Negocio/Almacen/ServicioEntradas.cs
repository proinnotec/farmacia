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
        public List<EntradaProductoDetalle> ListaEntradasDetalles { get; set; }

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
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_EntradasProductosListado", conexion);

                IDataParameter parametroAnio = _baseDatos.CrearParametro("@Anio", anio, ParameterDirection.Input);
                comando.Parameters.Add(parametroAnio);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    EntradaProductoListado entrada = new EntradaProductoListado();
                    entrada.IdEntradaProductoDetalle = (int)lector["IdEntradaProductoDetalle"];
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
                {
                    conexion.Close();
                    conexion.Dispose();
                }                    
            }
        }
        
        public ExcepcionPersonalizada ConsultarDetalles(int idEntrada)
        {
            ListaEntradasDetalles = new List<EntradaProductoDetalle>();
            IDbConnection conexion = null;
            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_EntradasProductosDetalles", conexion);

                IDataParameter parametroIdEntrada = _baseDatos.CrearParametro("@IdEntradaProducto", idEntrada, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdEntrada);

                IDataReader lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    EntradaProductoDetalle detalle = new EntradaProductoDetalle();

                    detalle.IdEntradaProductoDetalle = (int)lector["IdEntradaProductoDetalle"];
                    detalle.IdEntradaProducto = (int)lector["IdEntradaProducto"];
                    detalle.Cantidad = (decimal)lector["Cantidad"];
                    detalle.IdProducto = (int)lector["IdProducto"];
                    detalle.Descripcion = lector["Descripcion"].ToString();
                    detalle.ClaveProducto = lector["ClaveProducto"].ToString();
                    detalle.PrecioActual = (decimal)lector["PrecioActual"];
                    detalle.PrecioEntrada = (decimal)lector["PrecioEntrada"];

                    ListaEntradasDetalles.Add(detalle);
                }

                lector.Close();

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de detalles de las entradas.", excepcionCapturada);
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

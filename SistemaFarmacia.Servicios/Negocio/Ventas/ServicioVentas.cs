using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using System.Data;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Servicios.Utilerias;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Servicios.Negocio.Ventas
{
    public class ServicioVentas
    {
        private IBaseDeDatos _baseDatos;
        public ContextoVenta ContextoVenta { get; private set; }

        public ServicioVentas(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada BuscarProductoCodigoBarra(string codigoBarra)
        {
            ContextoVenta = new ContextoVenta();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_ProductosVenta", conexion);

                IDataParameter parametroCodigoBarras = _baseDatos.CrearParametro("@CodigoBarras", codigoBarra, ParameterDirection.Input);
                comando.Parameters.Add(parametroCodigoBarras);

                IDataReader Lector = comando.ExecuteReader();

                if (Lector.Read())
                {
                    ContextoVenta.Producto = new CatProducto();
                    ContextoVenta.Producto.AplicaDescuentoCatalogo = (bool)Lector["AplicaDescuentoCatalogo"];
                    ContextoVenta.Producto.ClaveProducto = (string)Lector["ClaveProducto"];
                    ContextoVenta.Producto.Descripcion = (string)Lector["Descripcion"];
                    ContextoVenta.Impuesto = new CatImpuestos();
                    ContextoVenta.Impuesto.IdImpuesto = (Int16)Lector["IdImpuesto"];
                    ContextoVenta.Impuesto.Porcentaje = (decimal)Lector["Porcentaje"];
                    ContextoVenta.Impuesto.Descripcion = (string)Lector["DescripcionImpuesto"];
                    ContextoVenta.Producto.IdProducto = (int)Lector["IdProducto"];
                    ContextoVenta.Producto.Precio = (decimal)Lector["Precio"];
                }
                else
                {
                    return new ExcepcionPersonalizada("No se encontró algún producto con ese código de barra.", new Exception("El código no existe."));
                }

                Lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible buscar el producto con el código de barra.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null)
                {
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                    }

                    conexion.Dispose();
                }
            }
        }


        public ExcepcionPersonalizada GuardarVenta(Venta venta)
        {
            IDbConnection conexion = null;
            Serializar serializar = new Serializar();
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                string xmlVentaDetalle = serializar.ClaseXmlString(venta.DetalleVenta);

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_Venta", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", venta.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroTotal = _baseDatos.CrearParametro("@Total", venta.Total, ParameterDirection.Input);
                comando.Parameters.Add(parametroTotal);

                IDataParameter parametroSubTotal = _baseDatos.CrearParametro("@SubTotal", venta.SubTotal, ParameterDirection.Input);
                comando.Parameters.Add(parametroSubTotal);

                IDataParameter parametroXmlVentaDetalle = _baseDatos.CrearParametro("@XmlVentaDetalle", xmlVentaDetalle, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlVentaDetalle);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spI_Venta).");
                }

                transaccion.Commit();

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar la venta.", excepcionCapturada);

                if (transaccion != null)
                {
                    transaccion.Rollback();
                }

                return excepcion;
            }
            finally
            {
                if (conexion != null)
                {
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                    }

                    conexion.Dispose();
                }
            }
        }
    }
}

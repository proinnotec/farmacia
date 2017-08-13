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
using SistemaFarmacia.Entidades.Negocio.Ventas;

namespace SistemaFarmacia.Servicios.Negocio.Ventas
{
    public class ServicioVentas
    {
        private IBaseDeDatos _baseDatos;
        public ContextoVenta ContextoVenta { get; private set; }
        public Int64 Consecutivo { get; private set; }
        public DateTime FechaRegistro { get; private set; }
        public string DireccionSucursal { get; private set; }
        public string Sucursal { get; private set; }
        public List<Ticket> ListaTickets { get; private set; }
        public List<Usuario> ListaVendedores { get; set; }

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
                string xmlVentaDetalleImpuesto = serializar.ClaseXmlString(venta.DetalleVentaImpuesto);

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_Venta", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", venta.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroTotal = _baseDatos.CrearParametro("@Total", venta.Total, ParameterDirection.Input);
                comando.Parameters.Add(parametroTotal);

                IDataParameter parametroSubTotal = _baseDatos.CrearParametro("@SubTotal", venta.SubTotal, ParameterDirection.Input);
                comando.Parameters.Add(parametroSubTotal);

                if (venta.IdDescuento > 0)
                {
                    IDataParameter parametroIdDescuento = _baseDatos.CrearParametro("@IdDescuento", venta.IdDescuento, ParameterDirection.Input);
                    comando.Parameters.Add(parametroIdDescuento);
                }

                if (venta.Porcentaje > 0)
                {
                    IDataParameter parametroPorcentaje = _baseDatos.CrearParametro("@Porcentaje", venta.Porcentaje, ParameterDirection.Input);
                    comando.Parameters.Add(parametroPorcentaje);
                }

                IDataParameter parametroDescuento = _baseDatos.CrearParametro("@Descuento", venta.Descuento, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescuento);

                IDataParameter parametroXmlVentaDetalle = _baseDatos.CrearParametro("@XmlVentaDetalle", xmlVentaDetalle, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlVentaDetalle);

                IDataParameter parametroXmlVentaDetalleImpuesto = _baseDatos.CrearParametro("@XmlVentaDetalleImpuesto", xmlVentaDetalleImpuesto, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlVentaDetalleImpuesto);

                IDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    Consecutivo = (Int64) lector["Consecutivo"];
                    FechaRegistro = (DateTime) lector["FechaRegistro"];
                    DireccionSucursal = (string) lector["Direccion"];
                    Sucursal = (string)lector["Sucursal"];
                }
                else
                {
                    throw new Exception("No se afectaron filas (spI_Venta).");
                }

                lector.Close();
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

        public ExcepcionPersonalizada ObtenerListaTickets(Ticket opcionesBusqueda)
        {
            ListaTickets = new List<Ticket>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_TicketsLista", conexion);

                if(opcionesBusqueda.NoTicket > 0 )
                {
                    IDataParameter parametroTicket = _baseDatos.CrearParametro("@Ticket", opcionesBusqueda.NoTicket, ParameterDirection.Input);
                    comando.Parameters.Add(parametroTicket);
                }
                else
                {
                    if(opcionesBusqueda.IdUsuarioTicket > 0)
                    {
                        IDataParameter parametroUsuario = _baseDatos.CrearParametro("@Idusuario", opcionesBusqueda.IdUsuarioTicket, ParameterDirection.Input);
                        comando.Parameters.Add(parametroUsuario);
                    }

                    IDataParameter parametroFechaInicio = _baseDatos.CrearParametro("@FechaInicio", opcionesBusqueda.FechaInicio, ParameterDirection.Input);
                    comando.Parameters.Add(parametroFechaInicio);

                    IDataParameter parametroFechaFin = _baseDatos.CrearParametro("@FechaFin", opcionesBusqueda.FechaFin, ParameterDirection.Input);
                    comando.Parameters.Add(parametroFechaFin);
                }

                IDataReader lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Ticket ticket = new Ticket();

                    ticket.IdVenta = (Int64)lector["IdVenta"];
                    ticket.NoTicket = (Int64)lector["Ticket"];
                    ticket.Fecha = (DateTime)lector["Fecha"];
                    ticket.Total = (decimal)lector["Total"];
                    ticket.IdUsuarioTicket = (int)lector["IdUsuario"];
                    ticket.VendedorTicket = lector["Vendedor"].ToString();
                    ticket.CorteCaja = (int)lector["Corte"];

                    ListaTickets.Add(ticket);
                }               

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("Error al obtener la lista de tickets.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null)
                {
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                        conexion.Dispose();
                    }
                }
            }
        }

        public ExcepcionPersonalizada ObtenerListaUsuariosCortesCajaReporte(DateTime fechaInicio, DateTime fechaFin)
        {
            ListaVendedores = new List<Usuario>();

            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_UsuariosVenta", conexion);

                IDataParameter parametroFechaInicio = _baseDatos.CrearParametro("@FechaInicio", fechaInicio, ParameterDirection.Input);
                comando.Parameters.Add(parametroFechaInicio);

                IDataParameter parametroFechaFin = _baseDatos.CrearParametro("@FechaFin", fechaFin, ParameterDirection.Input);
                comando.Parameters.Add(parametroFechaFin);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuarioVendedor = new Usuario();

                    usuarioVendedor.IdUsuario = (int)lector["IdUsuario"];
                    usuarioVendedor.NombreUsuario = lector["NombreUsuario"].ToString();

                    ListaVendedores.Add(usuarioVendedor);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener el listado de vendedores.", excepcionCapturada);
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

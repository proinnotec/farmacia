using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Ajustes
{
    public class ServicioAjustes
    {
        private IBaseDeDatos _baseDatos;

        public ServicioAjustes(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada GuardarAjuste(AjustesProductos ajuste)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_AjustesProductos", conexion);
                comando.Transaction = transaccion;
                
                IDataParameter parametroSucursal = _baseDatos.CrearParametro("@IdSucursal", ajuste.IdSucursal, ParameterDirection.Input);
                comando.Parameters.Add(parametroSucursal);

                IDataParameter parametroUsuario = _baseDatos.CrearParametro("@IdUsuario", ajuste.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroUsuario);

                object resultado = comando.ExecuteScalar();

                Int64 IdAjusteProducto;

                bool sePuedeConvertir = Int64.TryParse(resultado.ToString(), out IdAjusteProducto);

                if (!sePuedeConvertir)
                {
                    Exception excepcion = new Exception("No fue posible convertir el valor del id de la cabecera del ajuste a entero.");

                    throw excepcion;
                }

                else
                {
                    foreach (AjustesProductosDetalles detalle in ajuste.ListaAjustesProductosDetalles)
                    {
                        IDbCommand comandoDetalles = _baseDatos.CrearComandoStoredProcedure("spI_AjustesProductosDetalles", conexion);
                        comandoDetalles.Transaction = transaccion;

                        IDataParameter parametroIdAjusteProducto = _baseDatos.CrearParametro("@IdAjusteProducto", IdAjusteProducto, ParameterDirection.Input);
                        comandoDetalles.Parameters.Add(parametroIdAjusteProducto);

                        IDataParameter parametroIdTipoAjuste = _baseDatos.CrearParametro("@IdTipoAjuste", detalle.TipoAjuste, ParameterDirection.Input);
                        comandoDetalles.Parameters.Add(parametroIdTipoAjuste);

                        IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", detalle.Descripcion, ParameterDirection.Input);
                        comandoDetalles.Parameters.Add(parametroDescripcion);

                        IDataParameter parametroCantidad = _baseDatos.CrearParametro("@Cantidad", detalle.Cantidad, ParameterDirection.Input);
                        comandoDetalles.Parameters.Add(parametroCantidad);

                        IDataParameter parametroIdProducto = _baseDatos.CrearParametro("@IdProducto", detalle.IdProducto, ParameterDirection.Input);
                        comandoDetalles.Parameters.Add(parametroIdProducto);
                        
                        IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", detalle.IdUsuario, ParameterDirection.Input);
                        comandoDetalles.Parameters.Add(parametroIdUsuario);

                        int registro = comandoDetalles.ExecuteNonQuery();

                        if (registro.Equals(0))
                            throw new Exception("No se afectaron filas (spI_AjustesProductosDetalles).");
                    }

                }

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar el ajuste.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

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

using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Catalogos
{
    public class ServicioCatalogoDescuentos
    {
        private IBaseDeDatos _baseDatos;
        public List<CatDescuentos> ListaCatDescuentos { get; private set; }
        public List<ConfiguracionDescuento> ListaConfiguracionDescuento { get; set; }

        public ServicioCatalogoDescuentos(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarDescuentos()
        {
            ListaCatDescuentos = new List<CatDescuentos>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatDescuentos", conexion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CatDescuentos descuento = new CatDescuentos();

                    descuento.IdDescuento = (int)lector["IdDescuento"];
                    descuento.Porcentaje = (decimal)lector["Porcentaje"];
                    descuento.Descripcion = lector["Descripcion"].ToString();
                    descuento.EsActivo = (bool)lector["EsActivo"];

                    ListaCatDescuentos.Add(descuento);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de descuentos.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();

                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada GuardarDescuento(CatDescuentos descuento)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_CatDescuentos", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroPorcentaje = _baseDatos.CrearParametro("@Porcentaje", descuento.Porcentaje, ParameterDirection.Input);
                comando.Parameters.Add(parametroPorcentaje);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", descuento.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", descuento.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spI_CatDescuentos).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar el descuento.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada ActualizarDescuento(CatDescuentos descuento)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatDescuentos", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdDescuento = _baseDatos.CrearParametro("@IdDescuento", descuento.IdDescuento, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdDescuento);

                IDataParameter parametroPorcentaje = _baseDatos.CrearParametro("@Porcentaje", descuento.Porcentaje, ParameterDirection.Input);
                comando.Parameters.Add(parametroPorcentaje);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", descuento.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", descuento.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_CatDescuentos).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible actualizar el descuento.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada ActivarDesactivarDescuento(CatDescuentos descuento)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatDescuentosActivarDesactivar", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdDescuento = _baseDatos.CrearParametro("@IdDescuento", descuento.IdDescuento, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdDescuento);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", descuento.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@EsActivo", descuento.EsActivo, ParameterDirection.Input);
                comando.Parameters.Add(parametroEsActivo);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_CatDescuentosActivarDesactivar).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible realizar la operación del descuento.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada GuardarConfiguracion(ConfiguracionDescuento descuentoConfiguracion)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_DescuentosConfiguracion", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdDescuento = _baseDatos.CrearParametro("@IdDescuento", descuentoConfiguracion.IdDescuento, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdDescuento);

                IDataParameter parametroDiaAplica = _baseDatos.CrearParametro("@DiaAplica", descuentoConfiguracion.IdDia, ParameterDirection.Input);
                comando.Parameters.Add(parametroDiaAplica);

                IDataParameter parametroHoraInicio = _baseDatos.CrearParametro("@HoraInicio", descuentoConfiguracion.HoraInicio, ParameterDirection.Input);
                comando.Parameters.Add(parametroHoraInicio);

                IDataParameter parametroHoraFin = _baseDatos.CrearParametro("@HoraFin", descuentoConfiguracion.HoraFin, ParameterDirection.Input);
                comando.Parameters.Add(parametroHoraFin);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", descuentoConfiguracion.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spI_DescuentosConfiguracion).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar la configuracion del descuento.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada ConsultarDescuentoConfiguracion(int idDescuento)
        {
            ListaConfiguracionDescuento = new List<ConfiguracionDescuento>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_DescuentosConfiguracion", conexion);

                IDataParameter parametroIdDescuento = _baseDatos.CrearParametro("@IdDescuento", idDescuento, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdDescuento);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ConfiguracionDescuento descuento = new ConfiguracionDescuento();
                    
                    descuento.IdDescuentoConfiguracion = (int)lector["IdDescuentoConfiguracion"];
                    descuento.IdDescuento = (int)lector["IdDescuento"];
                    descuento.IdDia = (int)lector["IdDia"];
                    descuento.Dia = lector["Dia"].ToString();
                    descuento.HoraInicio = (DateTime)lector["HoraInicio"];
                    descuento.HoraFin = (DateTime)lector["HoraFin"];
                    descuento.EsActivo = (bool)lector["EsActivo"];

                    ListaConfiguracionDescuento.Add(descuento);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de las configuraciones de descuentos.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();

                conexion.Dispose();
            }
        }
        
        public ExcepcionPersonalizada ActivarDesactivarDescuentoConfiguracion(ConfiguracionDescuento descuento)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_DescuentosConfiguracionActivarDesactivar", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdDescuento = _baseDatos.CrearParametro("@IdDescuentoConfiguracion", descuento.IdDescuentoConfiguracion, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdDescuento);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", descuento.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@EsActivo", descuento.EsActivo, ParameterDirection.Input);
                comando.Parameters.Add(parametroEsActivo);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_DescuentosConfiguracionActivarDesactivar).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible realizar la operación del descuento.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

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

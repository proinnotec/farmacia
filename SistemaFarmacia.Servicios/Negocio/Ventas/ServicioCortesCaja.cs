using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Ventas
{
    public class ServicioCortesCaja
    {
        private IBaseDeDatos _baseDatos;
        public List<CorteCaja> ListaCortesCaja { get; set; }
        public List<Usuario> ListaVendedores { get; set; }

        public ServicioCortesCaja(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ObtenerCortesCaja(int anio)
        {
            ListaCortesCaja = new List<CorteCaja>();

            IDbConnection conexion = null;
            
            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CortesCajaListado", conexion);

                IDataParameter parametroAnio = _baseDatos.CrearParametro("@Anio", anio, ParameterDirection.Input);
                comando.Parameters.Add(parametroAnio);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CorteCaja corte = new CorteCaja();

                    corte.IdCorteCaja = (int)lector["IdCorteCaja"];
                    corte.Fecha = (DateTime)lector["Fecha"];
                    corte.IdUsuario = (int)lector["IdUsuario"];
                    corte.NombreUsuario = lector["NombreUsuario"].ToString();
                    corte.CorteAbierto = (bool)lector["CorteAbierto"];

                    ListaCortesCaja.Add(corte);
                }

                lector.Close();
                
                return null;
            }
            catch(Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener el listado de cortes de caja.", excepcionCapturada);
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
        
        public ExcepcionPersonalizada GenerarCorteCaja(CorteCaja corte)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spUI_CortesCaja", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroUsuario = _baseDatos.CrearParametro("@IdUsuario", corte.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spUI_CortesCaja).");

                transaccion.Commit();

                return null;
            }

            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible generar el corte de caja.", excepcionCapturada);

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

        public ExcepcionPersonalizada ObtenerListaUsuariosCortesCajaReporte(DateTime fecha)
        {
            ListaVendedores = new List<Usuario>();

            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_UsuariosCorteCaja", conexion);

                IDataParameter parametroFechaInicio = _baseDatos.CrearParametro("@Fecha", fecha, ParameterDirection.Input);
                comando.Parameters.Add(parametroFechaInicio);

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

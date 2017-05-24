using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaFarmacia.Servicios.Negocio.Administracion
{
    public class ServicioCatalogoUsuarios
    {
        private IBaseDeDatos _baseDatos;

        public List<Usuario> ListaUsuarios { get; private set; }
        public List<Usuario> ListaUsuariosEncontrados { get; private set; }
        public ServicioCatalogoUsuarios(IBaseDeDatos baseDeDatos)
        {
            _baseDatos = baseDeDatos;
        }

        public ExcepcionPersonalizada ObtenerUsuarios()
        {
            ListaUsuarios = new List<Usuario>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatUsuarios", conexion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuario = new Usuario();

                    usuario.IdUsuario = (int)lector["IdUsuario"];
                    usuario.Nombre = lector["Nombre"].ToString();
                    usuario.ApellidoPaterno = lector["ApellidoPaterno"].ToString();
                    usuario.ApellidoMaterno = lector["ApellidoMaterno"].ToString();
                    usuario.NombreUsuario = lector["NombreUsuario"].ToString();
                    usuario.UserPassword = lector["UserPassword"].ToString();
                    usuario.IdPerfil = (int)lector["IdPerfil"];
                    usuario.Perfil = lector["Perfil"].ToString();
                    usuario.EsActivo = (bool)lector["EsActivo"];

                    ListaUsuarios.Add(usuario);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de usuarios.", excepcionCapturada);
                return excepcion;

            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }
        }


        public ExcepcionPersonalizada ValidarNombreUsuario(Usuario usuario)
        {
            IDbConnection conexion = null;
            ListaUsuariosEncontrados = new List<Usuario>();

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatUsuarios", conexion);

                IDataParameter parametroUsuario = _baseDatos.CrearParametro("@NombreUsuario", usuario.NombreUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroUsuario);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario usuarioEncontrado = new Usuario();
                    usuarioEncontrado.IdUsuario = (int)lector["IdUsuario"];
                    usuarioEncontrado.Nombre = lector["Nombre"].ToString();
                    usuarioEncontrado.ApellidoPaterno = lector["ApellidoPaterno"].ToString();
                    usuarioEncontrado.ApellidoMaterno = lector["ApellidoMaterno"].ToString();
                    usuarioEncontrado.NombreUsuario = lector["NombreUsuario"].ToString();
                    usuarioEncontrado.UserPassword = lector["UserPassword"].ToString();
                    usuarioEncontrado.IdPerfil = (int)lector["IdPerfil"];
                    usuarioEncontrado.Perfil = lector["Perfil"].ToString();
                    usuarioEncontrado.EsActivo = (bool)lector["EsActivo"];

                    ListaUsuariosEncontrados.Add(usuarioEncontrado);

                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de usuarios.", excepcionCapturada);
                return excepcion;

            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada ActivarDesactivarUsuario(Usuario usuario)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatUsuariosActivarDesactivar", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", usuario.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@EsActivo", usuario.EsActivo, ParameterDirection.Input);
                comando.Parameters.Add(parametroEsActivo);

                IDataParameter parametroIdUsuarioRegistra = _baseDatos.CrearParametro("@IdUsuarioRegistra", usuario.IdUsuarioRegistra, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuarioRegistra);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_CatUsuariosActivarDesactivar).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue realizar la operación del usuario.", excepcionCapturada);

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

        public ExcepcionPersonalizada GuardarUsuario(Usuario usuario)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_CatUsuarios", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroNombre = _baseDatos.CrearParametro("@Nombre", usuario.Nombre, ParameterDirection.Input);
                comando.Parameters.Add(parametroNombre);

                IDataParameter parametroApellidoPaterno = _baseDatos.CrearParametro("@APaterno", usuario.ApellidoPaterno, ParameterDirection.Input);
                comando.Parameters.Add(parametroApellidoPaterno);

                IDataParameter parametroApellidoMaterno = _baseDatos.CrearParametro("@AMaterno", usuario.ApellidoMaterno, ParameterDirection.Input);
                comando.Parameters.Add(parametroApellidoMaterno);

                IDataParameter parametroUsuario = _baseDatos.CrearParametro("@Usuario", usuario.NombreUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroUsuario);

                IDataParameter parametroPassword = _baseDatos.CrearParametro("@Password", usuario.UserPassword, ParameterDirection.Input);
                comando.Parameters.Add(parametroPassword);

                IDataParameter parametroPerfil = _baseDatos.CrearParametro("@IdPerfil", usuario.IdPerfil, ParameterDirection.Input);
                comando.Parameters.Add(parametroPerfil);

                IDataParameter parametroIdUsuarioRegistra = _baseDatos.CrearParametro("@IdUsuarioRegistra", usuario.IdUsuarioRegistra, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuarioRegistra);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spI_CatUsuarios).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar al usuario.", excepcionCapturada);

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

        public ExcepcionPersonalizada ActualizarUsuario(Usuario usuario)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatUsuarios", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", usuario.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroNombre = _baseDatos.CrearParametro("@Nombre", usuario.Nombre, ParameterDirection.Input);
                comando.Parameters.Add(parametroNombre);

                IDataParameter parametroApellidoPaterno = _baseDatos.CrearParametro("@APaterno", usuario.ApellidoPaterno, ParameterDirection.Input);
                comando.Parameters.Add(parametroApellidoPaterno);

                IDataParameter parametroApellidoMaterno = _baseDatos.CrearParametro("@AMaterno", usuario.ApellidoMaterno, ParameterDirection.Input);
                comando.Parameters.Add(parametroApellidoMaterno);

                IDataParameter parametroUsuario = _baseDatos.CrearParametro("@Usuario", usuario.NombreUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroUsuario);

                IDataParameter parametroPassword = _baseDatos.CrearParametro("@Password", usuario.UserPassword, ParameterDirection.Input);
                comando.Parameters.Add(parametroPassword);

                IDataParameter parametroPerfil = _baseDatos.CrearParametro("@IdPerfil", usuario.IdPerfil, ParameterDirection.Input);
                comando.Parameters.Add(parametroPerfil);

                IDataParameter parametroIdUsuarioRegistra = _baseDatos.CrearParametro("@IdUsuarioRegistra", usuario.IdUsuarioRegistra, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuarioRegistra);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_CatUsuarios).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible actualizar la información del usuario.", excepcionCapturada);

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

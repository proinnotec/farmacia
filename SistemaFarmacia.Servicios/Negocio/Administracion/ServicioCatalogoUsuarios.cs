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
    }
}

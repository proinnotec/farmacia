using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Operaciones
{
    public class ServicioDatosAcceso
    {
        private IBaseDeDatos _baseDatos;

        public Usuario LoginUsuario { get; set; }

        public ServicioDatosAcceso(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarLogin(Usuario usuario)
        {
            IDbConnection conexion = null;
            
            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_Login", conexion);

                IDataParameter parametroUsuario = _baseDatos.CrearParametro("@Usuario", usuario.NombreUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroUsuario);

                IDataParameter parametroPass = _baseDatos.CrearParametro("@Password", usuario.UserPassword, ParameterDirection.Input);
                comando.Parameters.Add(parametroPass);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    LoginUsuario = new Usuario();

                    LoginUsuario.IdUsuario = (int)lector["IdUsuario"];
                    LoginUsuario.Nombre = lector["Nombre"].ToString();
                    LoginUsuario.ApellidoPaterno = lector["ApellidoPaterno"].ToString();
                    LoginUsuario.ApellidoMaterno = lector["ApellidoMaterno"].ToString();
                    LoginUsuario.IdPerfil = (int)lector["IdPerfil"];
                    LoginUsuario.NombreUsuario = usuario.NombreUsuario;
                    LoginUsuario.IdSucursal = usuario.IdSucursal;
                    LoginUsuario.Sucursal = usuario.Sucursal;
                    LoginUsuario.Direccion = lector["Direccion"].ToString();
                    
                }

                lector.Close();

                return null;
            }
            catch (Exception ex)
            {
                ExcepcionPersonalizada excepcioncapturada = new ExcepcionPersonalizada("No fue posible obtener los datos del logín", ex);
                return excepcioncapturada;
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

using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Administracion
{
    public class ServicioCatalogoPerfiles
    {
        private IBaseDeDatos _baseDatos;
        public List<Perfiles> ListaPerfiles { get; private set; }

        public ServicioCatalogoPerfiles(IBaseDeDatos baseDeDatos)
        {
            _baseDatos = baseDeDatos;
        }

        public ExcepcionPersonalizada ConsultarPerfiles(Perfiles perfiles)
        {
            IDbConnection conexion = null;

            ListaPerfiles = new List<Perfiles>();

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatPerfiles", conexion);

                if (perfiles.EsActivo)
                {
                    IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@EsActivo", perfiles.EsActivo, ParameterDirection.Input);
                    comando.Parameters.Add(parametroEsActivo);
                }

                if (perfiles.IdPerfil > 0)
                {
                    IDataParameter parametroIdPerfil = _baseDatos.CrearParametro("@IdPerfil", perfiles.IdPerfil, ParameterDirection.Input);
                    comando.Parameters.Add(parametroIdPerfil);
                }

                IDataParameter parametroNombre = _baseDatos.CrearParametro("@Nombre", perfiles.Nombre, ParameterDirection.Input);
                comando.Parameters.Add(parametroNombre);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", perfiles.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Perfiles catPerfiles = new Perfiles();

                    catPerfiles.IdPerfil = (int)lector["IdPerfil"];
                    catPerfiles.Nombre = lector["Nombre"].ToString();
                    catPerfiles.Descripcion = lector["Descripcion"].ToString();
                    catPerfiles.EsActivo = (bool)lector["EsActivo"];

                    ListaPerfiles.Add(catPerfiles);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de los elementos del catálogo de perfiles.", excepcionCapturada);
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

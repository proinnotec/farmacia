using SistemaFarmacia.Servicios.Fabricas;
using ProInnotec.Core.Entidades.Datos;
using System.Configuration;

namespace SistemaFarmacia.Controladores
{
    public class BaseController
    {
        public IBaseDeDatos BaseDeDatosTienda
        {
            get
            {
                FabricaBaseDeDatos fabricaBaseDeDatos = new FabricaBaseDeDatos(ConfigurationManager.ConnectionStrings);
                IBaseDeDatos baseDeDatos = fabricaBaseDeDatos.ObtenerBaseDeDatos("conexionSistemaFarmacia");
                
                return baseDeDatos;
            }
        }

        private string[] ElementosCadenaConexion
        {
            get
            {
                string[] elementosCadenaConexion = BaseDeDatosTienda.CadenaDeConexion.Split(';');

                return elementosCadenaConexion;
            }
        }

        public string InstanciaServidor
        {
            get
            {
                string servidor = ElementosCadenaConexion[0];

                servidor = servidor.ToUpper();

                servidor = servidor.Replace("SERVER=", "");

                return servidor.ToLower();
            }
        }

        public string NombreBaseDatos
        {
            get
            {
                string nombreBaseDatos = ElementosCadenaConexion[1];

                nombreBaseDatos = nombreBaseDatos.ToUpper();

                nombreBaseDatos = nombreBaseDatos.Replace("DATABASE=", "");

                return nombreBaseDatos.ToLower();
            }
        }
    }
}

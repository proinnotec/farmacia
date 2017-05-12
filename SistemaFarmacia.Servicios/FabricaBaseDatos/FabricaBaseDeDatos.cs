using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Servicios.Datos;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace SistemaFarmacia.Servicios.Fabricas
{
    public class FabricaBaseDeDatos
    {
        private readonly ConnectionStringSettingsCollection _cadenasDeConexion;

        public FabricaBaseDeDatos(ConnectionStringSettingsCollection cadenasDeConexion)
        {
            _cadenasDeConexion = cadenasDeConexion;
        }

        /// <summary>
        /// Obtiene una base de datos
        /// </summary>
        /// <param name="conexionElegida">Nombre de la conexión de la base de datos que se desea obtener</param>
        /// <returns>Devuelve un objeto para interactuar con la base de datos</returns>
        public IBaseDeDatos ObtenerBaseDeDatos(string conexionElegida)
        {
            ServicioBaseDeDatos servicioBaseDatos = new ServicioBaseDeDatos(_cadenasDeConexion);

            IList<IBaseDeDatos> listaBasesDatos = servicioBaseDatos.BasesDeDatosDisponibles;

            IBaseDeDatos baseDeDatos = listaBasesDatos.FirstOrDefault(baseDatos => baseDatos.NombreConexion == conexionElegida);

            return baseDeDatos;
        }
    }
}
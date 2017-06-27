using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Servicios.Negocio.Busqueda;
using SistemaFarmacia.Vistas.Procesos;
using System.Collections.Generic;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class BusquedaController : BaseController
    {
        private ServicioBusqueda _servicioBusqueda;
        private frmAjustes _vista;

        public BusquedaController(frmAjustes vista)
        {
            _servicioBusqueda = new ServicioBusqueda(BaseDeDatosTienda);
            _vista = vista;
        }

    }
}

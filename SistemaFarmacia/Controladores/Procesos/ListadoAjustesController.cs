using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes;
using SistemaFarmacia.Servicios.Negocio.Ajustes;
using SistemaFarmacia.Vistas.Procesos;
using System.Collections.Generic;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class ListadoAjustesController : BaseController
    {
        private ServicioListadoAjustes _servicioListadoAjustes;
        private frmListadoAjustes _vista;

        public ListadoAjustesController(frmListadoAjustes vista)
        {
            _servicioListadoAjustes = new ServicioListadoAjustes(BaseDeDatosTienda);
            _vista = vista;
        }

        public void ConsultaAjusteProductos(int anio)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioListadoAjustes.ConsultarAjustesProductos(anio);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de los ajustes.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<AjustesProductosListado> ListaAjustes = _servicioListadoAjustes.ListaAjustesProductos;
            _vista.AsignarListaAjustes(ListaAjustes);

        }

    }
}

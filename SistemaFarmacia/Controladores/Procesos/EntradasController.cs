using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Servicios.Negocio.Almacen;
using SistemaFarmacia.Vistas.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class EntradasController:BaseController
    {
        private ServicioEntradas _servicioEntradas;
        private frmEntradas _vista;

        public EntradasController(frmEntradas vista)
        {
            _vista = vista;
            _servicioEntradas = new ServicioEntradas(BaseDeDatosTienda);
        }

        public void ConsultaEntradasCabecera(int anio)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.ConsultarEntradasCabecera(anio);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de las entradas.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<EntradaProductoListado> ListaEntradas = _servicioEntradas.ListaEntradasProductos;
            _vista.AsignarListaEntradas(ListaEntradas);
            
        }
    }
}

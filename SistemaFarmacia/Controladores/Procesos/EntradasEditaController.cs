using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Servicios.Negocio.Almacen;
using SistemaFarmacia.Vistas.Procesos;
using System.Collections.Generic;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class EntradasEditaController: BaseController
    {
        private ServicioEntradas _servicioEntradas;
        private frmEditaEntradas _vista;

        public EntradasEditaController(frmEditaEntradas vista)
        {
            _servicioEntradas = new ServicioEntradas(BaseDeDatosTienda);
            _vista = vista;
        }

        public void ConsultaEntradasDetalles(int idEntrada)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.ConsultarDetalles(idEntrada);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de los detalles de las entradas.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<EntradaProductoDetalle> ListaEntradaDetalles = _servicioEntradas.ListaEntradasDetalles;
            _vista.AsignarListaDetalles(ListaEntradaDetalles);

        }

        public void BajaEntrada(EntradaProducto entrada)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.BajaEntrada(entrada);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar dar de baja la entrada.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información de la entrada.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);
        }
    }
}

using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Ventas;
using SistemaFarmacia.Servicios.Negocio.Ventas;
using SistemaFarmacia.Vistas.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Ventas
{
    public class ReimpresionTicketController: BaseController
    {
        private frmRepTicketReImp _vista;
        private ServicioVentas _servicioVentas;

        public ReimpresionTicketController(frmRepTicketReImp vista)
        {
            _vista = vista;
            _servicioVentas = new ServicioVentas(BaseDeDatosTienda);
        }

        public void ObtenerListaTickets(Ticket opcionesBusqueda)
        {
            ExcepcionPersonalizada resultado = _servicioVentas.ObtenerListaTickets(opcionesBusqueda);

            if(resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message, resultado.ToString(), false);
                return;
            }

            List<Ticket> lista = _servicioVentas.ListaTickets;
            _vista.AsignarListaDeTickets(lista);
        }

        public void ObtenerTicket(Int64 IdVenta)
        {
            ExcepcionPersonalizada resultado = _servicioVentas.ObtenerTicket(IdVenta);

            if (resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message, resultado.ToString(), false);
                return;
            }

            List<ContextoTicket> lista = _servicioVentas.ListaTicket;
            _vista.VerReporte(lista);
        }

        public void ObtenerListaVendedores(DateTime fechaInicio, DateTime fechaFin)
        {
            ExcepcionPersonalizada resultado = _servicioVentas.ObtenerListaUsuariosCortesCajaReporte(fechaInicio, fechaFin);

            if (resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message.ToString(), resultado.InnerException.ToString(), false);
                return;
            }

            List<Usuario> lista = _servicioVentas.ListaVendedores;
            _vista.LlenarComboVendedores(lista);
        }
    }
}

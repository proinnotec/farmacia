using ProInnotec.Core.Entidades.ManejoExcepciones;
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
    public class CortesCajaRepController: BaseController
    {
        private frmRepCortesCaja _vista;
        private ServicioCortesCaja _servicioCortesCaja;
        public CortesCajaRepController(frmRepCortesCaja vista)
        {
            _vista = vista;
            _servicioCortesCaja = new ServicioCortesCaja(BaseDeDatosTienda);
        }

        public void ObtenerListaVendedores(DateTime fechaInicio, DateTime fechaFin)
        {
            ExcepcionPersonalizada resultado = _servicioCortesCaja.ObtenerListaUsuariosCortesCajaReporte(fechaInicio, fechaFin);

            if (resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message.ToString(), resultado.InnerException.ToString(), false);
                return;
            }

            List<Usuario> lista = _servicioCortesCaja.ListaVendedores;
            _vista.LlenarComboVendedores(lista);
        }

        public void GenerarCortesCajaReporte(DateTime fechaInicio, DateTime fechaFin, int idVendedor, bool esCorteAbierto)
        {
            ExcepcionPersonalizada resultado = _servicioCortesCaja.GenerarCortesCajaReporte(fechaInicio, fechaFin, idVendedor, esCorteAbierto);

            if (resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message.ToString(), resultado.InnerException.ToString(), false);
                return;
            }

            List<CorteCajaReporte> lista = _servicioCortesCaja.ListaCorteCajaReporte;
            _vista.LlenarDatosReporte(lista);
        }
    }
}

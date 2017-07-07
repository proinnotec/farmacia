using ProInnotec.Core.Entidades.ManejoExcepciones;
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
    public class CortesCajaController: BaseController
    {
        private ServicioCortesCaja _servicioCortesCaja;
        private frmCortesCaja _vista;

        public CortesCajaController(frmCortesCaja vista)
        {
            _servicioCortesCaja = new ServicioCortesCaja(BaseDeDatosTienda);
            _vista = vista;
        }

        public void ObtenerCortesCaja(int anio)
        {
            ExcepcionPersonalizada resultado = _servicioCortesCaja.ObtenerCortesCaja(anio);

            if(resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message.ToString(), resultado.InnerException.ToString(), false);
                return;
            }

            List<CorteCaja> lista = _servicioCortesCaja.ListaCortesCaja;
            _vista.AsignarListaDeCortes(lista);
        }

        public void GenerarCorteCaja(CorteCaja corte)
        {
            ExcepcionPersonalizada resultado = _servicioCortesCaja.GenerarCorteCaja(corte);

            if (resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message.ToString(), resultado.InnerException.ToString(), false);
                return;
            }

            _vista.MostrarDialogoResultado(_vista.Text, "Se generó correctamente el corte de caja", string.Empty, true);

            ObtenerCortesCaja(corte.Fecha.Year);
        }
    }
}

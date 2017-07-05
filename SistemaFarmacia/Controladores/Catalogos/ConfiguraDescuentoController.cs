using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Negocio;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Catalogos
{
    public class ConfiguraDescuentoController: BaseController
    {
        private ServicioCatalogoDescuentos _servicioCatalogoDescuentos;
        private ServicioFuncionesGenerales _servicioFuncionesGenerales;

        frmConfiguraDescuentos _vista;

        public ConfiguraDescuentoController(frmConfiguraDescuentos vista)
        {
            _servicioCatalogoDescuentos = new ServicioCatalogoDescuentos(BaseDeDatosTienda);
            _servicioFuncionesGenerales = new ServicioFuncionesGenerales(BaseDeDatosTienda);

            _vista = vista;
        }

        public void ConsultarDescuentoConfiguracion(int idDescuento)
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoDescuentos.ConsultarDescuentoConfiguracion(idDescuento);

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la información de las configuraciones de descuentos, no se pueden cargar los datos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<ConfiguracionDescuento> lista = _servicioCatalogoDescuentos.ListaConfiguracionDescuento;

            _vista.AsignarListaDescuentos(lista);
            _vista.ReestablecerDatos();
        }

        public void ConsultarDiasSemana()
        {
            ExcepcionPersonalizada resultado = _servicioFuncionesGenerales.ObtenerDiasSemana();

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la lista de los días de la semana.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);

                return;
            }

            List<DiasSemana> lista = _servicioFuncionesGenerales.ListaDiasSemana;

            _vista.LlenarDatosComboDias(lista);

        }

        public void GuardarDescuentoConfiguracion(ConfiguracionDescuento configuracion)
        {
            string mensaje = string.Empty;

            ExcepcionPersonalizada resultado = null;
            resultado = _servicioCatalogoDescuentos.GuardarConfiguracion(configuracion);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar la configuración del descuento.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del descuento.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            ConsultarDescuentoConfiguracion(configuracion.IdDescuento);
        }

        public void ActivarDesactivarDescuentoConfiguracion(ConfiguracionDescuento configuracion)
        {
            string mensaje = string.Empty;

            ExcepcionPersonalizada resultado = null;
            resultado = _servicioCatalogoDescuentos.ActivarDesactivarDescuentoConfiguracion(configuracion);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar la configuración del descuento.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del descuento.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            ConsultarDescuentoConfiguracion(configuracion.IdDescuento);
        }
    }
}

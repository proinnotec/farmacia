using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
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
        ServicioCatalogoDescuentos _servicioCatalogoDescuentos;
        frmConfiguraDescuentos _vista;

        public ConfiguraDescuentoController(frmConfiguraDescuentos vista)
        {
            _servicioCatalogoDescuentos = new ServicioCatalogoDescuentos(BaseDeDatosTienda);
            _vista = vista;
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

            //_vista.Cerrar();
        }
    }
}

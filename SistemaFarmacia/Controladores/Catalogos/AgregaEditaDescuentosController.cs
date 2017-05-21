using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Enumerados;
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
    public class AgregaEditaDescuentosController: BaseController
    {
        ServicioCatalogoDescuentos _servicioCatalogoDescuentos;
        frmAgregaEditaDescuentos _vista;
        public AgregaEditaDescuentosController(frmAgregaEditaDescuentos vista)
        {
            _servicioCatalogoDescuentos = new ServicioCatalogoDescuentos(BaseDeDatosTienda);
            _vista = vista;
        }
        public void GuardarDescuento(CatDescuentos descuento, EnumeradoAccion accion)
        {
            string mensaje = string.Empty;

            ExcepcionPersonalizada resultado = null;
            switch ( accion )
            {
                case EnumeradoAccion.Alta:
                    resultado = _servicioCatalogoDescuentos.GuardarDescuento(descuento);
                    break;

                case EnumeradoAccion.Edicion:
                    resultado = _servicioCatalogoDescuentos.ActualizarDescuento(descuento);
                    break;

            }            

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar la información de los descuentos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del descuento.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            _vista.Cerrar();

        }
    }
}

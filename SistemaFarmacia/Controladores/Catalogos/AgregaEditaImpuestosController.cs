using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Catalogos;

namespace SistemaFarmacia.Controladores.Catalogos
{
    public class AgregaEditaImpuestosController : BaseController
    {
        ServicioCatalogoImpuestos _servicioCatalogoImpuestos;
        frmAgregaEditaImpuestos _vista;
        public AgregaEditaImpuestosController(frmAgregaEditaImpuestos vista)
        {
            _servicioCatalogoImpuestos = new ServicioCatalogoImpuestos(BaseDeDatosTienda);
            _vista = vista;
        }
        public void GuardarImpuesto(CatImpuestos impuesto, EnumeradoAccion accion)
        {
            string mensaje = string.Empty;

            ExcepcionPersonalizada resultado = null;
            switch (accion)
            {
                case EnumeradoAccion.Alta:
                    resultado = _servicioCatalogoImpuestos.GuardarImpuesto(impuesto);
                    break;

                case EnumeradoAccion.Edicion:
                    resultado = _servicioCatalogoImpuestos.ActualizarImpuesto(impuesto);
                    break;

            }

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar la información de los impuestos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del impuesto.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            _vista.Cerrar();

        }

    }
}

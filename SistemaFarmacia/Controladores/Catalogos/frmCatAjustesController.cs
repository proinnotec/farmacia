using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Catalogos;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using ProInnotec.Core.Entidades.ManejoExcepciones;

namespace SistemaFarmacia.Controladores.Catalogos
{
    public class frmCatAjustesController : BaseController
    {
        private frmCatAjustes _vista;
        ServicioCatalogoAjustes _servicioCatalogoAjustes;

        public frmCatAjustesController(frmCatAjustes vista)
        {
            _vista = vista;
            _servicioCatalogoAjustes = new ServicioCatalogoAjustes(BaseDeDatosTienda);
        }

        public List<CatAjustes> ListaAjustes()
        {
            ExcepcionPersonalizada excepcionConsultarTiposAjuste = _servicioCatalogoAjustes.ConsultarAjustes();
            if (excepcionConsultarTiposAjuste == null)
            {
                return _servicioCatalogoAjustes.ListaAjustes;
            }
            _vista.MostrarDialogoResultado(_vista.Text, excepcionConsultarTiposAjuste.Message.ToString(), excepcionConsultarTiposAjuste.InnerException.ToString(), false);
            return new List<CatAjustes>();
        }

        public void ActivarDesactivarTipoAjuste(CatAjustes ajuste)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioCatalogoAjustes.ActivarDesactivarImpuesto(ajuste);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar actualizar la información de los impuestos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del usuario.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            ConsultarTipoAjuste();
        }

        public void GuardarTipoAjuste(CatAjustes ajuste)
        {
            ExcepcionPersonalizada excepcionGuardarTipoAjuste = _servicioCatalogoAjustes.GuardarAjuste(ajuste);
            if (excepcionGuardarTipoAjuste == null)
            {
                string mensaje = "El tipo de ajuste se guardó correctamente.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, true);
                _vista.AsigarListaTiposAjustes(this.ListaAjustes());
                _vista.LimpiarFormulario();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionGuardarTipoAjuste.Message.ToString(), excepcionGuardarTipoAjuste.InnerException.ToString(), false);
            }
        }

        public void ConsultarTipoAjuste()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoAjustes.ConsultarAjustes();

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la información del tipo de ajuste, no se pueden cargar los datos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<CatAjustes> lista = _servicioCatalogoAjustes.ListaAjustes;

            _vista.AsigarListaTiposAjustes(lista);
        }
    }
}

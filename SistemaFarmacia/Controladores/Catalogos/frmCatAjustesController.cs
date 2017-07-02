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

        public void EliminarTipoAjuste(CatAjustes ajuste)
        {
            ExcepcionPersonalizada excepcionEliminarTipoAjuste = _servicioCatalogoAjustes.EliminarAjuste(ajuste);
            if (excepcionEliminarTipoAjuste == null)
            {
                string mensaje = "El cambio se realizó correctamente.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, true);
                _vista.AsigarListaTiposAjustes(this.ListaAjustes());
                _vista.LimpiarFormulario();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionEliminarTipoAjuste.Message.ToString(), excepcionEliminarTipoAjuste.InnerException.ToString(), false);
            }
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

    }
}

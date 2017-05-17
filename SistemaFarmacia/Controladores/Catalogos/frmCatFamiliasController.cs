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
    public class frmCatFamiliasController : BaseController
    {
        private frmCatFamilias _vista;
        ServicioCatalogoFamilias _servicioCatalogoFamilias;

        public frmCatFamiliasController(frmCatFamilias vista)
        {
            _vista = vista;
            _servicioCatalogoFamilias = new ServicioCatalogoFamilias(BaseDeDatosTienda);
        }

        public List<CatFamilias> ListaFamilias()
        {
            ExcepcionPersonalizada excepcionConsultarFamilias =  _servicioCatalogoFamilias.ConsultarFamilias();
            if (excepcionConsultarFamilias == null)
            {
                return _servicioCatalogoFamilias.ListaFamilias;
            }
            _vista.MostrarDialogoResultado(_vista.Text, excepcionConsultarFamilias.Message.ToString(), excepcionConsultarFamilias.InnerException.ToString(), false);
            return new List<CatFamilias>();
        }

        public void EliminarFamilia(CatFamilias familia)
        {
            ExcepcionPersonalizada excepcionEliminarFamilia = _servicioCatalogoFamilias.EliminarFamilia(familia);
            if (excepcionEliminarFamilia == null)
            {
                string mensaje = "La familia de productos se eliminó correctamente.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, true);
                _vista.AsigarListaFamilias(this.ListaFamilias());
                _vista.LimpiarFormulario();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionEliminarFamilia.Message.ToString(), excepcionEliminarFamilia.InnerException.ToString(), false);
            }
        }

        public void EditarFamilia(CatFamilias familia)
        {
            ExcepcionPersonalizada excepcionEditarFamilia = _servicioCatalogoFamilias.EditarFamilia(familia);
            if (excepcionEditarFamilia == null)
            {
                string mensaje = "La familia de productos se editó correctamente.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, true);
                _vista.AsigarListaFamilias(this.ListaFamilias());
                _vista.LimpiarFormulario();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionEditarFamilia.Message.ToString(), excepcionEditarFamilia.InnerException.ToString(), false);
            }
        }

        public void GuardarFamilia(CatFamilias familia)
        {
            ExcepcionPersonalizada excepcionGuardarFamilia = _servicioCatalogoFamilias.GuardarFamilia(familia);
            if (excepcionGuardarFamilia == null)
            {
                string mensaje = "La familia de productos se guardó correctamente.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, true);
                _vista.AsigarListaFamilias(this.ListaFamilias());
                _vista.LimpiarFormulario();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionGuardarFamilia.Message.ToString(), excepcionGuardarFamilia.InnerException.ToString(), false);
            }            
        }

    }
}

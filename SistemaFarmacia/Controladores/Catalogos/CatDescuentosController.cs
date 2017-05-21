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
    class CatDescuentosController: BaseController
    {
        private frmCatDescuentos _vista;
        ServicioCatalogoDescuentos _servicioCatalogoDescuentos;

        public CatDescuentosController(frmCatDescuentos vista)
        {
            _servicioCatalogoDescuentos = new ServicioCatalogoDescuentos(BaseDeDatosTienda);
            _vista = vista;
        }

        public void ConsultarDescuentos()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoDescuentos.ConsultarDescuentos();

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la información de los descuentos, no se pueden cargar los datos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<CatDescuentos> lista = _servicioCatalogoDescuentos.ListaCatDescuentos;

            _vista.AsignarListaDescuentos(lista);
        }

        public void ActivarDesactivarDescuento(CatDescuentos descuento)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioCatalogoDescuentos.ActivarDesactivarDescuento(descuento);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar actualizar la información de los descuentos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }
            
            mensaje = "Se ha guardado correctamente la información del usuario.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            ConsultarDescuentos();
        }
    }
}

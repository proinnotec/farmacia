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
            _vista = vista;
            _servicioCatalogoDescuentos = new ServicioCatalogoDescuentos(BaseDeDatosTienda);
        }

        public void ConsultarDescuentos()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoDescuentos.ConsultarDescuentos();

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la información de los descuentos, no se pueden cargar los datos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);

            }

            List<CatDescuentos> lista = _servicioCatalogoDescuentos.ListaCatDescuentos;

            _vista.AsignarListaDescuentos(lista);
        }
    }
}

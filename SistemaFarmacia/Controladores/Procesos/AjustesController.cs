using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class AjustesController: BaseController
    {
        ServicioCatalogoTiposAjustes _servicioCatalogoTiposAjustes;
        private frmAjustes _vista;

        public AjustesController(frmAjustes vista)
        {
            _vista = vista;

            _servicioCatalogoTiposAjustes = new ServicioCatalogoTiposAjustes(BaseDeDatosTienda);

        }

        public ExcepcionPersonalizada ConsultarTiposAjustes(CatTipoAjustes tipoAjustes)
        {            
            ExcepcionPersonalizada resultado = _servicioCatalogoTiposAjustes.ConsultarTiposAjustes(tipoAjustes);

            if (resultado == null)
            {

            }

            List<CatTipoAjustes> listaTipoAjustes = _servicioCatalogoTiposAjustes.ListaTipoAjustes;

            _vista.LlenarComboAjustes(listaTipoAjustes);

            return null;
        }

    }
}

using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Negocio.Busqueda;
using SistemaFarmacia.Servicios.Negocio.Ajustes;
using SistemaFarmacia.Vistas.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class AjustesController : BaseController
    {
        ServicioCatalogoTiposAjustes _servicioCatalogoTiposAjustes;
        ServicioBusqueda _servicioBusqueda;
        ServicioAjustes _servicioAjustes;

        private frmAjustes _vista;

        public AjustesController(frmAjustes vista)
        {
            _vista = vista;

            _servicioCatalogoTiposAjustes = new ServicioCatalogoTiposAjustes(BaseDeDatosTienda);
            _servicioBusqueda = new ServicioBusqueda(BaseDeDatosTienda);

            _servicioAjustes = new ServicioAjustes(BaseDeDatosTienda);
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

        public List<ProductosListado> LlenarListaProductos()
        {

            List<ProductosListado> listaProductos = _servicioBusqueda.ObtenerListadoProductos();

            return listaProductos;
        }

        public void GuardarAjuste(AjustesProductos ajuste)
        {
            string mensaje = string.Empty;

            ExcepcionPersonalizada resultado = null;
            resultado = _servicioAjustes.GuardarAjuste(ajuste);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar el ajuste.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del ajuste.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            _vista.CargarDatos();
            _vista.LimpiarCampos();
        }


    }
}

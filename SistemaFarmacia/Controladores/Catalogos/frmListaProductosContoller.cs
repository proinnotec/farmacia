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
    public class frmListaProductosContoller : BaseController
    {
        private frmListaProductos _vista;
        ServicioCatalogoFamilias _servicioCatalogoFamilias;
        ServicioCatalogoProductos _servicioCatalogoProductos;

        public frmListaProductosContoller(frmListaProductos vista)
        {
            _vista = vista;
            _servicioCatalogoFamilias = new ServicioCatalogoFamilias(BaseDeDatosTienda);
            _servicioCatalogoProductos = new ServicioCatalogoProductos(BaseDeDatosTienda);
        }

        public void EditarEstadoProducto(CatProducto producto)
        {
            ExcepcionPersonalizada excepcionEditarEstadoProducto = _servicioCatalogoProductos.EditarEstadoProducto(producto);
            if (excepcionEditarEstadoProducto == null)
            {
                string mensaje = producto.EsActivo == true ? "El producto se reactivó correctamente." : "El producto se dio de baja correctamente.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, true);
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionEditarEstadoProducto.Message.ToString(), excepcionEditarEstadoProducto.InnerException.ToString(), false);
            }
        }

        public List<CatProducto> ListaProductos(int idFamiliaProducto)
        {
            ExcepcionPersonalizada excepcionConsultarProductos = _servicioCatalogoProductos.ConsultarProductos(idFamiliaProducto);
            if (excepcionConsultarProductos == null)
            {
                return _servicioCatalogoProductos.ListaProductos;
            }
            _vista.MostrarDialogoResultado(_vista.Text, excepcionConsultarProductos.Message.ToString(), excepcionConsultarProductos.InnerException.ToString(), false);
            return new List<CatProducto>();
        }

        public List<CatFamilias> ListaFamilias()
        {
            ExcepcionPersonalizada excepcionConsultarFamilias = _servicioCatalogoFamilias.ConsultarFamilias();
            if (excepcionConsultarFamilias == null)
            {
                return _servicioCatalogoFamilias.ListaFamilias;
            }
            _vista.MostrarDialogoResultado(_vista.Text, excepcionConsultarFamilias.Message.ToString(), excepcionConsultarFamilias.InnerException.ToString(), false);
            return new List<CatFamilias>();
        }
    }
}

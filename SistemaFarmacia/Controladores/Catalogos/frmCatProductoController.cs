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
    public class frmCatProductoController : BaseController
    {
        private frmCatProducto _vista;
        ServicioCatalogoProductos _servicioCatalogoProductos;

        public frmCatProductoController(frmCatProducto vista)
        {
            _vista = vista;
            _servicioCatalogoProductos = new ServicioCatalogoProductos(BaseDeDatosTienda);
        }

        public void GuardarProducto(CatProducto producto)
        {
            ExcepcionPersonalizada excepcionGuardarProducto = _servicioCatalogoProductos.GuardarProducto(producto);
            if (excepcionGuardarProducto == null)
            {
                string mensaje = "El producto se guardó correctamente.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, true);
                _vista.LimpiarFormulario();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionGuardarProducto.Message.ToString(), excepcionGuardarProducto.InnerException.ToString(), false);
            }
        }
    }
}

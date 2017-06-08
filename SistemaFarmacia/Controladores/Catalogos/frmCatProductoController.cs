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
        ServicioCatalogoImpuestos _servicioCatalogoImpuestos;

        public frmCatProductoController(frmCatProducto vista)
        {
            _vista = vista;
            _servicioCatalogoProductos = new ServicioCatalogoProductos(BaseDeDatosTienda);
            _servicioCatalogoImpuestos = new ServicioCatalogoImpuestos(BaseDeDatosTienda);
        }

        public List<CatImpuestos> ListaImpuestos()
        {
            ExcepcionPersonalizada excepcionConsultarImpuestos = _servicioCatalogoImpuestos.ConsultarImpuestos();
            if (excepcionConsultarImpuestos == null)
            {
                return _servicioCatalogoImpuestos.ListaCatImpuestos;
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionConsultarImpuestos.Message.ToString(), excepcionConsultarImpuestos.InnerException.ToString(), false);
                return new List<CatImpuestos>();
            }

        }

        bool EsCodigoBarraValido(CatProducto producto, bool esAlta)
        {
            ExcepcionPersonalizada excepcionValidarCodigosBarra = _servicioCatalogoProductos.ValidarCodigosBarra(producto, esAlta);
            if (excepcionValidarCodigosBarra == null)
            {
                if (_servicioCatalogoProductos.ListaProductos.Count > 0)
                {
                    _vista.MensajeCodigosBarraInvalidos(_servicioCatalogoProductos.ListaProductos);
                    return false;
                }
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionValidarCodigosBarra.Message.ToString(), excepcionValidarCodigosBarra.InnerException.ToString(), false);
                return false;
            }

            return true;
        }

        public void EditarEstadoProducto(CatProducto producto)
        {
            ExcepcionPersonalizada excepcionEditarEstadoProducto = _servicioCatalogoProductos.EditarEstadoProducto(producto);
            if (excepcionEditarEstadoProducto == null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, "El producto se dio de baja correctamente.", string.Empty, true);
                _vista.Close();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionEditarEstadoProducto.Message.ToString(), excepcionEditarEstadoProducto.InnerException.ToString(), false);
            }
        }

        public void EditarProducto(CatProducto producto)
        {
            if (!EsCodigoBarraValido(producto, false))
            {
                return;
            }

            ExcepcionPersonalizada excepcionEditarProducto = _servicioCatalogoProductos.EditarProducto(producto);
            if (excepcionEditarProducto == null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, "El producto se editó correctamente.", string.Empty, true);
                _vista.Close();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionEditarProducto.Message.ToString(), excepcionEditarProducto.InnerException.ToString(), false);
            }
        }

        public void GuardarProducto(CatProducto producto)
        {
            if (!EsCodigoBarraValido(producto, true))
            {
                return;
            }

            ExcepcionPersonalizada excepcionGuardarProducto = _servicioCatalogoProductos.GuardarProducto(producto);
            if (excepcionGuardarProducto == null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, "El producto se guardó correctamente.", string.Empty, true);
                _vista.Close();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionGuardarProducto.Message.ToString(), excepcionGuardarProducto.InnerException.ToString(), false);
            }
        }
    }
}

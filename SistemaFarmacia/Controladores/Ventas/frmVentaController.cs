using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFarmacia.Vistas.Ventas;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Servicios.Negocio.Ventas;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Servicios.Negocio.Busqueda;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using SistemaFarmacia.Servicios.Negocio.Administracion;

namespace SistemaFarmacia.Controladores.Ventas
{
    public class frmVentaController : BaseController
    {
        frmVenta _vista;
        ServicioVentas _servicioVentas;
        ServicioCatalogoProductos _servicioCatalogoProductos;
        ServicioBusqueda _servicioBusqueda;
        ServicioCatalogoDescuentos _servicioCatalogoDescuentos;
        ServicioCatalogoUsuarios _servicioCatalogoUsuarios;
        ServicioCatalogoImpuestos _servicioCatalogoImpuestos;

        public frmVentaController (frmVenta vista)
        {
            _vista = vista;
            _servicioVentas = new ServicioVentas(BaseDeDatosTienda);
            _servicioCatalogoProductos = new ServicioCatalogoProductos(BaseDeDatosTienda);
            _servicioBusqueda = new ServicioBusqueda(BaseDeDatosTienda);
            _servicioCatalogoDescuentos = new ServicioCatalogoDescuentos(BaseDeDatosTienda);
            _servicioCatalogoUsuarios = new ServicioCatalogoUsuarios(BaseDeDatosTienda);
            _servicioCatalogoImpuestos = new ServicioCatalogoImpuestos(BaseDeDatosTienda);
        }

        public List<CatImpuestos> ObtenerListaImpuestos()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoImpuestos.ConsultarImpuestos();

            if (resultado != null)
            {
                string mensaje = "No fue posible obtener los impuestos disponibles.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return new List<CatImpuestos>();
            }

            return _servicioCatalogoImpuestos.ListaCatImpuestos.FindAll(e => e.EsActivo == true);
        }

        public List<Usuario> ObtenerListaUsuarios()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoUsuarios.ObtenerUsuarios();

            if (resultado != null)
            {
                string mensaje = "No fue posible obtener los usuarios vendedores.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return new List<Usuario>();
            }

            return _servicioCatalogoUsuarios.ListaUsuarios.FindAll(e => e.EsActivo == true);
        }

        public List<DescuentoVenta> ObtenerListaDescuentoVenta()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoDescuentos.ConsultarDescuentosAplicables();

            if (resultado != null)
            {
                string mensaje = "No fue posible obtener los descuentos aplicables a la venta.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return new List<DescuentoVenta>();
            }

            return _servicioCatalogoDescuentos.ListaDescuentoVenta;
        }

        public ComplementoVenta ObtenerComplementoVenta()
        {
            ExcepcionPersonalizada excepcionConsultarComplementoVenta = _servicioCatalogoProductos.ConsultarComplementoVenta();
            if (excepcionConsultarComplementoVenta == null)
            {
                return _servicioCatalogoProductos.ComplementoVenta;
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionConsultarComplementoVenta.Message.ToString(), excepcionConsultarComplementoVenta.InnerException.ToString(), false);
                return null;
            }
        }

        public List<ProductosListado> LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _servicioBusqueda.ObtenerListadoProductos();
            return listaProductos;
        }

        public ContextoVenta BuscarProductoCodigoBarra(string codigoBarra)
        {
            ExcepcionPersonalizada excepcionBuscarProducto = _servicioVentas.BuscarProductoCodigoBarra(codigoBarra);
            if (excepcionBuscarProducto == null)
            {                
                return _servicioVentas.ContextoVenta;
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionBuscarProducto.Message.ToString(), excepcionBuscarProducto.InnerException.ToString(), false);
                return null;
            }
        }

        public void GuardarVenta(Venta venta)
        {
            ExcepcionPersonalizada excepcionGuardarVenta = _servicioVentas.GuardarVenta(venta);
            if (excepcionGuardarVenta == null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, "La venta se guardó correctamente.", string.Empty, true);
                _vista.LimpiarFormulario();
            }
            else
            {
                _vista.MostrarDialogoResultado(_vista.Text, excepcionGuardarVenta.Message.ToString(), excepcionGuardarVenta.InnerException.ToString(), false);
            }
        }

    }
}

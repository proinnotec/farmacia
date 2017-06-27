using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Servicios.Negocio.Almacen;
using SistemaFarmacia.Vistas.Procesos;
using System.Collections.Generic;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System.Data;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using SistemaFarmacia.Servicios.Negocio.Busqueda;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class EntradasEditaController: BaseController
    {
        private ServicioEntradas _servicioEntradas;
        private ServicioCatalogoProductos _servicioCatalogoProductos;
        private frmEditaEntradas _vista;
        private ServicioBusqueda _servicioBusqueda;
        public List<CatProducto> ListaProductos { get; private set; }

        public EntradasEditaController(frmEditaEntradas vista)
        {
            _servicioEntradas = new ServicioEntradas(BaseDeDatosTienda);
            _servicioCatalogoProductos = new ServicioCatalogoProductos(BaseDeDatosTienda);
            _servicioBusqueda = new ServicioBusqueda(BaseDeDatosTienda);

            _vista = vista;
        }

        public void ConsultaEntradasDetalles(int idEntrada)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.ConsultarDetalles(idEntrada);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de los detalles de las entradas.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<EntradaProductoDetalle> listaEntradaDetalles = _servicioEntradas.ListaEntradasDetalles;
            _vista.AsignarListaDetalles(listaEntradaDetalles);

        }

        public bool ConsultaProductosLista(int idProducto, string claveProducto)
        {
            string mensaje = string.Empty;

            claveProducto = claveProducto.TrimEnd().TrimStart();

            ExcepcionPersonalizada resultado = _servicioCatalogoProductos.ConsultarProductosActivos(idProducto, claveProducto);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de los productos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return false;
            }

            ListaProductos = _servicioCatalogoProductos.ListaProductos;
            
            return true;
        }

        public void GuardarDescuentoConfiguracion(EntradaProducto entrada)
        {
            string mensaje = string.Empty;

            ExcepcionPersonalizada resultado = null;
            resultado = _servicioEntradas.GuardarEntrada(entrada);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar la entrada.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información de la entrada.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            _vista.Cerrar();
        }

        public List<ProductosListado> LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _servicioBusqueda.ObtenerListadoProductos();

            return listaProductos;
        }
    }
}

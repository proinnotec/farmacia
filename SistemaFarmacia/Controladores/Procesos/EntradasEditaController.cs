using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Servicios.Negocio.Almacen;
using SistemaFarmacia.Vistas.Procesos;
using System.Collections.Generic;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class EntradasEditaController: BaseController
    {
        private ServicioEntradas _servicioEntradas;
        private ServicioCatalogoProductos _servicioCatalogoProductos;
        private frmEditaEntradas _vista;

        public EntradasEditaController(frmEditaEntradas vista)
        {
            _servicioEntradas = new ServicioEntradas(BaseDeDatosTienda);
            _servicioCatalogoProductos = new ServicioCatalogoProductos(BaseDeDatosTienda);
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

        public void ConsultaProductosLista()
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioCatalogoProductos.ConsultarProductosActivos();

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de los productos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<CatProducto> listaProductos = _servicioCatalogoProductos.ListaProductos;
            _vista.LlenarComboProductos(listaProductos);
        }

        public void BajaEntrada(EntradaProducto entrada)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.BajaEntrada(entrada);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar dar de baja la entrada.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información de la entrada.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);
        }
    }
}

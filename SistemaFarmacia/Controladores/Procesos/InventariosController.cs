using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Reportes;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using SistemaFarmacia.Servicios.Negocio.Almacen;
using SistemaFarmacia.Servicios.Negocio.Busqueda;
using SistemaFarmacia.Vistas.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class InventariosController: BaseController
    {
        private frmReporteInventario _vista;
        private ServicioBusqueda _servicioBusqueda;
        private ServicioInventarios _servicioInventarios;

        public InventariosController(frmReporteInventario vista)
        {
            _vista = vista;
            _servicioBusqueda = new ServicioBusqueda(BaseDeDatosTienda);
            _servicioInventarios = new ServicioInventarios(BaseDeDatosTienda);
        }

        public void ConsultaInventario(int idProducto, bool esValuado)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioInventarios.ConsultaInventario(idProducto, esValuado);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información del kardex.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<Inventario> lista = _servicioInventarios.ListaInventario;
            _vista.LlenaInformacionReporte(lista);
        }

        public List<ProductosListado> LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _servicioBusqueda.ObtenerListadoProductos();

            return listaProductos;
        }
    }
}

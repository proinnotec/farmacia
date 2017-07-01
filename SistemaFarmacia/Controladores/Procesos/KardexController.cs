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
    public class KardexController: BaseController
    {
        private ServicioKardex _servicioKardex;
        private frmReporteKardex _vista;
        private ServicioBusqueda _servicioBusqueda;

        public KardexController(frmReporteKardex vista)
        {
            _vista = vista;
            _servicioKardex = new ServicioKardex(BaseDeDatosTienda);
            _servicioBusqueda = new ServicioBusqueda(BaseDeDatosTienda);
        }

        public void ConsultaKardex(DateTime fechaInicio, DateTime fechaFinal, int idProducto)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioKardex.ConsultaKardex(fechaInicio, fechaFinal, idProducto);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información del kardex.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<KardexEntidad> lista = _servicioKardex.ListaKardex;
            _vista.LlenaInformacionReporte(lista);
        }

        public List<ProductosListado> LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _servicioBusqueda.ObtenerListadoProductos();

            return listaProductos;
        }
    }
}

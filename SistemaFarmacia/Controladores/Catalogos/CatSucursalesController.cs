using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Catalogos
{
    public class CatSucursalesController: BaseController
    {
        private ServicioCatalogoSucursales _servicioCatalogoSucursales;
        private frmCatSucursales _vista;

        public CatSucursalesController(frmCatSucursales vista)
        {
            _vista = vista;
            _servicioCatalogoSucursales = new ServicioCatalogoSucursales(BaseDeDatosTienda);
        }

        public void ConsultarSucursales()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoSucursales.ConsultarSucursales();

            if(resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message, resultado.ToString(), false);
                return;
            }

            List<CatSucursal> lista = _servicioCatalogoSucursales.ListaSucursales;

            _vista.CargarDatos(lista);
        }

        public void ActualizarSucursal(CatSucursal sucursal)
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoSucursales.ActualizarSucursal(sucursal);

            if (resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, resultado.Message, resultado.ToString(), false);
                return;
            }

            _vista.MostrarDialogoResultado(_vista.Text, "Se ha actualizado correctamente el nombre de las sucursal.", string.Empty, true);

            ConsultarSucursales();
        }

    }
}

using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Operaciones;
using SistemaFarmacia.Vistas.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores
{
    public class AccesoController: BaseController
    {
        private ServicioDatosAcceso _servicioDatosAcceso;
        private ServicioCatalogoSucursales _servicioCatalogoSucursales;
        private frmAcceso _vista;

        public AccesoController(frmAcceso vista)
        {
            _vista = vista;
            _servicioDatosAcceso = new ServicioDatosAcceso(BaseDeDatosTienda);
            _servicioCatalogoSucursales = new ServicioCatalogoSucursales(BaseDeDatosTienda);

        }

        public void ConsultarLogin(Usuario usuario)
        {
            ExcepcionPersonalizada resultado = _servicioDatosAcceso.ConsultarLogin(usuario);

            if(resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, "Error al consultar los datos de usuario", resultado.ToString(), false);
                return;
            }

            Usuario loginUsuario = _servicioDatosAcceso.LoginUsuario;

            if(loginUsuario == null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, "No se encontró información con estas credenciales, usuario y/o contraseña incorrectos, favor de verificar", string.Empty, false);
                return;
            }

            _vista.AsignarDatosLogin(loginUsuario);
        }

        public void ConsultarSucursales()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoSucursales.ConsultarSucursales();

            if (resultado != null)
            {
                _vista.MostrarDialogoResultado(_vista.Text, "Error al consultar los datos de las sucursales", resultado.ToString(), false);
                return;
            }

            List<CatSucursal> listaSucursales = _servicioCatalogoSucursales.ListaSucursales;

            _vista.LlenarComboSucursales(listaSucursales);
        }
    }
}

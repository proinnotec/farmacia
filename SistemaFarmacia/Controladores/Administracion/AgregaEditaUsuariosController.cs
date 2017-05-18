using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Servicios.Negocio.Administracion;
using SistemaFarmacia.Vistas.Administracion;
using System.Collections.Generic;

namespace SistemaFarmacia.Controladores.Administracion
{
    public class AgregaEditaUsuariosController: BaseController
    {
        private frmAgregaEditaUsuario _vista;
        ServicioCatalogoUsuarios _servicioCatalogoUsuarios;

        public AgregaEditaUsuariosController(frmAgregaEditaUsuario vista)
        {
            _vista = vista;
            _servicioCatalogoUsuarios = new ServicioCatalogoUsuarios(BaseDeDatosTienda);
        }

        public void GuardarUsuario(Usuario usuario)
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoUsuarios.GuardarUsuario(usuario);

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar registrar el usuario.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
            }

            _vista.Cerrar();

        }
    }
}

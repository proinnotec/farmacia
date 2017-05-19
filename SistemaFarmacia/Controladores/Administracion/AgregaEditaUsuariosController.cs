using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Servicios.Negocio.Administracion;
using SistemaFarmacia.Vistas.Administracion;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Controladores.Administracion
{
    public class AgregaEditaUsuariosController: BaseController
    {
        private frmAgregaEditaUsuario _vista;
        ServicioCatalogoUsuarios _servicioCatalogoUsuarios;
        ServicioCatalogoPerfiles _servicioCatalogoPerfiles;

        public AgregaEditaUsuariosController(frmAgregaEditaUsuario vista)
        {
            _vista = vista;
            _servicioCatalogoUsuarios = new ServicioCatalogoUsuarios(BaseDeDatosTienda);
            _servicioCatalogoPerfiles = new ServicioCatalogoPerfiles(BaseDeDatosTienda);
        }

        public void ConsultarPerfiles()
        {
            Perfiles perfil = new Perfiles();
            ExcepcionPersonalizada resultado = _servicioCatalogoPerfiles.ConsultarPerfiles(perfil);

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar consultar los datos de los perfiles.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
            }

            List<Perfiles> listaPerfiles = _servicioCatalogoPerfiles.ListaPerfiles;

            _vista.LlenarComboAjustes(listaPerfiles);

        }

        public void GuardarUsuario(Usuario usuario, EnumeradoAccion accion)
        {
            ExcepcionPersonalizada resultado = null;

            switch (accion)
            {
                case EnumeradoAccion.Alta:
                    resultado = _servicioCatalogoUsuarios.GuardarUsuario(usuario);
                    break;

                case EnumeradoAccion.Edicion:
                    resultado = _servicioCatalogoUsuarios.ActualizarUsuario(usuario);
                    break;
            }

            string mensaje = string.Empty;

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar los datos del usuario.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
            }

            mensaje = "Se ha guardado correctamente la información del usuario.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            _vista.Cerrar();

        }
    }
}

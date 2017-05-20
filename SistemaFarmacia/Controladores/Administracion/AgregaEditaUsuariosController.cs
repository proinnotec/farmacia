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

        public void GuardarUsuario(Usuario usuario, EnumeradoAccion accion, bool validaNombreUsuario)
        {
            ExcepcionPersonalizada resultado = null;
            string mensaje = string.Empty;

            if(validaNombreUsuario)
            {
                resultado = _servicioCatalogoUsuarios.ValidarNombreUsuario(usuario);

                if (resultado != null)
                {
                    mensaje = "Hubo un error al intentar consultar el nombre del usuario.";
                    _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                    return;
                }

                List<Usuario> listaUsuariosEncontrados = _servicioCatalogoUsuarios.ListaUsuariosEncontrados;

                if (listaUsuariosEncontrados.Count > 0)
                {
                    string mensajeUsuarioEncontrado = string.Format("{0} {1} {2}", "No se puede asignar el nombre de usuario", usuario.NombreUsuario, "porque ya se encuentra asignado a:");

                    foreach (Usuario usuarioEncontrado in listaUsuariosEncontrados)
                    {
                        mensajeUsuarioEncontrado = string.Format("{0} {1} {2} {3}", mensajeUsuarioEncontrado, usuarioEncontrado.Nombre, usuarioEncontrado.ApellidoPaterno, usuarioEncontrado.ApellidoMaterno);
                    }

                    _vista.MostrarDialogoResultado(_vista.Text, mensajeUsuarioEncontrado, "", false);
                    return;
                }
            }
            
            switch (accion)
            {
                case EnumeradoAccion.Alta:
                    resultado = _servicioCatalogoUsuarios.GuardarUsuario(usuario);
                    break;

                case EnumeradoAccion.Edicion:
                    resultado = _servicioCatalogoUsuarios.ActualizarUsuario(usuario);
                    break;
            }
            
            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar guardar los datos del usuario.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del usuario.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            _vista.Cerrar();

        }
    }
}

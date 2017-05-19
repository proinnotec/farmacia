using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Servicios.Negocio.Administracion;
using SistemaFarmacia.Vistas.Administracion;
using System.Collections.Generic;

namespace SistemaFarmacia.Controladores.Administracion
{
    public class CatUsuariosController : BaseController
    {
        private frmCatUsuarios _vista;
        ServicioCatalogoUsuarios _servicioCatalogoUsuarios;

        public CatUsuariosController(frmCatUsuarios vista)
        {
            _vista = vista;
            _servicioCatalogoUsuarios = new ServicioCatalogoUsuarios(BaseDeDatosTienda);

        }

        public void ObtenerUsuarios()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoUsuarios.ObtenerUsuarios();

            if(resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la información de los usuarios, no se pueden cargar los datos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);

            }

            List<Usuario> lista = _servicioCatalogoUsuarios.ListaUsuarios;

            _vista.AsigarListaUsuarios(lista);
        }

        public void ActivarDesactivarUsuario(Usuario usuario)
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoUsuarios.ActivarDesactivarUsuario(usuario);

            string mensaje = string.Empty;

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar realizar la operación con el usuario.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
            }

            mensaje = "Se ha guardado correctamente la información del usuario.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            ObtenerUsuarios();
        }
    }
}

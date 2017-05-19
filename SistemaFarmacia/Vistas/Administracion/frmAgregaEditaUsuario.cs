using SistemaFarmacia.Controladores.Administracion;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Administracion
{
    public partial class frmAgregaEditaUsuario : frmBase
    {
        EnumeradoAccion _accion;
        frmCatUsuarios _vistaLlamada;
        Usuario _usuarioGuardar;
        AgregaEditaUsuariosController _agregaEditaUsuariosController;

        public frmAgregaEditaUsuario(EnumeradoAccion accion, frmCatUsuarios vistaLlamada, Usuario usuario = null)
        {
            InitializeComponent();
            _usuarioGuardar = new Usuario();
            _agregaEditaUsuariosController = new AgregaEditaUsuariosController(this);

            _vistaLlamada = vistaLlamada;
            _usuarioGuardar = usuario;
            _accion = accion;

            this.Text = "Alta de Usuario";

            if (_accion == EnumeradoAccion.Edicion)
                this.Text = "Modificación de Usuario";

        }

        private void frmAgregaEditaUsuario_Load(object sender, EventArgs e)
        {
            if(_accion == EnumeradoAccion.Edicion)
                AsignarDatosAControles();

            _agregaEditaUsuariosController.ConsultarPerfiles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();

        }

        public void LlenarComboAjustes(List<Perfiles> lista)
        {
            cmbPerfiles.Items.Clear();
            cmbPerfiles.DataSource = lista;
            cmbPerfiles.DisplayMember = "Nombre";
            cmbPerfiles.ValueMember = "IdPerfil";

            if (_usuarioGuardar != null)
                cmbPerfiles.SelectedValue = _usuarioGuardar.IdPerfil;
            else
                cmbPerfiles.SelectedValue = 0;

        }

        public void Cerrar()
        {
            _vistaLlamada.ObtenerUsuarios();

            this.Close();
            this.Dispose();

        }

        private void AsignarDatosAControles()
        {
            txtNombre.Text = _usuarioGuardar.Nombre;
            txtAPaterno.Text = _usuarioGuardar.ApellidoPaterno;
            txtAMaterno.Text = _usuarioGuardar.ApellidoMaterno;
            txtUsuario.Text = _usuarioGuardar.NombreUsuario;
            txtPass.Text = _usuarioGuardar.UserPassword;

        }

        private void GuardarUsuario()
        {
            string nombre = txtNombre.Text.TrimEnd().TrimStart();
            string aPaterno = txtAPaterno.Text.TrimEnd().TrimStart();
            string aMaterno = txtAMaterno.Text.TrimEnd().TrimStart();
            string usuarioLogin = txtUsuario.Text.TrimEnd().TrimStart();
            string password = txtPass.Text.TrimEnd().TrimStart();
            int perfil = (int)cmbPerfiles.SelectedValue;
            string mensaje = string.Empty;

            if (string.IsNullOrEmpty(nombre))
                mensaje = "Capture el nombre, ";

            if (string.IsNullOrEmpty(aPaterno))
                mensaje = mensaje + " Capture el apellido paterno, ";

            if (string.IsNullOrEmpty(aMaterno))
                mensaje = mensaje + " Capture el apellido materno, ";

            if (string.IsNullOrEmpty(usuarioLogin))
                mensaje = mensaje + " Capture el usuario, ";

            if (string.IsNullOrEmpty(password))
                mensaje = mensaje + " Capture el password";

            if(perfil <= 0)
                mensaje = mensaje + " Seleccione un perfil para el usuario";

            if (mensaje.Length > 0)
            {
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }
                
            _usuarioGuardar.Nombre = nombre;
            _usuarioGuardar.ApellidoPaterno = aPaterno;
            _usuarioGuardar.ApellidoMaterno = aMaterno;
            _usuarioGuardar.NombreUsuario = usuarioLogin;
            _usuarioGuardar.UserPassword = password;
            _usuarioGuardar.IdPerfil = perfil;

            if (!ConfirmarGuardado())
                return;

            _agregaEditaUsuariosController.GuardarUsuario(_usuarioGuardar, _accion);

        }
        
        bool ConfirmarGuardado()
        {
            string mensaje = string.Empty;

            switch(_accion)
            {
                case EnumeradoAccion.Alta:
                    mensaje = "¿Seguro que desea guardar la información del usuario?";
                    break;

                case EnumeradoAccion.Edicion:
                    mensaje = "¿Seguro que desea actualizar la información del usuario?";
                    break;
            }    

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;
            
            else
                return false;

        }
    }
}

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

        public frmAgregaEditaUsuario(EnumeradoAccion accion, frmCatUsuarios vistaLlamada, Usuario usuario)
        {
            InitializeComponent();
            _usuarioGuardar = new Usuario();
            _agregaEditaUsuariosController = new AgregaEditaUsuariosController(this);

            _vistaLlamada = vistaLlamada;
            _usuarioGuardar = usuario;
            _accion = accion;

            txtNombre.Select();

            this.Text = "Alta de Usuario";

            if (_accion == EnumeradoAccion.Edicion)
                this.Text = "Modificación de Usuario";

        }

        private void frmAgregaEditaUsuario_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipGuardar = new ToolTip();
            ToolTipGuardar.SetToolTip(btnGuardar, "Guardar F5");

            if (_accion == EnumeradoAccion.Edicion)
                AsignarDatosAControles();

            _agregaEditaUsuariosController.ConsultarPerfiles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }

        public void LlenarComboPerfiles(List<Perfiles> lista)
        {
            cmbPerfiles.Items.Clear();
            cmbPerfiles.DataSource = lista;
            cmbPerfiles.DisplayMember = "Nombre";
            cmbPerfiles.ValueMember = "IdPerfil";
            cmbPerfiles.SelectedValue = _usuarioGuardar.IdPerfil;
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
            txtPassComprobar.Text = _usuarioGuardar.UserPassword;

            txtUsuario.Enabled = false;
        }

        private void GuardarUsuario()
        {
            string nombre = txtNombre.Text.TrimEnd().TrimStart();
            string aPaterno = txtAPaterno.Text.TrimEnd().TrimStart();
            string aMaterno = txtAMaterno.Text.TrimEnd().TrimStart();
            string usuarioLogin = txtUsuario.Text.TrimEnd().TrimStart();
            string password = txtPass.Text.TrimEnd().TrimStart();
            string passwordConfirmacion = txtPassComprobar.Text.TrimEnd().TrimStart();
            string mensaje = string.Empty;
            int perfil = (int)cmbPerfiles.SelectedValue;

            if (string.IsNullOrEmpty(nombre))
                mensaje = " Capture el nombre \n";

            if (string.IsNullOrEmpty(aPaterno))
                mensaje = mensaje + " Capture el apellido paterno \n";

            if (string.IsNullOrEmpty(aMaterno))
                mensaje = mensaje + " Capture el apellido materno \n";

            if (string.IsNullOrEmpty(usuarioLogin))
                mensaje = mensaje + " Capture el usuario \n";

            if (string.IsNullOrEmpty(password))
                mensaje = mensaje + " Capture el password \n";

            if (string.IsNullOrEmpty(passwordConfirmacion))
                mensaje = mensaje + " Capture la comprobación del password \n";

            if (perfil <= 0)
                mensaje = mensaje + " Seleccione un perfil para el usuario \n";

            if (password != passwordConfirmacion)
                mensaje = mensaje + " No coinciden las contraseñas, favor de verificar. ";

            if (mensaje.Length > 0)
            {
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }

            bool validaUsuarioLogin = false;

            _usuarioGuardar.Nombre = nombre;
            _usuarioGuardar.ApellidoPaterno = aPaterno;
            _usuarioGuardar.ApellidoMaterno = aMaterno;

            if (_usuarioGuardar.NombreUsuario != usuarioLogin)
                validaUsuarioLogin = true;

            _usuarioGuardar.NombreUsuario = usuarioLogin;
            _usuarioGuardar.UserPassword = password;
            _usuarioGuardar.IdPerfil = perfil;

            if (!ConfirmarGuardado())
                return;

            _agregaEditaUsuariosController.GuardarUsuario(_usuarioGuardar, _accion, validaUsuarioLogin);

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F5:
                    GuardarUsuario();
                    break;
            }

            return false;
        }
    }
}

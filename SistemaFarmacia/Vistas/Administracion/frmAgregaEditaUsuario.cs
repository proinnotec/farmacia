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
        frmCatUsuarios _vistaLlamada;
        Usuario _usuarioGuardar;
        AgregaEditaUsuariosController _agregaEditaUsuariosController;
        public frmAgregaEditaUsuario(Usuario usuario, EnumeradoAccion accion, frmCatUsuarios vistaLlamada)
        {
            InitializeComponent();
            _vistaLlamada = vistaLlamada;
            _usuarioGuardar = new Usuario();
            _agregaEditaUsuariosController = new AgregaEditaUsuariosController(this);
        }

        private void frmAgregaEditaUsuario_Load(object sender, EventArgs e)
        {

        }

        public void Cerrar()
        {
            _vistaLlamada.ObtenerUsuarios();
            this.Close();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _usuarioGuardar.Nombre = txtNombre.Text;
            _usuarioGuardar.ApellidoPaterno = txtAPaterno.Text;
            _usuarioGuardar.ApellidoMaterno = txtAMaterno.Text;
            _usuarioGuardar.NombreUsuario = txtUsuario.Text;
            _usuarioGuardar.UserPassword = txtPass.Text;

            _agregaEditaUsuariosController.GuardarUsuario(_usuarioGuardar);
        }
    }
}

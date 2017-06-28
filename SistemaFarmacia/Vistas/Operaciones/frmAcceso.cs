using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacia.Vistas.Base;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Controladores;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Vistas.Operaciones
{
    public partial class frmAcceso: frmBase
    {
        Usuario _usuario;
        AccesoController _accesoControler;
        public frmAcceso()
        {
            InitializeComponent();

            _usuario = new Usuario();
            _accesoControler = new AccesoController(this);
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            txtUsuario.Select();

            _accesoControler.ConsultarSucursales();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void ValidarDatos()
        {                                 
            _usuario.NombreUsuario = txtUsuario.Text;
            _usuario.UserPassword = txtPass.Text;
            _usuario.IdSucursal = (int)cmbSucursal.SelectedValue;
            _usuario.Sucursal = cmbSucursal.Text;

            _accesoControler.ConsultarLogin(_usuario);
        }

        public void LlenarComboSucursales(List<CatSucursal> lista)
        {
            cmbSucursal.Items.Clear();
            cmbSucursal.DataSource = lista;
            cmbSucursal.DisplayMember = "SucursalObjeto";
            cmbSucursal.ValueMember = "IdSucursalObjeto";
        }

        public void AsignarDatosLogin(Usuario usuario)
        {
            frmPrincipal principal = new frmPrincipal(usuario, this);
            principal.Show();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.Azure;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.White;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.Azure;
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass.BackColor = Color.White;
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ValidarDatos();
            }
        }
    }
}

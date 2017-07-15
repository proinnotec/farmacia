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

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmVendedores : frmBase
    {
        public frmVendedores(List<Usuario> _listaUsuarios)
        {
            InitializeComponent();
            cmbVendedores.Items.Clear();
            cmbVendedores.DataSource = _listaUsuarios;
            cmbVendedores.ValueMember = "IdUsuario";
            cmbVendedores.DisplayMember = "Nombre";
            cmbVendedores.SelectedIndex = 0;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (cmbVendedores.SelectedIndex == -1)
            {
                MostrarDialogoResultado(this.Text, "Seleccione un vendedor.", string.Empty, false);
                return;
            }

            this.DialogResult = DialogResult.Yes;
        }
    }
}

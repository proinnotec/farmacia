using SistemaFarmacia.Controladores.Ventas;
using SistemaFarmacia.Entidades.Contextos;
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

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmRepCortesCaja : frmBase
    {
        private ContextoAplicacion _contextoAplicacion;
        private CortesCajaRepController _cortesCajaRepController;

        public frmRepCortesCaja(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _cortesCajaRepController = new CortesCajaRepController(this);
        }

        private void frmRepCortesCaja_Load(object sender, EventArgs e)
        {
            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnImprimir, "Imprimir");

            HabilitarDesabilitarControles(chbTodos.Checked);
            _cortesCajaRepController.ObtenerListaVendedores(dtpFecha.Value);
        }

        private void HabilitarDesabilitarControles(bool habilita)
        {
            cmbVendedores.Enabled = !habilita;
            cmbVendedores.SelectedValue = -1;
        }

        public void LlenarComboVendedores(List<Usuario> lista)
        {
            cmbVendedores.DataSource = null;
            cmbVendedores.DataSource = lista;
            cmbVendedores.DisplayMember = "NombreUsuario";
            cmbVendedores.ValueMember = "IdUsuario";
            cmbVendedores.SelectedValue = -1;
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarDesabilitarControles(chbTodos.Checked);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            _cortesCajaRepController.ObtenerListaVendedores(dtpFecha.Value);
        }
    }
}

using SistemaFarmacia.Entidades.Contextos;
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

namespace SistemaFarmacia.Vistas.Procesos
{
    public partial class frmEntradas : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        public frmEntradas(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditaEntradas vistaEditaEntradas = new frmEditaEntradas(_contextoAplicacion);
            vistaEditaEntradas.ShowDialog();
        }
    }
}

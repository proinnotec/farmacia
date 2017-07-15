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

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmCantidadVenta : frmBase
    {
        public frmCantidadVenta()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nupCantidad.Value.Equals(0))
            {
                MostrarDialogoResultado(this.Text, "Capture la cantidad del producto.", string.Empty, false);
                return;
            }

            this.DialogResult = DialogResult.Yes;
        }
    }
}

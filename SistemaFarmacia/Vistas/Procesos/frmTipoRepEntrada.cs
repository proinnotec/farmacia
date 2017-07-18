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
    public partial class frmTipoRepEntrada : frmBase
    {
        public TipoReporteEntrada TipoReporte { get; set; }

        public frmTipoRepEntrada(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rdbBasico.Checked)
            {
                TipoReporte = TipoReporteEntrada.Basico;
            }

            if(rdbDetallado.Checked)
            {
                TipoReporte = TipoReporteEntrada.Detallado;
            }

            Close();
        }

        private void frmTipoRepEntrada_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(TipoReporte == TipoReporteEntrada.Ninguno)
                DialogResult = DialogResult.Cancel;

            else
                DialogResult = DialogResult.Yes;

            Dispose();
        }

        private void frmTipoRepEntrada_Load(object sender, EventArgs e)
        {
            btnAgregar.Select();
        }
    }
}

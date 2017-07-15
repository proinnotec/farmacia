using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Reportes;
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
    public partial class frmRepTicketReImp : frmBase
    {
        public frmRepTicketReImp(ContextoAplicacion contexto)
        {
            InitializeComponent();
        }

        private void frmRepTicketReImp_Load(object sender, EventArgs e)
        {
            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnImprimir, "Imprimir");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rptTicket ticket = new rptTicket();

            crvTicket.ReportSource = ticket;
            crvTicket.RefreshReport();
        }
    }
}

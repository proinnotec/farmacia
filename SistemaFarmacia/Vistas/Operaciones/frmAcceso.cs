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

namespace SistemaFarmacia.Vistas.Operaciones
{
    public partial class frmAcceso : frmBase
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            MostrarDialogoConfirmacion("Test", "Confirmación");
            MostrarDialogoResultado("Test", "Mensaje", "Exception", false);
        }
    }
}

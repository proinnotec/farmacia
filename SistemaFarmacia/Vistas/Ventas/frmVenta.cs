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
using SistemaFarmacia.Entidades.Contextos;

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmVenta : frmBase
    {
        public frmVenta(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
        }
    }
}

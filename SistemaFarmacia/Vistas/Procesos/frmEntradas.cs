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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoAbrir = new OpenFileDialog();
            dialogoAbrir.Filter = "Archivos de Excel|*.xls;*.xlsx";
            dialogoAbrir.Title = "Registros de Entradas";

            dialogoAbrir.ShowDialog();
        }
    }
}

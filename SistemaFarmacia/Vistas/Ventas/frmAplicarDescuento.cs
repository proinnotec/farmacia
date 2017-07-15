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
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmAplicarDescuento : frmBase
    {
        public frmAplicarDescuento(List<DescuentoVenta> listaDescuentoVenta, CatDescuentos catDescuentos)
        {
            InitializeComponent();

            List<CatDescuentos> listaDescuentos = new List<CatDescuentos>();
            listaDescuentos.Add(new CatDescuentos { IdDescuento = 0, Descripcion = "No Aplica" });

            foreach (DescuentoVenta descuentoVenta in listaDescuentoVenta)
            {                
                listaDescuentos.Add(descuentoVenta.Descuento);
            }

            cmbDescuentos.Items.Clear();
            cmbDescuentos.DataSource = listaDescuentos;
            cmbDescuentos.ValueMember = "IdDescuento";
            cmbDescuentos.DisplayMember = "Descripcion";

            if (catDescuentos.IdDescuento.Equals(0))
            {
                cmbDescuentos.SelectedIndex = 0;
            }
            else
            {
                cmbDescuentos.SelectedValue = catDescuentos.IdDescuento;
            }

        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;           
        }
    }
}

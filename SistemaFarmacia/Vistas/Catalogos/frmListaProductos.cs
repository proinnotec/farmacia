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
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Vistas.Operaciones;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmListaProductos : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private frmListaProductosContoller _frmCatProductosContoller { get; set; }

        public frmListaProductos(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;            
            _frmCatProductosContoller = new frmListaProductosContoller(this);
            AsigarListaFamilias(_frmCatProductosContoller.ListaFamilias());
        }

        private void AsigarListaProductos(List<CatProducto> listaProductos)
        {
            gridProductos.AutoGenerateColumns = false;
            gridProductos.DataSource = null;
            gridProductos.DataSource = listaProductos;
        }

        public void AsigarListaFamilias(List<CatFamilias> listaFamilias)
        {
            cmbFamilias.Items.Clear();
            cmbFamilias.DataSource = listaFamilias;
            cmbFamilias.ValueMember = "IdFamiliaProducto";
            cmbFamilias.DisplayMember = "Descripcion";
            cmbFamilias.SelectedIndex = -1;
        }

        private void cmbFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFamilias.SelectedValue is int)
            {
                AsigarListaProductos(_frmCatProductosContoller.ListaProductos((int)cmbFamilias.SelectedValue));
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CatProducto producto = new CatProducto();
            producto.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            frmCatProducto frmCatProducto = new frmCatProducto(producto, (List<CatFamilias>)cmbFamilias.DataSource);
            frmCatProducto.MdiParent = (Form)Application.OpenForms.Cast<Form>().ToList().Find(elemento => elemento.Name == "frmPrincipal");
            frmCatProducto.Show();
        }

        private void gridProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.SelectedRows.Count == 0)
            {
                return;
            }

            CatProducto producto = new CatProducto();
            producto.ClaveProducto = (int) gridProductos.SelectedRows[0].Cells["ClaveProducto"].Value;
            producto.Descripcion = gridProductos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            producto.Precio = (decimal)gridProductos.SelectedRows[0].Cells["Precio"].Value;
            producto.AplicaDescuentoCatalogo = (bool)gridProductos.SelectedRows[0].Cells["AplicaDescuentoCatalogo"].Value;
            producto.IdFamiliaProducto = (int)gridProductos.SelectedRows[0].Cells["IdFamiliaProducto"].Value;
            producto.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;            

            frmCatProducto frmCatProducto = new frmCatProducto(producto, (List<CatFamilias>)cmbFamilias.DataSource);
            frmCatProducto.MdiParent = (Form)Application.OpenForms.Cast<Form>().ToList().Find(elemento => elemento.Name == "frmPrincipal");
            frmCatProducto.Show();
        }
    }
}

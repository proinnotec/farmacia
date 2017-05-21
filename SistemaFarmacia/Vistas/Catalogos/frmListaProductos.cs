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
        public ContextoAplicacion _contextoAplicacion;
        private frmListaProductosContoller _frmCatProductosContoller;
        public CatProducto Producto { get; set; }

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
            frmCatProducto.ShowDialog();

            if (frmCatProducto.nudClaveProducto.Value > 0)
            {
                producto = frmCatProducto.ContextoProducto();
                cmbFamilias.SelectedValue = producto.IdFamiliaProducto;
                AsigarListaProductos(_frmCatProductosContoller.ListaProductos(producto.IdFamiliaProducto));
            }
        }

        private void gridProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.SelectedRows.Count == 0)
            {
                return;
            }

            List<CatProducto> listaProductos = (List<CatProducto>)gridProductos.DataSource;
            CatProducto producto = listaProductos.Find(elemento => elemento.ClaveProducto == (int) gridProductos.SelectedRows[0].Cells["ClaveProducto"].Value);
            producto.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;            

            frmCatProducto frmCatProducto = new frmCatProducto(producto, (List<CatFamilias>)cmbFamilias.DataSource);
            frmCatProducto.ShowDialog();

            if (frmCatProducto.nudClaveProducto.Value > 0)
            {                                
                producto = frmCatProducto.ContextoProducto();
                cmbFamilias.SelectedValue = producto.IdFamiliaProducto;
                AsigarListaProductos(_frmCatProductosContoller.ListaProductos(producto.IdFamiliaProducto));
            }
        }
    }
}

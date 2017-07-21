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

        List<CatProducto> _listaProductos;

        public frmListaProductos(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _frmCatProductosContoller = new frmListaProductosContoller(this);
            AsigarListaFamilias(_frmCatProductosContoller.ListaFamilias());

            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo F2");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información F3");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnSalir, "Cerrar el catálogo F4");

            ToolTip ToolTipActDes = new ToolTip();
            ToolTipActDes.SetToolTip(btnActDes, "Baja F7");

            ColumnasGrid();
        }

        private void ColumnasGrid()
        {
            gridProductos.Columns["ClaveProducto"].FillWeight = 10;
            gridProductos.Columns["Descripcion"].FillWeight = 60;
            gridProductos.Columns["Precio"].FillWeight = 10;
            gridProductos.Columns["AplicaDescuentoCatalogo"].FillWeight = 10;
            gridProductos.Columns["EsActivo"].FillWeight = 10;

        }

        private void AsigarListaProductos(List<CatProducto> listaProductos)
        {
            _listaProductos = listaProductos;
            gridProductos.AutoGenerateColumns = false;
            gridProductos.DataSource = null;
            gridProductos.DataSource = _listaProductos;
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

        private void Nuevo()
        {
            CatProducto producto = new CatProducto();
            producto.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            frmCatProducto frmCatProducto = new frmCatProducto(producto, (List<CatFamilias>)cmbFamilias.DataSource);
            DialogResult resultado = frmCatProducto.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                producto = frmCatProducto.ContextoProducto();
                cmbFamilias.SelectedValue = producto.IdFamiliaProducto;
                AsigarListaProductos(_frmCatProductosContoller.ListaProductos(producto.IdFamiliaProducto));
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        bool ConfirmarActivarReactivar(bool accion)
        {
            string mensaje = string.Empty;

            if (accion)
            {
                mensaje = "¿Seguro que desea dar de baja el producto?";
            }
            else
            {
                mensaje = "¿Seguro que desea reactivar el producto?";
            }           

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void gridProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProductos.SelectedRows.Count == 0)
            {
                return;
            }

            List<CatProducto> listaProductos = (List<CatProducto>)gridProductos.DataSource;
            CatProducto producto = listaProductos.Find(elemento => elemento.IdProducto == (int)gridProductos.SelectedRows[0].Cells["IdProducto"].Value);
            producto.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

            if (!producto.EsActivo)
            {
                MostrarDialogoResultado(this.Text, "Para editar el producto, es necesario reactivarlo.", string.Empty, false);
                return;
            }

            frmCatProducto frmCatProducto = new frmCatProducto(producto, (List<CatFamilias>)cmbFamilias.DataSource);
            DialogResult resultado = frmCatProducto.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                producto = frmCatProducto.ContextoProducto();
                cmbFamilias.SelectedValue = producto.IdFamiliaProducto;
                AsigarListaProductos(_frmCatProductosContoller.ListaProductos(producto.IdFamiliaProducto));
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void RecargarDatos()
        {
            if (cmbFamilias.SelectedValue is int)
            {
                AsigarListaProductos(_frmCatProductosContoller.ListaProductos((int)cmbFamilias.SelectedValue));
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            RecargarDatos();
        }

        private void ActivaDesactivaRegistro()
        {
            if (gridProductos.SelectedRows.Count == 0)
            {
                return;
            }

            List<CatProducto> listaProductos = (List<CatProducto>)gridProductos.DataSource;
            CatProducto producto = listaProductos.Find(elemento => elemento.IdProducto == (int)gridProductos.SelectedRows[0].Cells["IdProducto"].Value);

            if (ConfirmarActivarReactivar(producto.EsActivo))
            {
                producto.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
                producto.EsActivo = !producto.EsActivo;
                _frmCatProductosContoller.EditarEstadoProducto(producto);
                gridProductos.Refresh();

                if (producto.EsActivo)
                {
                    ToolTip ToolTipActDes = new ToolTip();
                    ToolTipActDes.SetToolTip(btnActDes, "Baja F7");
                    btnActDes.BackgroundImage = Resource.bloquear;
                }
                else
                {
                    ToolTip ToolTipActDes = new ToolTip();
                    ToolTipActDes.SetToolTip(btnActDes, "Activar F7");
                    btnActDes.BackgroundImage = Resource.activar;
                }

            }

        }

        private void btnActDes_Click(object sender, EventArgs e)
        {
            ActivaDesactivaRegistro();
        }

        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<CatProducto> listaProductos = (List<CatProducto>)gridProductos.DataSource;
            CatProducto producto = listaProductos.Find(elemento => elemento.IdProducto == (int)gridProductos.SelectedRows[0].Cells["IdProducto"].Value);

            if (producto.EsActivo)
            {
                ToolTip ToolTipActDes = new ToolTip();
                ToolTipActDes.SetToolTip(btnActDes, "Baja F7");
                btnActDes.BackgroundImage = Resource.bloquear;
            }
            else
            {
                ToolTip ToolTipActDes = new ToolTip();
                ToolTipActDes.SetToolTip(btnActDes, "Activar F7");
                btnActDes.BackgroundImage = Resource.activar;
            }
        }

        private void txtProductoFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                gridProductos.AutoGenerateColumns = false;
                gridProductos.DataSource = null;

                if (string.IsNullOrEmpty(txtProductoFiltro.Text.TrimStart().TrimEnd()))
                {
                    gridProductos.DataSource = _listaProductos;
                    return;
                }

                List<CatProducto> listaProductosFiltro = _listaProductos.FindAll(elemento => elemento.Descripcion.ToUpper().Contains(txtProductoFiltro.Text.TrimStart().TrimEnd().ToUpper()));                
                gridProductos.DataSource = listaProductosFiltro;
            }
        }

        private void Cerrar()
        {
            Close();
            Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    Nuevo();
                    break;

                case Keys.F3:
                    RecargarDatos();
                    break;

                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F7:
                    ActivaDesactivaRegistro();
                    break;
            }

            return false;
        }
    }
}

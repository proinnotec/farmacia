using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Base;
using SistemaFarmacia.Entidades.Enumerados;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmCatProducto : frmBase
    {
        EnumeradoAccion _enumeradoAccion;
        private frmCatProductoController _frmCatProductoController;
        int _idUsuario;     

        public frmCatProducto(CatProducto Producto, List<CatFamilias> ListaFamilias)
        {
            _enumeradoAccion = Producto.ClaveProducto == 0 ? EnumeradoAccion.Alta : EnumeradoAccion.Edicion;
            InitializeComponent();
            Inicializa();
            _frmCatProductoController = new frmCatProductoController(this);
            AsigarListaFamilias(ListaFamilias);
            _idUsuario = Producto.IdUsuario;

            if (_enumeradoAccion != EnumeradoAccion.Alta)
            {
                AsignarValores(Producto);
            }
        }

        private void AsigarListaFamilias(List<CatFamilias> listaFamilias)
        {
            cmbFamilias.Items.Clear();
            cmbFamilias.DataSource = listaFamilias;
            cmbFamilias.ValueMember = "IdFamiliaProducto";
            cmbFamilias.DisplayMember = "Descripcion";
            cmbFamilias.SelectedIndex = -1;
        }

        private void AsignarValores(CatProducto producto)
        {
            txtDescripcion.Text = producto.Descripcion;
            nudClaveProducto.Value = producto.ClaveProducto;
            nudClaveProducto.Enabled = false;
            nudPrecio.Value = producto.Precio;
            chkAplicaDescuento.Checked = producto.AplicaDescuentoCatalogo;
            cmbFamilias.SelectedValue = producto.IdFamiliaProducto;

            foreach (CodigoBarraProducto codigoBarra in producto.ListaCodigoBarra)
            {
                gridCodigoBarra.Rows.Add(codigoBarra.CodigoBarras);
            }
        }

        bool ValidarFormulario()
        {
            if (cmbFamilias.SelectedIndex == -1)
            {
                MostrarDialogoResultado(this.Text, "Seleccione la familia del producto.", string.Empty, false);
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MostrarDialogoResultado(this.Text, "Capture la descripción del producto.", string.Empty, false);
                return false;
            }

            if (nudClaveProducto.Value == 0)
            {
                MostrarDialogoResultado(this.Text, "Capture la clave del producto.", string.Empty, false);
                return false;
            }

            if (nudPrecio.Value == 0)
            {
                MostrarDialogoResultado(this.Text, "Capture el precio del producto.", string.Empty, false);
                return false;
            }

            if (gridCodigoBarra.Rows.Count == 0)
            {
                MostrarDialogoResultado(this.Text, "Capture al menos un código de barra.", string.Empty, false);
                return false;
            }

            return true;
        }

        private void Inicializa()
        {
            if (_enumeradoAccion == EnumeradoAccion.Alta)
            {
                this.Text = "Alta de producto";
            }
            else
            {
                this.Text = "Editar producto";
                btnEliminar.Visible = true;
                nudClaveProducto.Enabled = false;
            }
        }

        bool ConfirmarBorrado()
        {
            string mensaje = "¿Seguro que desea eliminar el producto?";

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

        public void LimpiarFormulario()
        {
            txtDescripcion.Text = string.Empty;
            nudClaveProducto.Value = 0;
            nudClaveProducto.Enabled = true;
            nudPrecio.Value = 0;
            chkAplicaDescuento.Checked = false;
            cmbFamilias.SelectedIndex = -1;
            gridCodigoBarra.Rows.Clear();
        }

        CatProducto ContextoProducto()
        {
            CatProducto producto = new CatProducto();
            producto.ClaveProducto = (int)nudClaveProducto.Value;
            producto.AplicaDescuentoCatalogo = chkAplicaDescuento.Checked;
            producto.Descripcion = txtDescripcion.Text;
            producto.IdFamiliaProducto = (int)cmbFamilias.SelectedValue;
            producto.Precio = nudPrecio.Value;
            producto.ListaCodigoBarra = new List<CodigoBarraProducto>();

            foreach (DataGridViewRow fila in gridCodigoBarra.Rows)
            {
                producto.ListaCodigoBarra.Add(new CodigoBarraProducto { CodigoBarras = fila.Cells["CodigoBarras"].Value.ToString() });
            }

            producto.IdUsuario = _idUsuario; 
            return producto;
        }

        bool ConfirmarGuardado()
        {
            string mensaje = string.Empty;

            if (_enumeradoAccion == EnumeradoAccion.Alta)
            {
                mensaje = "¿Son correctos los datos del producto?";
            }
            else
            {
                mensaje = "¿Seguro que desea editar el producto?";
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoBarra.Text))
            {
                MostrarDialogoResultado(this.Text, "Capture el código de barra.", string.Empty, false);
                return;
            }

            if (gridCodigoBarra.Rows.Count > 0)
            {                
                int filas = gridCodigoBarra.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["CodigoBarras"].Value.ToString().Equals(txtCodigoBarra.Text.Trim())).Count();                
                if (filas > 0)
                {
                    MostrarDialogoResultado(this.Text, "El código de barra ya existe, no se agregó.", string.Empty, false);
                    txtCodigoBarra.Focus();
                    return;
                }
            }

            gridCodigoBarra.Rows.Add(txtCodigoBarra.Text.Trim());
            txtCodigoBarra.Text = string.Empty;
            txtCodigoBarra.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            if (!ConfirmarGuardado())
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            CatProducto producto = ContextoProducto();

            if (_enumeradoAccion == EnumeradoAccion.Alta)
            {
                _frmCatProductoController.GuardarProducto(producto);
            }

            if (_enumeradoAccion == EnumeradoAccion.Edicion)
            {
                _frmCatProductoController.EditarProducto(producto);
            }

            Cursor.Current = Cursors.Default;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ConfirmarBorrado())
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            CatProducto producto = ContextoProducto();

            //_frmCatFamiliasController.EliminarFamilia(familia);

            Cursor.Current = Cursors.Default;
        }

        private void tbnQuitar_Click(object sender, EventArgs e)
        {
            if (gridCodigoBarra.SelectedRows.Count == 0)
            {
                MostrarDialogoResultado(this.Text, "Seleccione un código de barra.", string.Empty, false);
                return;
            }

            string codigoBarra = gridCodigoBarra.SelectedRows[0].Cells["CodigoBarras"].Value.ToString();
            DataGridViewRow row = gridCodigoBarra.Rows.Cast<DataGridViewRow>().Where(r => r.Cells["CodigoBarras"].Value.ToString().Equals(codigoBarra)).First();
            gridCodigoBarra.Rows.Remove(row);
        }
    }
}

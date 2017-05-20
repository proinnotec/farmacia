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
            if (_enumeradoAccion != EnumeradoAccion.Alta)
            {
                AsignarValores(Producto);
            }         
            _idUsuario = Producto.IdUsuario;
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
            gridCodigoBarra.AutoGenerateColumns = false;
            gridCodigoBarra.DataSource = null;
        }

        CatProducto ContextoProducto()
        {
            CatProducto producto = new CatProducto();
            producto.ClaveProducto = (int)nudClaveProducto.Value;
            producto.AplicaDescuentoCatalogo = chkAplicaDescuento.Checked;
            producto.Descripcion = txtDescripcion.Text;
            producto.IdFamiliaProducto = (int)cmbFamilias.SelectedValue;
            producto.Precio = nudPrecio.Value;
            producto.ListaCodigoBarra = (List<CodigoBarraProducto>)gridCodigoBarra.DataSource;
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

            if (gridCodigoBarra.DataSource == null)
            {
                gridCodigoBarra.AutoGenerateColumns = false;
                gridCodigoBarra.DataSource = null;
                gridCodigoBarra.DataSource = new List<CodigoBarraProducto>();
            }

            List<CodigoBarraProducto> listaCodigoBarra = (List<CodigoBarraProducto>)gridCodigoBarra.DataSource;
            CodigoBarraProducto codigoBarra = new CodigoBarraProducto { CodigoBarras = txtCodigoBarra.Text.Trim() };

            if (listaCodigoBarra.Exists(elemento => elemento.CodigoBarras == txtCodigoBarra.Text.Trim()))
            {
                MostrarDialogoResultado(this.Text, "El código de barra ya existe.", string.Empty, false);
                return;
            }

            listaCodigoBarra.Add(codigoBarra);
            gridCodigoBarra.AutoGenerateColumns = false;
            gridCodigoBarra.DataSource = null;
            gridCodigoBarra.DataSource = listaCodigoBarra;            
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
                //_frmCatFamiliasController.EditarFamilia(familia);
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
            if (gridCodigoBarra.DataSource == null)
            {
                MostrarDialogoResultado(this.Text, "No hay códigos que quitar.", string.Empty, false);
                return;
            }

            if (gridCodigoBarra.SelectedRows.Count == 0)
            {
                MostrarDialogoResultado(this.Text, "Seleccione un código de barra.", string.Empty, false);
                return;
            }

            List<CodigoBarraProducto> listaCodigoBarra = (List<CodigoBarraProducto>)gridCodigoBarra.DataSource;
            string codigoBarra = gridCodigoBarra.SelectedRows[0].Cells["CodigoBarras"].ToString();
            listaCodigoBarra.Remove(listaCodigoBarra.Find(elemento => elemento.CodigoBarras == codigoBarra));
            gridCodigoBarra.AutoGenerateColumns = false;
            gridCodigoBarra.DataSource = null;
            gridCodigoBarra.DataSource = listaCodigoBarra;


        }
    }
}

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
using SistemaFarmacia.Controladores.Ventas;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using SistemaFarmacia.Entidades.Negocio;

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmVenta : frmBase
    {
        ComplementoVenta _complementoVenta;
        frmVentaController _frmVentaController;
        List<DescuentoVenta> _listaDescuentoVenta;
        List<Usuario> _listaUsuarios;
        List<VentaDetalle> _listaVentaDetalle;
        List<VentaDetalleImpuesto> _listaVentaDetalleImpuesto;
        VentaDetalle _ventaDetalle;        
        DescuentoVenta _descuentoVenta;
        VentaImportes _ventaImporte;
        ContextoAplicacion _contexto;

        public frmVenta(ContextoAplicacion contexto)
        {
            InitializeComponent();
            InicializaRecursos();
            InicializaGridImportes();
            MensajeDescuentosAplicables();
            ToolTips();
            txtBusqueda.Select();
            _contexto = contexto;
        }

        private void ToolTips()
        {
            ToolTip toolBtnAplicarDescuento = new ToolTip();
            toolBtnAplicarDescuento.SetToolTip(btnAplicarDescuento, "Agregar descuento");

            ToolTip toolbtnGuardar = new ToolTip();
            toolbtnGuardar.SetToolTip(btnGuardar, "Guardar venta");

            ToolTip toolbtnRemover = new ToolTip();
            toolbtnRemover.SetToolTip(btnRemover, "Quitar producto");

            ToolTip toolbtnCortes = new ToolTip();
            toolbtnCortes.SetToolTip(btnCortes, "Ver Cortes de Caja F9");
        }

        private void InicializaRecursos()
        {
            _frmVentaController = new frmVentaController(this);
            txtBusqueda.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            LlenarListaProductos();
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.None;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _complementoVenta = _frmVentaController.ObtenerComplementoVenta();
            _listaDescuentoVenta = _frmVentaController.ObtenerListaDescuentoVenta();
            _listaUsuarios = _frmVentaController.ObtenerListaUsuarios();
            _listaVentaDetalle = new List<VentaDetalle>();
            _listaVentaDetalleImpuesto = new List<VentaDetalleImpuesto>();
            _ventaDetalle = new VentaDetalle();
            _descuentoVenta = new DescuentoVenta();
            _descuentoVenta.Descuento = new CatDescuentos();
            _ventaImporte = new VentaImportes();
        }

        private void MensajeDescuentosAplicables()
        {
            if (_listaDescuentoVenta.Count > 0)
            {
                MostrarDialogoResultado(this.Text, string.Format("Existen {0} descuento(s) aplicables para hoy.", _listaDescuentoVenta.Count), string.Empty, true);
            }
        }

        private void InicializaGridImportes()
        {
            object[] fila;
            gridImportes.Rows.Clear();
            fila = new object[] { "SubTotal:", 0.ToString("0.0000") };
            gridImportes.Rows.Add(fila);
            fila = new object[] { "Total:", 0.ToString("0.0000") };
            gridImportes.Rows.Add(fila);
        }

        private void EsconderResultados()
        {
            ltbResultados.Visible = false;
        }

        public void LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _frmVentaController.LlenarListaProductos();

            foreach (ProductosListado producto in listaProductos)
            {
                txtBusqueda.AutoCompleteCustomSource.Add(producto.DescripcionCompleta);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ltbResultados.BringToFront();
            ltbResultados.Items.Clear();
            _ventaDetalle = new VentaDetalle();            

            if (txtBusqueda.Text.Length == 0)
            {
                EsconderResultados();
                return;
            }

            foreach (String s in txtBusqueda.AutoCompleteCustomSource)
            {
                if (!s.Contains(txtBusqueda.Text.ToUpper())) continue;

                ltbResultados.Items.Add(s);
                ltbResultados.Visible = true;
            }
        }

        private void CargaValores(string[] elementosProducto)
        {
            txtBusqueda.Text = elementosProducto[2];
            EsconderResultados();
            int idProducto = Convert.ToInt16(elementosProducto[3]);
            CatProducto producto = _complementoVenta.ListaProductos.Find(e => e.IdProducto == idProducto);

            if (_listaDescuentoVenta.Count.Equals(0))
            {
                if (producto.AplicaPromocion)
                {
                    string mensaje = string.Format("{0}Por cada {1} productos el precio especial es de: ${2}{3}{4}No aplica con otros descuentos{5}", System.Environment.NewLine, producto.CantidadPromocion, producto.PrecioPromocion.ToString(".00"), System.Environment.NewLine, System.Environment.NewLine, System.Environment.NewLine);
                    MostrarDialogoResultado(this.Text, mensaje, string.Empty, true);
                }
            }

            _ventaDetalle.IdProducto = producto.IdProducto;
            _ventaDetalle.Precio = producto.Precio;
            _ventaDetalle.Descripcion = elementosProducto[2];
            _ventaDetalle.ClaveProducto = elementosProducto[1];

            frmCantidadVenta frmCantidadVenta = new frmCantidadVenta();
            DialogResult resultado = frmCantidadVenta.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                if (_listaVentaDetalle.Exists(e => e.IdProducto == _ventaDetalle.IdProducto))
                {
                    MostrarDialogoResultado(this.Text, "El producto ya existe, este no se agregó.", string.Empty, false);
                    _ventaDetalle = new VentaDetalle();
                    txtBusqueda.Text = string.Empty;
                    return;
                }

                _ventaDetalle.Cantidad = (Int16) frmCantidadVenta.nupCantidad.Value;
                _ventaDetalle.Total = (_ventaDetalle.Precio * _ventaDetalle.Cantidad);

                ActualizaGrid();
                ActualizaImportes();
                _ventaDetalle = new VentaDetalle();
            }

            _ventaDetalle = new VentaDetalle();
            txtBusqueda.Text = string.Empty;
            txtBusqueda.Select();

        }

        private void ActualizaGrid()
        {
            _listaVentaDetalle.Add(_ventaDetalle);
            gridVenta.AutoGenerateColumns = false;
            gridVenta.DataSource = null;
            gridVenta.DataSource = _listaVentaDetalle;
        }

        private void ActualizaImportes()
        {
            List<VentaImpuestos> listaImpuestos = new List<VentaImpuestos>();
            _ventaImporte = new VentaImportes();

            foreach (VentaDetalle ventaDetalle in _listaVentaDetalle)
            {
                decimal nuevoTotal = 0;

                if (_descuentoVenta.Descuento.Porcentaje > 0)
                {
                    nuevoTotal = (ventaDetalle.Total - (_descuentoVenta.Descuento.Porcentaje / 100) * (ventaDetalle.Total));
                    _ventaImporte.Ahorro = _ventaImporte.Ahorro + (ventaDetalle.Total - nuevoTotal);
                }
                else
                {
                    CatProducto productoDescuento = _complementoVenta.ListaProductos.Find(e => e.IdProducto == ventaDetalle.IdProducto);

                    if (productoDescuento.AplicaPromocion)
                    {
                        Int16 sobrante = Convert.ToInt16(ventaDetalle.Cantidad % productoDescuento.CantidadPromocion);
                        Int16 cantidadProductosPrecioEspecial = Convert.ToInt16(ventaDetalle.Cantidad - sobrante);
                        decimal totalSobrante = 0;
                        decimal totalPrecioEspecial = 0;

                        if (sobrante > 0)
                        {
                            totalSobrante = (sobrante * ventaDetalle.Precio);
                        }

                        if (cantidadProductosPrecioEspecial > 0)
                        {
                            totalPrecioEspecial = (cantidadProductosPrecioEspecial * productoDescuento.PrecioPromocion);
                            _ventaImporte.Ahorro = _ventaImporte.Ahorro + (ventaDetalle.Total - totalPrecioEspecial);
                        }

                        nuevoTotal = totalSobrante + totalPrecioEspecial;
                    }
                }

                decimal totalProducto = (nuevoTotal > 0 ? nuevoTotal : ventaDetalle.Total);

                _ventaImporte.SubTotal = _ventaImporte.SubTotal + totalProducto;

                List<ProductoVentaImpuesto> listaProductoVentaImpuesto = _complementoVenta.ListaProductoVentaImpuesto.FindAll(e => e.IdProducto == ventaDetalle.IdProducto);

                foreach (ProductoVentaImpuesto productoVentaImpuesto in listaProductoVentaImpuesto)
                {
                    VentaImpuestos ventaImpuestoNuevo = new VentaImpuestos();
                    ventaImpuestoNuevo.Impuesto = string.Format("{0}  {1} %:", productoVentaImpuesto.Descripcion.TrimEnd().TrimStart(), productoVentaImpuesto.Porcentaje.ToString("0.00"));
                    ventaImpuestoNuevo.IdImpuesto = productoVentaImpuesto.IdImpuesto;
                    ventaImpuestoNuevo.Total = ((productoVentaImpuesto.Porcentaje / 100) * (totalProducto));

                    if (listaImpuestos.Exists(e => e.IdImpuesto == ventaImpuestoNuevo.IdImpuesto))
                    {
                        VentaImpuestos ventaImporteExistente = listaImpuestos.Find(e => e.IdImpuesto == ventaImpuestoNuevo.IdImpuesto);
                        ventaImporteExistente.Total = ventaImporteExistente.Total + ventaImpuestoNuevo.Total;
                    }
                    else
                    {
                        listaImpuestos.Add(ventaImpuestoNuevo);
                    }
                }
            }           

            gridImportes.Rows.Clear();
            object[] fila;

            if (_ventaImporte.Ahorro > 0)
            {
                fila = new object[] { "Ahorro:", (_ventaImporte.Ahorro).ToString("0.0000") };
                gridImportes.Rows.Add(fila);
            }

            fila = new object[] { "SubTotal:", (_ventaImporte.SubTotal).ToString("0.0000") };
            gridImportes.Rows.Add(fila);

            foreach (VentaImpuestos ventaImportes in listaImpuestos)
            {
                fila = new object[] { ventaImportes.Impuesto, (ventaImportes.Total).ToString("0.0000") };
                gridImportes.Rows.Add(fila);
            }

            _ventaImporte.Total = _ventaImporte.SubTotal + listaImpuestos.Sum(e => e.Total);
            fila = new object[] { "Total:", (_ventaImporte.Total).ToString("0.0000") };
            gridImportes.Rows.Add(fila);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (_listaVentaDetalle.Count.Equals(0)) { return; }
            if (gridVenta.SelectedRows.Count.Equals(0)) { return; }

            int idProducto = (int) gridVenta.SelectedRows[0].Cells["IdProducto"].Value;
            VentaDetalle ventaRemover = _listaVentaDetalle.Find(elemento => elemento.IdProducto == idProducto);
            _listaVentaDetalle.Remove(ventaRemover);
            gridVenta.AutoGenerateColumns = false;
            gridVenta.DataSource = null;
            gridVenta.DataSource = _listaVentaDetalle;
            ActualizaImportes();
        }

        private void btnAplicarDescuento_Click(object sender, EventArgs e)
        {
            if (_listaDescuentoVenta.Count.Equals(0))
            {
                MostrarDialogoResultado(this.Text, "No existen descuentos aplicables.", string.Empty, false);
                return;
            }

            frmAplicarDescuento frmAplicarDescuento = new frmAplicarDescuento(_listaDescuentoVenta, _descuentoVenta.Descuento);
            DialogResult resultado = frmAplicarDescuento.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                int idDescuento = (int) frmAplicarDescuento.cmbDescuentos.SelectedValue;

                if (idDescuento.Equals(0))
                {
                    _descuentoVenta = new DescuentoVenta();
                    _descuentoVenta.Descuento = new CatDescuentos();
                }
                else
                {
                    _descuentoVenta = _listaDescuentoVenta.Find(elemento => elemento.Descuento.IdDescuento == idDescuento);                    
                }

                ActualizaImportes();
            }

        }

        public void LimpiarFormulario()
        {            
            InicializaGridImportes();
            InicializaRecursos();
            gridVenta.DataSource = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_listaVentaDetalle.Count.Equals(0))
            {
                MostrarDialogoResultado(this.Text, "Seleccione al menos un producto.", string.Empty, false);
                return;
            }

            if (MostrarDialogoConfirmacion(this.Text, "¿Están completos los datos de la venta?") == DialogResult.Cancel)
            {
                return;
            }

            frmVendedores frmVendedores = new frmVendedores(_listaUsuarios);
            DialogResult resultado = frmVendedores.ShowDialog();

            if (resultado == DialogResult.Cancel)
            {
                return;
            }

            this.Cursor = Cursors.WaitCursor;

            Venta venta = new Venta();
            venta.IdUsuario = (int) frmVendedores.cmbVendedores.SelectedValue;
            venta.DetalleVenta = _listaVentaDetalle;
            venta.Descuento = _ventaImporte.Ahorro;
            venta.IdDescuento = _descuentoVenta.Descuento.IdDescuento;
            venta.Porcentaje = _descuentoVenta.Descuento.Porcentaje;
            venta.SubTotal = _ventaImporte.SubTotal;
            venta.Total = _ventaImporte.Total;

            venta.DetalleVentaImpuesto = new List<VentaDetalleImpuesto>();

            foreach (VentaDetalle ventaDetalle in _listaVentaDetalle)
            {
                if (venta.IdDescuento.Equals(0))
                {
                    CatProducto producto = _complementoVenta.ListaProductos.Find(elemento => elemento.IdProducto == ventaDetalle.IdProducto);

                    if (producto.AplicaPromocion)
                    {
                        ventaDetalle.CantidadPromocion = producto.CantidadPromocion;
                        ventaDetalle.PrecioPromocion = producto.PrecioPromocion;
                    }
                }

                List<ProductoVentaImpuesto> listaProductoVentaImpuesto = _complementoVenta.ListaProductoVentaImpuesto.FindAll(elemento => elemento.IdProducto == ventaDetalle.IdProducto);

                foreach (ProductoVentaImpuesto productoVentaImpuesto in listaProductoVentaImpuesto)
                {
                    venta.DetalleVentaImpuesto.Add(new VentaDetalleImpuesto { IdImpuesto = productoVentaImpuesto.IdImpuesto, IdProducto = ventaDetalle.IdProducto, Porcentaje = productoVentaImpuesto.Porcentaje });
                }
            }

            _frmVentaController.GuardarVenta(venta);

            this.Cursor = Cursors.Default;

        }

        private void SeleccionarItemLista()
        {
            if (ltbResultados.SelectedItem == null) return;

            String productoSeleccionado = ltbResultados.Items[ltbResultados.SelectedIndex].ToString();
            string productoVenta = productoSeleccionado;
            productoVenta = productoVenta.Replace("CB: ", "");
            productoVenta = productoVenta.Replace(" CV: ", "|");
            productoVenta = productoVenta.Replace(" DSC: ", "|");
            productoVenta = productoVenta.Replace(" ID: ", "|");
            string[] elementosProducto = productoVenta.Split('|');
            txtBusqueda.Text = string.Empty;
            CargaValores(elementosProducto);
        }

        private void txtBusqueda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Down:
                    if (ltbResultados.Items.Count > 0)
                    {
                        ltbResultados.Select();
                        ltbResultados.SetSelected(0, true);
                    }

                    break;
            }
        }

        private void ltbResultados_Click(object sender, EventArgs e)
        {
            SeleccionarItemLista();
        }

        private void ltbResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                SeleccionarItemLista();
            }

            if ((int)e.KeyChar == (int)Keys.Back)
            {
                txtBusqueda.Select();
            }
        }

        private void CerrarVentana()
        {
            this.Close();
            this.Dispose();
        }

        private void GenerarCorte()
        {
            frmCortesCaja cortes = new frmCortesCaja(_contexto);
            cortes.Show();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F4:
                    CerrarVentana();
                    break;

                case Keys.F9:
                    GenerarCorte();
                    break;
            }

            return false;
        }
    }
}

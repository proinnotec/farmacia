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
        List<CatImpuestos> _listaImpuestos;
        VentaDetalle _ventaDetalle;

        public frmVenta(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _frmVentaController = new frmVentaController(this);
            txtBusqueda.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            LlenarListaProductos();
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.None;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _complementoVenta = _frmVentaController.ObtenerComplementoVenta();
            _listaDescuentoVenta = _frmVentaController.ObtenerListaDescuentoVenta();
            _listaUsuarios = _frmVentaController.ObtenerListaUsuarios();
            _listaImpuestos = _frmVentaController.ObtenerListaImpuestos();
            _listaVentaDetalle = new List<VentaDetalle>();
            _listaVentaDetalleImpuesto = new List<VentaDetalleImpuesto>();
            _ventaDetalle = new VentaDetalle();
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

        private void AgregarProducto()
        {
            //VentaDetalle ventaDetalle = new VentaDetalle();
            //ventaDetalle.IdProducto = dialogoVenta.IdProducto;
            //ventaDetalle.Cantidad = (Int16)dialogoVenta.nupCantidad.Value;

            //if (_listaDescuentoVenta.Count.Equals(0))
            //{
            //    CatProducto producto = _complementoVenta.ListaProductos.Find(elemento => elemento.IdProducto == dialogoVenta.IdProducto);

            //    if (producto.AplicaPromocion)
            //    {
            //        Int16 sobrante = Convert.ToInt16(ventaDetalle.Cantidad % producto.CantidadPromocion);
            //        Int16 cantidadProductosPrecioEspecial = Convert.ToInt16(ventaDetalle.Cantidad - sobrante);

            //        if (sobrante > 0)
            //        {

            //        }

            //        if (cantidadProductosPrecioEspecial > 0)
            //        {

            //        }
            //    }
            //}
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ltbResultados.BringToFront();
            ltbResultados.Items.Clear();
            _ventaDetalle = new VentaDetalle();
            btnAgregar.Enabled = false;

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

        private void ltbResultados_SelectedIndexChanged(object sender, EventArgs e)
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

            nupCantidad.Focus();
            btnAgregar.Enabled = true;
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
            gridImportes.Rows.Clear();
            object[] fila;
            List<VentaImportes> listaImpuestos = new List<VentaImportes>();
            decimal ahorroTotal = 0;

            foreach (VentaDetalle venta in _listaVentaDetalle)
            {
                if (_listaDescuentoVenta.Count.Equals(0))
                {
                    CatProducto productoDescuento = _complementoVenta.ListaProductos.Find(e => e.IdProducto == venta.IdProducto);

                    if (productoDescuento.AplicaPromocion)
                    {
                        Int16 sobrante = Convert.ToInt16(venta.Cantidad % productoDescuento.CantidadPromocion);
                        Int16 cantidadProductosPrecioEspecial = Convert.ToInt16(venta.Cantidad - sobrante);
                        decimal totalSobrante = 0;
                        decimal totalPrecioEspecial = 0;

                        if (sobrante > 0)
                        {
                            totalSobrante = (sobrante * venta.Precio);
                        }

                        if (cantidadProductosPrecioEspecial > 0)
                        {
                            totalPrecioEspecial = (cantidadProductosPrecioEspecial * productoDescuento.PrecioPromocion);
                            ahorroTotal = ahorroTotal + (venta.Total - totalPrecioEspecial);
                        }

                        venta.Total = totalSobrante + totalPrecioEspecial;
                    }
                }
                else
                {
                    decimal porcentajeTotal = _listaDescuentoVenta.Sum(e => e.Descuento.Porcentaje);
                    decimal nuevoTotal = (venta.Total - (porcentajeTotal / 100) * (venta.Total));
                    ahorroTotal = ahorroTotal + (venta.Total - nuevoTotal);
                    venta.Total = nuevoTotal;

                    //foreach (DescuentoVenta descuentoVenta in _listaDescuentoVenta)
                    //{
                    //    decimal nuevoTotal = (venta.Total - (descuentoVenta.Descuento.Porcentaje / 100) * (venta.Total));
                    //    ahorroTotal = ahorroTotal + (venta.Total - nuevoTotal);
                    //    venta.Total = nuevoTotal;                        
                    //}
                }

                List<ProductoVentaImpuesto> listaImpuesto = _complementoVenta.ListaProductoVentaImpuesto.FindAll(e => e.IdProducto == venta.IdProducto);

                foreach (ProductoVentaImpuesto productoVentaImpuesto in listaImpuesto)
                {
                    VentaImportes ventaImporteNuevo = new VentaImportes();
                    ventaImporteNuevo.Impuesto = productoVentaImpuesto.Descripcion.TrimEnd().TrimStart();
                    ventaImporteNuevo.IdImpuesto = productoVentaImpuesto.IdImpuesto;
                    ventaImporteNuevo.Total = ((productoVentaImpuesto.Porcentaje / 100) * (venta.Total));

                    if (listaImpuestos.Exists(e => e.IdImpuesto == ventaImporteNuevo.IdImpuesto))
                    {
                        VentaImportes ventaImporteExistente = listaImpuestos.Find(e => e.IdImpuesto == ventaImporteNuevo.IdImpuesto);
                        ventaImporteExistente.Total = ventaImporteExistente.Total + ventaImporteNuevo.Total;
                    }
                    else
                    {
                        listaImpuestos.Add(ventaImporteNuevo);
                    }
                }
            }

            if (ahorroTotal > 0)
            {
                fila = new object[] { "Ahorro:", ahorroTotal };
                gridImportes.Rows.Add(fila);
            }

            decimal subtotal = _listaVentaDetalle.Sum(e => e.Total);
            fila = new object[] { "SubTotal:", subtotal };
            gridImportes.Rows.Add(fila);

            foreach (VentaImportes ventaImportes in listaImpuestos)
            {
                fila = new object[] { ventaImportes.Impuesto, ventaImportes.Total };
                gridImportes.Rows.Add(fila);
            }

            fila = new object[] { "Total:", subtotal + listaImpuestos.Sum(e => e.Total) };
            gridImportes.Rows.Add(fila);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_ventaDetalle.IdProducto.Equals(0))
            {
                MostrarDialogoResultado(this.Text, "Seleccione un producto.", string.Empty, false);
                return;
            }

            if (nupCantidad.Value.Equals(0))
            {
                MostrarDialogoResultado(this.Text, "Capture la cantidad del producto.", string.Empty, false);
                return;
            }

            _ventaDetalle.Cantidad = (Int16) nupCantidad.Value;
            _ventaDetalle.Total = (_ventaDetalle.Precio * _ventaDetalle.Cantidad);

            ActualizaGrid();
            ActualizaImportes();

            nupCantidad.Value = 0;
            txtBusqueda.Text = string.Empty;
            btnAgregar.Enabled = false;
            _ventaDetalle = new VentaDetalle();
        }
    }
}

﻿using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
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


namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmDialogoProductoVenta : frmBase
    {
        private ComplementoVenta _complementoVenta;
        public int IdProducto { get; private set; }

        public frmDialogoProductoVenta(AutoCompleteStringCollection resultadosBusqueda, ComplementoVenta complementoVenta)
        {
            InitializeComponent();
            txtBusqueda.AutoCompleteCustomSource = resultadosBusqueda;
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.None;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _complementoVenta = complementoVenta;
        }

        private void EsconderResultados()
        {
            ltbResultados.Visible = false;
        }

        private void CargaValores(string[] elementosProducto)
        {
            string codigoBarra = elementosProducto[0];
            txtClaveProducto.Text = elementosProducto[1];
            txtDescripcion.Text = elementosProducto[2];
            IdProducto = Convert.ToInt16(elementosProducto[3]);
            CatProducto producto = _complementoVenta.ListaProductos.Find(e => e.IdProducto == IdProducto);
            List<ProductoVentaImpuesto> listaProductoVentaImpuesto = _complementoVenta.ListaProductoVentaImpuesto.FindAll(e => e.IdProducto == IdProducto);
            nudPrecio.Value = producto.Precio;
            chkAplicaDescuento.Checked = producto.AplicaDescuentoCatalogo;

            if (producto.AplicaPromocion)
            {
                string mensaje = string.Format("{0}Por cada {1} productos el precio especial es de: ${2}{3}{4}No aplica con otros descuentos{5}",System.Environment.NewLine, producto.CantidadPromocion, producto.PrecioPromocion.ToString(".00"), System.Environment.NewLine, System.Environment.NewLine, System.Environment.NewLine);
                lblPromocion.Text = mensaje;
                lblPromocion.Visible = true;
            }

            foreach (ProductoVentaImpuesto impuesto in listaProductoVentaImpuesto)
            {
                object[] fila = new object[] { impuesto.IdImpuesto, impuesto.Descripcion, impuesto.Porcentaje };
                gridImpuestos.Rows.Add(fila);
            }

            nupCantidad.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ltbResultados.BringToFront();
            ltbResultados.Items.Clear();
            gridImpuestos.Rows.Clear();

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

            lblPromocion.Text = string.Empty;
            lblPromocion.Visible = false;

            String productoSeleccionado = ltbResultados.Items[ltbResultados.SelectedIndex].ToString();
            string productoVenta = productoSeleccionado;
            productoVenta = productoVenta.Replace("CB: ", "");
            productoVenta = productoVenta.Replace(" CV: ", "|");
            productoVenta = productoVenta.Replace(" DSC: ", "|");
            productoVenta = productoVenta.Replace(" ID: ", "|");
            string[] elementosProducto = productoVenta.Split('|');
            txtBusqueda.Text = string.Empty;
            EsconderResultados();
            CargaValores(elementosProducto);
        }
    }
}

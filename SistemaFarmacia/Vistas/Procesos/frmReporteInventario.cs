using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Almacen.Reportes;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using SistemaFarmacia.Reportes;
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
    public partial class frmReporteInventario : frmBase
    {
        private ContextoAplicacion _contexto;
        private InventariosController _inventariosController;
        private AutoCompleteStringCollection _resultadosBusqueda;

        private int _idProducto;

        public frmReporteInventario(ContextoAplicacion contexto)
        {
            InitializeComponent();

            _contexto = contexto;
            _inventariosController = new InventariosController(this);
            _resultadosBusqueda = new AutoCompleteStringCollection();

            txtBusqueda.AutoCompleteCustomSource = _resultadosBusqueda;
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.None;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void frmReporteInventario_Load(object sender, EventArgs e)
        {
            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnImprimir, "Imprimir");

            LlenarListaProductos();

            HabilitarDesabilitarProductos(chbTodos.Checked);
        }

        public void LlenaInformacionReporte(List<Inventario> lista)
        {
            if (lista.Count <= 0)
            {
                MostrarDialogoResultado(this.Text, "No se encontró información con los parámetros especificados, favor de verificar", string.Empty, false);
                return;
            }

            rptInventario rptInventario = new rptInventario();

            rptInventario.SetDataSource(lista);
            rptInventario.SetParameterValue("Empresa", _contexto.Usuario.Sucursal);
            rptInventario.SetParameterValue("UsuarioEmite", _contexto.Usuario.NombreUsuario);

            string detalle = string.Empty;

            rptInventario.SetParameterValue("DetalleReporte", detalle);

            crvInventario.ReportSource = rptInventario;
            crvInventario.Refresh();

        }

        public void LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _inventariosController.LlenarListaProductos();

            foreach (ProductosListado producto in listaProductos)
            {
                _resultadosBusqueda.Add(producto.DescripcionCompleta);
            }
        }

        private void HabilitarDesabilitarProductos(bool habilita)
        {
            ltbResultados.Enabled = !habilita;
            txtBusqueda.Enabled = !habilita;
            _idProducto = 0;
            txtBusqueda.Text = string.Empty;

            txtBusqueda.Select();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ltbResultados.BringToFront();
            ltbResultados.Items.Clear();

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

        private void EsconderResultados()
        {
            ltbResultados.Visible = false;
        }

        private void ltbResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdxClaveProducto = 0;
            int IdxDescripcion = 0;
            int IdxIdProducto = 0;

            string Producto = ltbResultados.Items[ltbResultados.SelectedIndex].ToString();

            IdxClaveProducto = Producto.IndexOf(" CV: ");
            IdxDescripcion = Producto.IndexOf(" DSC: ");
            IdxIdProducto = Producto.IndexOf(" ID: ");

            if (ltbResultados.SelectedItem == null) return;

            txtBusqueda.Text = Producto.Substring(0, IdxIdProducto);
            EsconderResultados();

            string idProducto = string.Empty;

            idProducto = Producto.Substring(IdxIdProducto + 5, Producto.Length - (IdxIdProducto + 5));

            _idProducto = Convert.ToInt32(idProducto);

            if (_idProducto <= 0)
            {
                string mensaje = string.Format("{0}", "Debe seleccionar un producto para poder continuar");
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);

                return;
            }
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarDesabilitarProductos(chbTodos.Checked);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (!chbTodos.Checked && _idProducto == 0)
            {
                MostrarDialogoResultado(this.Text, "Debe seleccionar un producto para consultar el reporte", string.Empty, false);
                return;
            }

            _inventariosController.ConsultaInventario(_idProducto);
        }
    }
}

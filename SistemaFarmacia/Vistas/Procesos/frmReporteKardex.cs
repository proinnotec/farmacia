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
    public partial class frmReporteKardex : frmBase
    {
        private ContextoAplicacion _contexto;
        private KardexController _kardexController;
        private AutoCompleteStringCollection _resultadosBusqueda;

        private int _idProducto;
        DateTime _fechaInicio;
        DateTime _fechaFin;

        public frmReporteKardex(ContextoAplicacion contexto)
        {
            InitializeComponent();

            _contexto = contexto;
            _kardexController = new KardexController(this);
            _resultadosBusqueda = new AutoCompleteStringCollection();

            txtBusqueda.AutoCompleteCustomSource = _resultadosBusqueda;
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.None;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void frmReporteKardex_Load(object sender, EventArgs e)
        {
            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnImprimir, "Imprimir");

            LlenarListaProductos();
            
            HabilitarDesabilitarProductos(chbTodos.Checked);

            btnImprimir.Select();
        }

        public void LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _kardexController.LlenarListaProductos();

            foreach (ProductosListado producto in listaProductos)
            {
                _resultadosBusqueda.Add(producto.DescripcionCompleta);
            }
        }

        public void LlenaInformacionReporte(List<KardexEntidad> lista)
        {
            if(lista.Count <= 0)
            {
                MostrarDialogoResultado(this.Text, "No se encontró información con los parámetros especificados, favor de verificar", string.Empty, false);
                return;
            }
                        
            if (chbTipoMov.Checked)
            {
                rptKardexTipoMovimiento rptKardex = new rptKardexTipoMovimiento();

                rptKardex.SetDataSource(lista);
                rptKardex.SetParameterValue("Empresa", _contexto.Usuario.Sucursal);
                rptKardex.SetParameterValue("UsuarioEmite", _contexto.Usuario.NombreUsuario);

                string complementoDetalle = string.Empty;

                if (chbTodos.Checked)
                    complementoDetalle = "de todos los productos";

                string detalle = string.Format("Del {0} al {1} agrupado por movimiento {2}", _fechaInicio.ToShortDateString(), _fechaFin.ToShortDateString(), complementoDetalle);

                rptKardex.SetParameterValue("DetalleReporte", detalle);

                crvKardex.ReportSource = rptKardex;
                crvKardex.Refresh();

                Cursor.Current = Cursors.Default;
            }                

            else
            {
                rptKardex rptKardex = new rptKardex();

                rptKardex.SetDataSource(lista);
                rptKardex.SetParameterValue("Empresa", _contexto.Usuario.Sucursal);
                rptKardex.SetParameterValue("UsuarioEmite", _contexto.Usuario.NombreUsuario);

                string complementoDetalle = string.Empty;

                if (chbTodos.Checked)
                    complementoDetalle = "de todos los productos";

                string detalle = string.Format("Del {0} al {1} {2}", _fechaInicio.ToShortDateString(), _fechaFin.ToShortDateString(), complementoDetalle);

                rptKardex.SetParameterValue("DetalleReporte", detalle);

                crvKardex.ReportSource = rptKardex;
                crvKardex.Refresh();

            }
        }

        private void Imprimir()
        {
            _fechaInicio = dtpDel.Value;
            _fechaFin = dtpAl.Value;

            _fechaInicio = new DateTime(_fechaInicio.Year, _fechaInicio.Month, _fechaInicio.Day, 00, 00, 00);
            _fechaFin = new DateTime(_fechaFin.Year, _fechaFin.Month, _fechaFin.Day, 23, 59, 59);

            if (!chbTodos.Checked && _idProducto == 0)
            {
                MostrarDialogoResultado(this.Text, "Debe seleccionar un producto para consultar el reporte", string.Empty, false);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            _kardexController.ConsultaKardex(_fechaInicio, _fechaFin, _idProducto);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
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
        
        private void HabilitarDesabilitarProductos(bool habilita)
        {
            ltbResultados.Enabled = !habilita;
            txtBusqueda.Enabled = !habilita;
            _idProducto = 0;
            txtBusqueda.Text = string.Empty;

            txtBusqueda.Select();
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarDesabilitarProductos(chbTodos.Checked);
        }

        private void SeleccionarItemLista()
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

            btnImprimir.Select();
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

        private void ltbResultados_Click(object sender, EventArgs e)
        {
            SeleccionarItemLista();
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

        private void Cerrar()
        {
            Close();
            Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F8:
                    Imprimir();
                    break;
            }

            return false;
        }
    }
}

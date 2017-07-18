using SistemaFarmacia.Controladores.Ventas;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Ventas;
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

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmRepCortesCaja : frmBase
    {
        private ContextoAplicacion _contexto;
        private CortesCajaRepController _cortesCajaRepController;

        public frmRepCortesCaja(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contexto = contextoAplicacion;
            _cortesCajaRepController = new CortesCajaRepController(this);
        }

        private void frmRepCortesCaja_Load(object sender, EventArgs e)
        {
            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnImprimir, "Imprimir");

            HabilitarDesabilitarControles(chbTodos.Checked);
            _cortesCajaRepController.ObtenerListaVendedores(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void HabilitarDesabilitarControles(bool habilita)
        {
            cmbVendedores.Enabled = !habilita;
            cmbVendedores.SelectedValue = -1;
        }

        public void LlenarComboVendedores(List<Usuario> lista)
        {
            cmbVendedores.DataSource = null;
            cmbVendedores.DataSource = lista;
            cmbVendedores.DisplayMember = "NombreUsuario";
            cmbVendedores.ValueMember = "IdUsuario";
            cmbVendedores.SelectedValue = -1; 
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarDesabilitarControles(chbTodos.Checked);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio, fechaFin;
            int idVendedor = 0;

            fechaInicio = dtpFechaInicio.Value;
            fechaFin = dtpFechaFin.Value;

            if (!ValidarParametros(ref idVendedor))
                return;

            Cursor.Current = Cursors.WaitCursor;

            _cortesCajaRepController.GenerarCortesCajaReporte(fechaInicio, fechaFin, idVendedor);
        }

        private bool ValidarParametros(ref int idVendedor)
        {
            if(dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
            {
                MostrarDialogoResultado(this.Text, "La fecha de inicio, no puede ser mayor a la fecha final, favor de verificar.", string.Empty, false);
                return false;
            }

            if (!chbTodos.Checked)
            {
                if (cmbVendedores.SelectedValue == null)
                {
                    MostrarDialogoResultado(this.Text, "Si la casilla de ver todos los vendedores no está activa, debe seleccionar un vendedor, favor de verificar.", string.Empty, false);
                    return false;
                }

                idVendedor = (int)cmbVendedores.SelectedValue;
            }

            return true;
        }

        public void LlenarDatosReporte(List<CorteCajaReporte> lista)
        {
            if(lista.Count <= 0)
            {
                MostrarDialogoResultado(this.Text, "No se encontró información con estos parámetros de búsqueda, favor de verificar.", string.Empty, false);
                return;
            }

            rptCortesCaja reporte = new rptCortesCaja();

            reporte.SetDataSource(lista);
            reporte.SetParameterValue("Empresa", _contexto.Usuario.Sucursal);
            reporte.SetParameterValue("UsuarioEmite", _contexto.Usuario.NombreUsuario);

            string complementoDetalle = string.Empty;

            if (chbTodos.Checked)
                complementoDetalle = "de todos los vendedores";

            else
                complementoDetalle = "de un solo vendedor";

            string detalle = string.Format("Del {0} al {1} {2}", dtpFechaInicio.Value.ToShortDateString(), dtpFechaFin.Value.ToShortDateString(), complementoDetalle);

            reporte.SetParameterValue("DetalleReporte", detalle);

            crvReporte.ReportSource = reporte;
            crvReporte.Refresh();

            Cursor.Current = Cursors.Default;
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            _cortesCajaRepController.ObtenerListaVendedores(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            _cortesCajaRepController.ObtenerListaVendedores(dtpFechaInicio.Value, dtpFechaFin.Value);
        }
    }
}

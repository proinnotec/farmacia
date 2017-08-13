using SistemaFarmacia.Controladores.Ventas;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Reportes;
using SistemaFarmacia.Vistas.Base;
using System;
using SistemaFarmacia.Entidades.Negocio.Ventas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacia.Entidades.Negocio;

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmRepTicketReImp : frmBase
    {
        private ReimpresionTicketController _reimpresionTicketController;
        private Int64 _idTicket;
        private string _vendedor;
        private ContextoAplicacion _contexto;
        public frmRepTicketReImp(ContextoAplicacion contexto)
        {
            InitializeComponent();
            _reimpresionTicketController = new ReimpresionTicketController(this);
            _contexto = contexto;
        }

        private void frmRepTicketReImp_Load(object sender, EventArgs e)
        {
            ToolTip toolTipBuscar = new ToolTip();
            toolTipBuscar.SetToolTip(btnBuscar, "Buscar F3");

            _reimpresionTicketController.ObtenerListaVendedores(dtpInicio.Value, dtpFechaFin.Value);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarTickets();
        }

        private bool ValidarParametros(ref int idVendedor)
        {
            if (dtpInicio.Value.Date > dtpFechaFin.Value.Date)
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

        private void BuscarTickets()
        {
            int idVendedor = 0;
            
            if (!ValidarParametros(ref idVendedor))
                return;

            Entidades.Negocio.Ventas.Ticket opcionesBusqueda = new Entidades.Negocio.Ventas.Ticket();

            opcionesBusqueda.NoTicket = (Int64)nudTicket.Value;
            opcionesBusqueda.FechaInicio = new DateTime(dtpInicio.Value.Year, dtpInicio.Value.Month, dtpInicio.Value.Day, 00, 00, 00);
            opcionesBusqueda.FechaFin = new DateTime(dtpFechaFin.Value.Year, dtpFechaFin.Value.Month, dtpFechaFin.Value.Day, 23, 59, 59);
            opcionesBusqueda.IdUsuarioTicket = idVendedor;

            gridTickets.Select();

            _reimpresionTicketController.ObtenerListaTickets(opcionesBusqueda);

        }
        public void AsignarListaDeTickets(List<Entidades.Negocio.Ventas.Ticket> lista)
        {
            lblTicketsNumero.Text = lista.Count.ToString();

            if(lista.Count <= 0)
            {
                MostrarDialogoResultado(this.Text, "No se encontraron registros con los parámetros de búsqueda especificados, favor de verificar.", string.Empty, false);
                return;
            }

            gridTickets.AutoGenerateColumns = false;
            gridTickets.DataSource = null;
            gridTickets.DataSource = lista;
            
        }

        private void RecuperarDatosDeGrid()
        {
            if (!VerificaExistenciaRegistros())
                return;

            _idTicket = (Int64)gridTickets.SelectedRows[0].Cells["IdVenta"].Value;
            _vendedor = gridTickets.SelectedRows[0].Cells["VendedorTicket"].Value.ToString();

        }

    private bool VerificaExistenciaRegistros()
        {
            if (gridTickets.RowCount <= 0)
            {
                return false;
            }

            return true;
        }

        private void gridTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RecuperarDatosDeGrid();
        }

        private void gridTickets_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Down:
                    RecuperarDatosDeGrid();
                    break;

                case Keys.Up:
                    RecuperarDatosDeGrid();
                    break;

                case Keys.Enter:
                    MostrarTicket();
                    RecuperarDatosDeGrid();
                    break;
            }
        }

        public void LlenarComboVendedores(List<Usuario> lista)
        {
            cmbVendedores.DataSource = null;
            cmbVendedores.DataSource = lista;
            cmbVendedores.DisplayMember = "NombreUsuario";
            cmbVendedores.ValueMember = "IdUsuario";
            cmbVendedores.SelectedValue = -1;
        }

        private void HabilitarDesabilitarControles(bool habilita)
        {
            cmbVendedores.Enabled = !habilita;
            cmbVendedores.SelectedValue = -1;
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            HabilitarDesabilitarControles(chbTodos.Checked);
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            _reimpresionTicketController.ObtenerListaVendedores(dtpInicio.Value, dtpFechaFin.Value);
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            _reimpresionTicketController.ObtenerListaVendedores(dtpInicio.Value, dtpFechaFin.Value);
        }

        private void gridTickets_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MostrarTicket();
        }

        private void MostrarTicket()
        {
            _reimpresionTicketController.ObtenerTicket(_idTicket);

        }

        public void VerReporte(List<ContextoTicket> lista)
        {
            rptTicket rptTicket = new rptTicket();

            rptTicket.SetDataSource(lista);
            rptTicket.SetParameterValue("Vendedor", _vendedor);
            rptTicket.SetParameterValue("Direccion", _contexto.Usuario.Direccion);
            rptTicket.SetParameterValue("Sucursal", string.Format("Farmacia de Genéricos: {0}", _contexto.Usuario.Sucursal));

            crvTicket.ReportSource = rptTicket;
            crvTicket.Zoom(Convert.ToInt32(150));
            crvTicket.Refresh();

        }

        private void gridTickets_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                RecuperarDatosDeGrid();
                e.SuppressKeyPress = true;
            }
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {               
                case Keys.F3:
                    BuscarTickets();
                    break;
            }

            return false;
        }
    }
}

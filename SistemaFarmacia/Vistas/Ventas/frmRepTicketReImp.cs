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
        public frmRepTicketReImp(ContextoAplicacion contexto)
        {
            InitializeComponent();
            _reimpresionTicketController = new ReimpresionTicketController(this);
        }

        private void frmRepTicketReImp_Load(object sender, EventArgs e)
        {
            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnBuscar, "Imprimir");
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
            opcionesBusqueda.FechaInicio = dtpInicio.Value;
            opcionesBusqueda.FechaFin = dtpFechaFin.Value;
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

            Entidades.Negocio.Ventas.Ticket opcionesBusqueda = new Entidades.Negocio.Ventas.Ticket();

            opcionesBusqueda.NoTicket = (Int64)gridTickets.SelectedRows[0].Cells["NoTicket"].Value;

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
    }
}

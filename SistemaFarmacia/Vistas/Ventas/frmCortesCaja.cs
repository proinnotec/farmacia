using SistemaFarmacia.Controladores.Ventas;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Ventas;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmCortesCaja : frmBase
    {
        private ContextoAplicacion _contextoAplicacion;
        private CortesCajaController _cortesCajaController;

        public frmCortesCaja(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();

            _contextoAplicacion = contextoAplicacion;
            _cortesCajaController = new CortesCajaController(this);
        }

        private void frmCortesCaja_Load(object sender, EventArgs e)
        {
            ToolTip toolTipNuevo = new ToolTip();
            toolTipNuevo.SetToolTip(btnNuevo, "Nuevo F2");

            ToolTip toolTipRecargar = new ToolTip();
            toolTipRecargar.SetToolTip(btnRecargar, "Recargar información F3");

            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnImprimir, "Ver reporte de Cortes F8");

            ToolTip toolTipSalir = new ToolTip();
            toolTipSalir.SetToolTip(btnCancelar, "Cerrar F4");

            ConsultarCortes();
        }

        private void ConsultarCortes()
        {
            _cortesCajaController.ObtenerCortesCaja((int)nudAnio.Value, false);
        }

        public void AsignarListaDeCortes(List<CorteCaja> lista, bool verReporte)
        {
            gridCortes.AutoGenerateColumns = false;
            gridCortes.DataSource = null;
            gridCortes.DataSource = lista;

            if (verReporte)
                MostrarReporte();
        }

        private void MostrarReporte()
        {
            frmRepCortesCaja reporte = new frmRepCortesCaja(_contextoAplicacion);
            reporte.Show();

        }

        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {
            ConsultarCortes();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ConsultarCortes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            GenerarCorte();
        }

        private void GenerarCorte()
        {
            if (!ConfirmarGuardado())
                return;

            nudAnio.Value = DateTime.Now.Year;

            CorteCaja corte = new CorteCaja();
            
            corte.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            corte.Fecha = DateTime.Now;

            _cortesCajaController.GenerarCorteCaja(corte, true);
        }

        private bool ConfirmarGuardado()
        {
            string mensaje = string.Format("{0}", "¿Confirma que desea realizar el corte de caja?");

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;
        }

        private void CerrarVentana()
        {
            this.Close();
            this.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    GenerarCorte();
                    break;

                case Keys.F3:
                    ConsultarCortes();
                    break;

                case Keys.F4:
                    CerrarVentana();
                    break;

                case Keys.F8:
                    MostrarReporte();
                    break;
            }

            return false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MostrarReporte();
        }
    }
}

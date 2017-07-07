using SistemaFarmacia.Controladores.Ventas;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Ventas;
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
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar");

            ConsultarCortes();
        }

        private void ConsultarCortes()
        {
            _cortesCajaController.ObtenerCortesCaja((int)nudAnio.Value);
        }

        public void AsignarListaDeCortes(List<CorteCaja> lista)
        {
            gridCortes.AutoGenerateColumns = false;
            gridCortes.DataSource = null;
            gridCortes.DataSource = lista;
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
            this.Close();
            this.Dispose();
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

            _cortesCajaController.GenerarCorteCaja(corte);
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
    }
}

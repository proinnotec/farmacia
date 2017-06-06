using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
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
    public partial class frmEntradas : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        private EntradasController _entradasController;
        public frmEntradas(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _entradasController = new EntradasController(this);
        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar");

            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditaEntradas vistaEditaEntradas = new frmEditaEntradas(_contextoAplicacion);
            vistaEditaEntradas.ShowDialog();
        }

        private void CargarDatos()
        {
            int anio;
            anio = (int)nudAnio.Value;
            _entradasController.ConsultaEntradasCabecera(anio);
        }

        public void AsignarListaEntradas(List<EntradaProductoListado> lista)
        {
            gridListadoEntradas.AutoGenerateColumns = false;
            gridListadoEntradas.DataSource = null;
            gridListadoEntradas.DataSource = lista;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}

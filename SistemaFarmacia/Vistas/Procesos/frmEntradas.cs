using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Procesos
{
    public partial class frmEntradas : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        private EntradasController _entradasController;
        private EntradaProductoListado _entradaProductoListado;
        public frmEntradas(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _entradasController = new EntradasController(this);
            _entradaProductoListado = new EntradaProductoListado();
        }

        private void frmEntradas_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo F2");

            ToolTip toolTipImprimir = new ToolTip();
            toolTipImprimir.SetToolTip(btnImprimir, "Imprimir F8");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información F3");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar F4");

            CargarDatos();
        }

        private void Cerrar()
        {
            this.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Nuevo()
        {
            EntradaProductoListado entradaProductoListado = new EntradaProductoListado();

            frmEditaEntradas vistaEditaEntradas = new frmEditaEntradas(_contextoAplicacion, EnumeradoAccion.Alta, this, entradaProductoListado);
            vistaEditaEntradas.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public void CargarDatos(bool realizarImpresion = false)
        {
            int anio;
            anio = (int)nudAnio.Value;
            _entradasController.ConsultaEntradasCabecera(anio);
            RecuperarDatosDeGrid();

            if (realizarImpresion)
                ImprimirEntrada();
        }

        private bool VerificaExistenciaRegistros()
        {
            if (gridListadoEntradas.RowCount <= 0)
            {
                MostrarDialogoResultado(this.Text, "No hay registros para mostrar.", string.Empty, false);
                return false;
            }

            return true;
        }

        private void RecuperarDatosDeGrid()
        {
            if (!VerificaExistenciaRegistros())
                return;

            _entradaProductoListado.IdEntradaProductoDetalle = (int)gridListadoEntradas.SelectedRows[0].Cells["IdEntradaProductoDetalle"].Value;
            _entradaProductoListado.IdEntradaProducto = (int)gridListadoEntradas.SelectedRows[0].Cells["IdEntradaProducto"].Value;
            _entradaProductoListado.Fecha = (DateTime)gridListadoEntradas.SelectedRows[0].Cells["FechaAplica"].Value;
            _entradaProductoListado.IdProveedor = (int)gridListadoEntradas.SelectedRows[0].Cells["IdProveedor"].Value;
            _entradaProductoListado.RazonSocial = gridListadoEntradas.SelectedRows[0].Cells["Proveedor"].Value.ToString();
            _entradaProductoListado.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            
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

        private void gridListadoEntradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RecuperarDatosDeGrid();
        }

        private void Editar()
        {
            frmEditaEntradas vistaEditaEntradas = new frmEditaEntradas(_contextoAplicacion, EnumeradoAccion.Edicion, this, _entradaProductoListado);
            vistaEditaEntradas.ShowDialog();
        }

        private void gridListadoEntradas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Editar();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimirEntrada();
        }

        private void ImprimirEntrada()
        {
            _entradasController.ConsultaReporte(_entradaProductoListado.IdEntradaProducto);
        }

        public void LlenaInformacionReporte(List<EntradaProductoListado> lista)
        {
            frmReporteEntrada reporte = new frmReporteEntrada(lista, _contextoAplicacion);
            reporte.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    Nuevo();
                    break;

                case Keys.F3:
                    CargarDatos();
                    break;

                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F8:
                    ImprimirEntrada();
                    break;

                case Keys.F11:
                    Editar();
                    break;
            }

            return false;
        }

        private void gridListadoEntradas_KeyUp(object sender, KeyEventArgs e)
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
    }
}

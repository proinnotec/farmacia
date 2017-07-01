using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Procesos
{
    public partial class frmListadoAjustes : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        private ListadoAjustesController _listadoAjustesController;
        private AjustesProductosListado _ajustesProductoListado;

        public frmListadoAjustes(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _listadoAjustesController = new ListadoAjustesController(this);
            _ajustesProductoListado = new AjustesProductosListado();
        }

        private void frmListadoAjustes_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar");

            CargarDatos();
        }

        public void CargarDatos()
        {
            int anio;
            anio = (int)nudAnio.Value;
            _listadoAjustesController.ConsultaAjusteProductos(anio);
            RecuperarDatosDeGrid();
        }

        private bool VerificaExistenciaRegistros()
        {
            if (gridListadoAjustes.RowCount <= 0)
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

            _ajustesProductoListado.IdAjusteProducto = (int)gridListadoAjustes.SelectedRows[0].Cells["IdAjusteProducto"].Value;
            _ajustesProductoListado.IdSucursal = (int)gridListadoAjustes.SelectedRows[0].Cells["IdSucursal"].Value;
            _ajustesProductoListado.Fecha = (DateTime)gridListadoAjustes.SelectedRows[0].Cells["Fecha"].Value;
            _ajustesProductoListado.IdAjusteProductoDetalle = (int)gridListadoAjustes.SelectedRows[0].Cells["IdAjusteProductoDetalle"].Value;
            _ajustesProductoListado.IdTipoAjuste = (int)gridListadoAjustes.SelectedRows[0].Cells["IdTipoAjuste"].Value;
            _ajustesProductoListado.Descripcion = gridListadoAjustes.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            _ajustesProductoListado.Cantidad = Convert.ToDecimal(gridListadoAjustes.SelectedRows[0].Cells["Cantidad"].Value);
            _ajustesProductoListado.IdProducto = (int)gridListadoAjustes.SelectedRows[0].Cells["IdProducto"].Value;
            _ajustesProductoListado.ClaveProducto = gridListadoAjustes.SelectedRows[0].Cells["ClaveProducto"].Value.ToString();
            _ajustesProductoListado.DescripcionProducto = gridListadoAjustes.SelectedRows[0].Cells["DescripcionProducto"].Value.ToString();
            //_ajustesProductoListado.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

        }

        public void AsignarListaAjustes(List<AjustesProductosListado> lista)
        {
            gridListadoAjustes.AutoGenerateColumns = false;
            gridListadoAjustes.DataSource = null;
            gridListadoAjustes.DataSource = lista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void gridListadoAjustes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridListadoAjustes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RecuperarDatosDeGrid();
        }

        private void gridListadoAjustes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmAjustes vistaEditaAjustes = new frmAjustes(_contextoAplicacion, EnumeradoAccion.Edicion, this, _ajustesProductoListado);
            //vistaEditaAjustes.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AjustesProductosListado ajustesProductosListado = new AjustesProductosListado();

            frmAjustes vistaEditaAjustes = new frmAjustes(_contextoAplicacion, EnumeradoAccion.Alta, this, ajustesProductosListado);
            vistaEditaAjustes.ShowDialog();
        }
    }
}

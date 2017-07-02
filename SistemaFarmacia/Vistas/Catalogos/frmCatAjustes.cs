using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Base;
using SistemaFarmacia.Entidades.Enumerados;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmCatAjustes : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        private frmCatAjustesController _frmCatAjustesController;
        private EnumeradoAccion _enumeradoAccion;
        private ToolTip _toolTipActivaDesactiva;
        private int _idTipoAjuste;
        private bool _esActivo;

        public frmCatAjustes(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _frmCatAjustesController = new frmCatAjustesController(this);
            _enumeradoAccion = EnumeradoAccion.Alta;
            _toolTipActivaDesactiva = new ToolTip();
            _idTipoAjuste = 0;

            AsigarListaTiposAjustes(_frmCatAjustesController.ListaAjustes());
        }

        private void frmCatAjustes_Load(object sender, EventArgs e)
        {
            cmbTipoAjuste.Items.Insert(0, "Salida");
            cmbTipoAjuste.Items.Insert(1, "Entrada");
            cmbTipoAjuste.SelectedIndex = 0;

            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo");

            ToolTip ToolTipGuardar = new ToolTip();
            ToolTipGuardar.SetToolTip(btnGuardar, "Guardar");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar el catálogo");

            AsignarDatosDeGrid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ActivarDesactivarControles(true);

            LimpiarFormulario();
        }
        
        private void AsignarDatosDeGrid()
        {
            if (gridTiposAjustes.SelectedRows.Count == 0)
                return;

            txtDescripcion.Text = gridTiposAjustes.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            _idTipoAjuste = (int)gridTiposAjustes.SelectedRows[0].Cells["IdTipoAjuste"].Value;
            cmbTipoAjuste.SelectedIndex = _idTipoAjuste;
            _esActivo = (bool)gridTiposAjustes.SelectedRows[0].Cells["EsActivo"].Value;

            _enumeradoAccion = EnumeradoAccion.Edicion;

            string mensajeToolTip = string.Empty;

            if (_esActivo)
            {
                btnEliminar.BackgroundImage = Resource.bloquear;
                mensajeToolTip = "Dar de baja el registro";

                _toolTipActivaDesactiva.SetToolTip(btnEliminar, mensajeToolTip);
            }
            else
            {
                btnEliminar.BackgroundImage = Resource.activar;
                mensajeToolTip = "Reactivar el registro";

                _toolTipActivaDesactiva.SetToolTip(btnEliminar, mensajeToolTip);
            }
        }



        private void ActivarDesactivarControles(bool seActiva)
        {
            if (seActiva)
            {
                gridTiposAjustes.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                gridTiposAjustes.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        public void LimpiarFormulario()
        {
            txtDescripcion.Text = string.Empty;
            _enumeradoAccion = EnumeradoAccion.Alta;
            _idTipoAjuste = 0;
        }

        public void AsigarListaTiposAjustes(List<CatAjustes> listaTiposAjustes)
        {
            gridTiposAjustes.AutoGenerateColumns = false;
            gridTiposAjustes.DataSource = null;
            gridTiposAjustes.DataSource = listaTiposAjustes;
        }

        bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MostrarDialogoResultado(this.Text, "Capture la descripción del tipo de ajuste.", string.Empty, false);
                return false;
            }

            return true;
        }

        bool ConfirmarBorrado()
        {
            string mensaje = string.Empty;

            if (_esActivo)
                mensaje = "¿Seguro que desea dar de baja el tipo de ajuste?";

            else
                mensaje = "¿Seguro que desea reactivar el tipo de ajuste?";

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        bool ConfirmarGuardado()
        {
            string mensaje = string.Empty;

            if (_enumeradoAccion == EnumeradoAccion.Alta)
            {
                mensaje = "¿Son correctos los datos del tipo de ajuste?";
            }

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        CatAjustes ContextoAjustes()
        {
            CatAjustes ajustes = new CatAjustes();
            ajustes.Descripcion = txtDescripcion.Text;
            ajustes.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            switch (cmbTipoAjuste.SelectedIndex)
            {
                case 0:
                    ajustes.TipoAjuste = false;
                    break;
                case 1:
                    ajustes.TipoAjuste = true;
                    break;
            }
            ajustes.IdTipoAjuste = 0;

            if (_enumeradoAccion != EnumeradoAccion.Alta)
            {
                ajustes.IdTipoAjuste = _idTipoAjuste;
            }

            return ajustes;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarFormulario())
            {
                return;
            }

            if (!ConfirmarGuardado())
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            CatAjustes ajuste = ContextoAjustes();
            
            if (_enumeradoAccion == EnumeradoAccion.Alta)
            {
                _frmCatAjustesController.GuardarTipoAjuste(ajuste);
            }

            Cursor.Current = Cursors.Default;

            ActivarDesactivarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ConfirmarBorrado())
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            CatAjustes ajuste = ContextoAjustes();

            if (_esActivo)
                ajuste.EsActivo = false;

            else
                ajuste.EsActivo = true;

            _frmCatAjustesController.EliminarTipoAjuste(ajuste);

            Cursor.Current = Cursors.Default;
        }
    }
}

using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmCatDescuentos : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        private ToolTip _toolTipActivaDesactiva;
        private CatDescuentosController _catDescuentosController;
        private CatDescuentos _descuentoLocal;
        public frmCatDescuentos(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _toolTipActivaDesactiva = new ToolTip();
            _catDescuentosController = new CatDescuentosController(this);
            _descuentoLocal = new CatDescuentos();

        }

        private void frmCatDescuentos_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo F2");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información F3");

            ToolTip ToolTipConfiguraciones = new ToolTip();
            ToolTipConfiguraciones.SetToolTip(btnConfiguraciones, "Configurar descuento F6");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar el catálogo F4");

            ConsultarDescuentos();

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

        public void ConsultarDescuentos()
        {
            _catDescuentosController.ConsultarDescuentos();
        }

        public void AsignarListaDescuentos(List<CatDescuentos> lista)
        {
            gridDescuentos.AutoGenerateColumns = false;
            gridDescuentos.DataSource = null;
            gridDescuentos.DataSource = lista;

            CargarDatosDeGridAObjeto();
        }

        private void CargarDatosDeGridAObjeto()
        {
            if (!VerificaExistenciaRegistros())
                return;

            _descuentoLocal.IdDescuento = (int)gridDescuentos.SelectedRows[0].Cells["IdDescuento"].Value;
            _descuentoLocal.Porcentaje = (decimal)gridDescuentos.SelectedRows[0].Cells["Porcentaje"].Value;
            _descuentoLocal.Descripcion = gridDescuentos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            _descuentoLocal.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            _descuentoLocal.EsActivo = (bool)gridDescuentos.SelectedRows[0].Cells["EsActivo"].Value;

            string mensajeToolTip = string.Empty;

            if (_descuentoLocal.EsActivo)
            {
                btnActDes.BackgroundImage = Resource.bloquear;
                mensajeToolTip = "Dar de baja el registro F7";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
            else
            {
                btnActDes.BackgroundImage = Resource.activar;
                mensajeToolTip = "Reactivar el registro F7";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
        }
        
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ConsultarDescuentos();
        }

        private void AgregaDescuento()
        {
            EnumeradoAccion enumeradoAccion = EnumeradoAccion.Alta;

            CatDescuentos descuentoNuevo = new CatDescuentos();

            frmAgregaEditaDescuentos vistaEdicion = new frmAgregaEditaDescuentos(_contextoAplicacion, enumeradoAccion, this, descuentoNuevo);
            vistaEdicion.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AgregaDescuento();
        }

        private void gridDescuentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_descuentoLocal.EsActivo)
            {
                string mensaje = string.Format("{0} {1} {2}", "No se puede editar el registro de", _descuentoLocal.Descripcion, "porque está dado de baja. Si quiere hacer cambios tendrá que reactivar el registro, favor de verificar");
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }

            EnumeradoAccion enumeradoAccion = EnumeradoAccion.Edicion;

            frmAgregaEditaDescuentos vistaEdicion = new frmAgregaEditaDescuentos(_contextoAplicacion, enumeradoAccion, this, _descuentoLocal);
            vistaEdicion.ShowDialog();
        }

        private void gridDescuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosDeGridAObjeto();
        }

        private bool VerificaExistenciaRegistros()
        {
            if (gridDescuentos.RowCount <= 0)
            {
                MostrarDialogoResultado(this.Text, "No hay registros para mostrar.", string.Empty, false);
                return false;
            }

            return true;
        }

        private void ActivaDesactivaRegistro()
        {
            if (!VerificaExistenciaRegistros())
                return;

            string accion;
            bool esActivo;

            if (_descuentoLocal.EsActivo)
            {
                accion = "dar de baja";
                esActivo = false;
            }
            else
            {
                accion = "reactivar";
                esActivo = true;
            }

            bool respuesta = ConfirmarActivacionDesactivacion(accion);

            if (respuesta)
            {
                _descuentoLocal.EsActivo = esActivo;
                _catDescuentosController.ActivarDesactivarDescuento(_descuentoLocal);
            }
        }

        private void btnActDes_Click(object sender, EventArgs e)
        {
            ActivaDesactivaRegistro();
        }

        bool ConfirmarActivacionDesactivacion(string accion)
        {
            string mensaje = string.Format("{0} {1} {2} {3}{4}", "¿Seguro que desea", accion, "el descuento de", _descuentoLocal.Descripcion, "?");

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;
        }

        private void AbrirConfiguraciones()
        {
            if (!VerificaExistenciaRegistros())
                return;

            if (!_descuentoLocal.EsActivo)
            {
                string mensaje = string.Format("{0} {1} {2}", "No se pueden realizar configuraciones al registro", _descuentoLocal.Descripcion, "porque está dado de baja. Si quiere hacer cambios tendrá que reactivar el registro, favor de verificar");
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }

            frmConfiguraDescuentos vistaConfiguracion = new frmConfiguraDescuentos(_contextoAplicacion, this, _descuentoLocal);
            vistaConfiguracion.ShowDialog();
        }

        private void btnConfiguraciones_Click(object sender, EventArgs e)
        {
            AbrirConfiguraciones();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    AgregaDescuento();
                    break;

                case Keys.F3:
                    ConsultarDescuentos();
                    break;
                    
                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F6:
                    AbrirConfiguraciones();
                    break;

                case Keys.F7:
                    ActivaDesactivaRegistro();
                    break;
            }

            return false;
        }
    }
}

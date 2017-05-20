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
    public partial class frmCatFamilias : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        private frmCatFamiliasController _frmCatFamiliasController;
        private EnumeradoAccion _enumeradoAccion;
        private int _idFamilia;

        public frmCatFamilias(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _frmCatFamiliasController = new frmCatFamiliasController(this);
            _enumeradoAccion = EnumeradoAccion.Alta;
            _idFamilia = 0;
            AsigarListaFamilias(_frmCatFamiliasController.ListaFamilias());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
            this.Dispose();
        }

        public void AsigarListaFamilias(List<CatFamilias> listaFamilias)
        {
            gridFamilia.AutoGenerateColumns = false;
            gridFamilia.DataSource = null;
            gridFamilia.DataSource = listaFamilias;
        }

        public void LimpiarFormulario()
        {
            txtDescripcion.Text = string.Empty;
            _enumeradoAccion = EnumeradoAccion.Alta;
            btnEliminar.Visible = false;
            _idFamilia = 0;
        }

        bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MostrarDialogoResultado(this.Text, "Capture la descripción de la familia.", string.Empty, false);
                return false;
            }

            return true;
        }

        bool ConfirmarBorrado()
        {
            string mensaje = "¿Seguro que desea eliminar la familia?";

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
                mensaje = "¿Son correctos los datos de la familia?";
            }
            else
            {
                mensaje = "¿Seguro que desea editar la familia?";
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

        CatFamilias ContextoFamilia()
        {
            CatFamilias familia = new CatFamilias();
            familia.Descripcion = txtDescripcion.Text;
            familia.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            familia.IdFamiliaProducto = 0;

            if (_enumeradoAccion != EnumeradoAccion.Alta)
            {
                familia.IdFamiliaProducto = _idFamilia;
            }            

            return familia;
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

            CatFamilias familia = ContextoFamilia();

            if (_enumeradoAccion == EnumeradoAccion.Alta)
            {                
                _frmCatFamiliasController.GuardarFamilia(familia);
            }

            if (_enumeradoAccion == EnumeradoAccion.Edicion)
            {
                _frmCatFamiliasController.EditarFamilia(familia);
            }

            Cursor.Current = Cursors.Default;
        }

        private void gridFamilia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridFamilia.SelectedRows.Count == 0)
            {
                return;
            }

            txtDescripcion.Text = gridFamilia.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            _idFamilia = (int)gridFamilia.SelectedRows[0].Cells["IdFamiliaProducto"].Value;
            btnEliminar.Visible = true;
            _enumeradoAccion = EnumeradoAccion.Edicion;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!ConfirmarBorrado())
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            CatFamilias familia = ContextoFamilia();

            _frmCatFamiliasController.EliminarFamilia(familia);

            Cursor.Current = Cursors.Default;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}

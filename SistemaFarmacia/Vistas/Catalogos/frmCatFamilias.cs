﻿using SistemaFarmacia.Controladores.Catalogos;
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
        private ToolTip _toolTipActivaDesactiva;
        private int _idFamilia;
        private bool _esActivo;

        public frmCatFamilias(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _frmCatFamiliasController = new frmCatFamiliasController(this);
            _enumeradoAccion = EnumeradoAccion.Alta;
            _toolTipActivaDesactiva = new ToolTip();
            _idFamilia = 0;
            AsigarListaFamilias(_frmCatFamiliasController.ListaFamilias());
        }

        private void frmCatFamilias_Load(object sender, EventArgs e)
        {
            gridFamilia.Select();
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo F2");

            ToolTip ToolTipGuardar = new ToolTip();
            ToolTipGuardar.SetToolTip(btnGuardar, "Guardar F5");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información F3");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar el catálogo F4");

            AsignarDatosDeGrid();
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
        
        private void ActivarDesactivarControles(bool seActiva)
        {
            if(seActiva)
            {
                gridFamilia.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                gridFamilia.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        public void AsigarListaFamilias(List<CatFamilias> listaFamilias)
        {
            gridFamilia.AutoGenerateColumns = false;
            gridFamilia.DataSource = null;
            gridFamilia.DataSource = listaFamilias;
        }

        public void LimpiarFormulario(bool esAsignarDatos)
        {
            txtDescripcion.Text = string.Empty;
            nudPrioridad.Value = 0;
            _enumeradoAccion = EnumeradoAccion.Alta;
            _idFamilia = 0;

            if(esAsignarDatos)
                AsignarDatosDeGrid();
        }

        bool ValidarFormulario()
        {
            if(_enumeradoAccion == EnumeradoAccion.Edicion && !_esActivo)
            {
                MostrarDialogoResultado(this.Text, "No se puede editar la familia si esta dada de baja, favor de verificar.", string.Empty, false);
                return false;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MostrarDialogoResultado(this.Text, "Capture la descripción de la familia.", string.Empty, false);
                return false;
            }

            return true;
        }

        bool ConfirmarBorrado()
        {
            string mensaje = string.Empty;

            if (_esActivo)
                mensaje = "¿Seguro que desea dar de baja la familia?";

            else
                mensaje = "¿Seguro que desea reactivar la familia?";

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
            familia.Prioridad = (int)nudPrioridad.Value;
            familia.IdFamiliaProducto = 0;

            if (_enumeradoAccion != EnumeradoAccion.Alta)
            {
                familia.IdFamiliaProducto = _idFamilia;
            }            

            return familia;
        }

        private void Guardar()
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

            if (_enumeradoAccion == EnumeradoAccion.Edicion)
            {
                familia.EsActivo = true;

                _frmCatFamiliasController.EditarFamilia(familia);
            }

            if (_enumeradoAccion == EnumeradoAccion.Alta)
            {
                _frmCatFamiliasController.GuardarFamilia(familia);
            }

            Cursor.Current = Cursors.Default;

            ActivarDesactivarControles(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void ActivaDesactivaRegistro()
        {
            if (!ConfirmarBorrado())
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            CatFamilias familia = ContextoFamilia();

            if (_esActivo)
                familia.EsActivo = false;

            else
                familia.EsActivo = true;

            _frmCatFamiliasController.EliminarFamilia(familia);

            Cursor.Current = Cursors.Default;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActivaDesactivaRegistro();
        }

        private void AgregarFamilia()
        {
            txtDescripcion.Select();

            ActivarDesactivarControles(false);

            LimpiarFormulario(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AgregarFamilia();
        }

        private void gridFamilia_Click(object sender, EventArgs e)
        {
            AsignarDatosDeGrid();
        }

        private void AsignarDatosDeGrid()
        {
            if (gridFamilia.SelectedRows.Count == 0)
                return;

            txtDescripcion.Text = gridFamilia.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            nudPrioridad.Value = (int)gridFamilia.SelectedRows[0].Cells["Prioridad"].Value;
            _idFamilia = (int)gridFamilia.SelectedRows[0].Cells["IdFamiliaProducto"].Value;
            _esActivo = (bool)gridFamilia.SelectedRows[0].Cells["EsActivo"].Value;

            _enumeradoAccion = EnumeradoAccion.Edicion;

            string mensajeToolTip = string.Empty;

            if (_esActivo)
            {
                btnEliminar.BackgroundImage = Resource.bloquear;
                mensajeToolTip = "Dar de baja el registro F7";

                _toolTipActivaDesactiva.SetToolTip(btnEliminar, mensajeToolTip);

            }
            else
            {
                btnEliminar.BackgroundImage = Resource.activar;
                mensajeToolTip = "Reactivar el registro F7";

                _toolTipActivaDesactiva.SetToolTip(btnEliminar, mensajeToolTip);

            }
        }

        private void ConsultarFamilias()
        {
            AsigarListaFamilias(_frmCatFamiliasController.ListaFamilias());

            ActivarDesactivarControles(true);

            LimpiarFormulario(false);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ConsultarFamilias();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    AgregarFamilia();
                    break;

                case Keys.F3:
                    ConsultarFamilias();
                    break;

                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F5:
                    Guardar();
                    break;

                case Keys.F7:
                    ActivaDesactivaRegistro();
                    break;
            }

            return false;
        }

        private void gridFamilia_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Down:
                    AsignarDatosDeGrid();
                    break;

                case Keys.Up:
                    AsignarDatosDeGrid();
                    break;

                case Keys.Enter:
                    AsignarDatosDeGrid();
                    break;
            }
        }
    }
}

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
    public partial class frmCatAjustes : frmBase
    {
        public ContextoAplicacion _contextoAplicacion;
        private frmCatAjustesController _frmCatAjustesController;
        private EnumeradoAccion _enumeradoAccion;
        private ToolTip _toolTipActivaDesactiva;
        private int _idTipoAjuste;
        private bool _esActivo;
        private CatAjustes _ajuste;

        public frmCatAjustes(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _frmCatAjustesController = new frmCatAjustesController(this);
            _enumeradoAccion = EnumeradoAccion.Alta;
            _toolTipActivaDesactiva = new ToolTip();
            _idTipoAjuste = 0;
            _ajuste = new CatAjustes();

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

            _idTipoAjuste = (int)gridTiposAjustes.SelectedRows[0].Cells["IdTipoAjuste"].Value;
            _esActivo = (bool)gridTiposAjustes.SelectedRows[0].Cells["EsActivo"].Value;

            string mensajeToolTip = string.Empty;

            if (_esActivo)
            {
                btnActDes.BackgroundImage = Resource.bloquear;
                mensajeToolTip = "Dar de baja el registro";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);
            }
            else
            {
                btnActDes.BackgroundImage = Resource.activar;
                mensajeToolTip = "Reactivar el registro";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);
            }
        }
        
        private void ActivarDesactivarControles(bool seActiva)
        {
            if (seActiva)
            {
                gridTiposAjustes.Enabled = true;
                btnActDes.Enabled = true;
            }
            else
            {
                gridTiposAjustes.Enabled = false;
                btnActDes.Enabled = false;
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

            CargarDatosDeGridAObjeto();
        }

        private void CargarDatosDeGridAObjeto()
        {
            _ajuste.IdTipoAjuste = (int)gridTiposAjustes.SelectedRows[0].Cells["IdTipoAjuste"].Value;
            _ajuste.TipoAjuste = (bool)gridTiposAjustes.SelectedRows[0].Cells["TipoAjuste"].Value;
            _ajuste.Descripcion = gridTiposAjustes.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            _ajuste.TextoTipoAjuste = gridTiposAjustes.SelectedRows[0].Cells["TextoTipoAjuste"].Value.ToString();
            _ajuste.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            _ajuste.EsActivo = (bool)gridTiposAjustes.SelectedRows[0].Cells["EsActivo"].Value;

            string mensajeToolTip = string.Empty;

            if (_ajuste.EsActivo)
            {
                btnActDes.BackgroundImage = Resource.bloquear;
                mensajeToolTip = "Dar de baja el registro";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
            else
            {
                btnActDes.BackgroundImage = Resource.activar;
                mensajeToolTip = "Reactivar el registro";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
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
            txtDescripcion.Select();

            ActivarDesactivarControles(false);

            LimpiarFormulario();
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
        
        private void btnActDes_Click(object sender, EventArgs e)
        {
            string accion;
            bool esActivo;

            if (_ajuste.EsActivo)
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
                _ajuste.EsActivo = esActivo;
                _frmCatAjustesController.ActivarDesactivarTipoAjuste(_ajuste);
            }
        }

        bool ConfirmarActivacionDesactivacion(string accion)
        {
            string mensaje = string.Format("{0} {1} {2} {3}{4}", "¿Seguro que desea", accion, "el tipo de ajuste de", _ajuste.Descripcion, "?");

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;
        }

        private void gridTiposAjustes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridTiposAjustes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosDeGridAObjeto();
        }
    }
}

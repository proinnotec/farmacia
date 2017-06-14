﻿using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmCatImpuestos : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private ToolTip _toolTipActivaDesactiva;
        private CatImpuestosController _catImpuestosController;
        private CatImpuestos _impuestoLocal;
        public frmCatImpuestos(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _toolTipActivaDesactiva = new ToolTip();
            _catImpuestosController = new CatImpuestosController(this);
            _impuestoLocal = new CatImpuestos();
        }

        private void frmCatImpuestos_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar el catálogo");

            ConsultarImpuestos();
        }

        public void ConsultarImpuestos()
        {
            _catImpuestosController.ConsultarImpuestos();
        }

        public void AsignarListaImpuestos(List<CatImpuestos> lista)
        {
            gridImpuestos.AutoGenerateColumns = false;
            gridImpuestos.DataSource = null;
            gridImpuestos.DataSource = lista;

            CargarDatosDeGridAObjeto();
        }

        private void CargarDatosDeGridAObjeto()
        {
            _impuestoLocal.IdImpuesto = (Int16)gridImpuestos.SelectedRows[0].Cells["IdImpuesto"].Value;
            _impuestoLocal.Porcentaje = (decimal)gridImpuestos.SelectedRows[0].Cells["Porcentaje"].Value;
            _impuestoLocal.Descripcion = gridImpuestos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            _impuestoLocal.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;
            _impuestoLocal.EsActivo = (bool)gridImpuestos.SelectedRows[0].Cells["EsActivo"].Value;

            string mensajeToolTip = string.Empty;

            if (_impuestoLocal.EsActivo)
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

        private void btnActDes_Click(object sender, EventArgs e)
        {
            string accion;
            bool esActivo;

            if (_impuestoLocal.EsActivo)
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
                _impuestoLocal.EsActivo = esActivo;
                _catImpuestosController.ActivarDesactivarImpuesto(_impuestoLocal);
            }
        }

        bool ConfirmarActivacionDesactivacion(string accion)
        {
            string mensaje = string.Format("{0} {1} {2} {3}{4}", "¿Seguro que desea", accion, "el impuesto de", _impuestoLocal.Descripcion, "?");

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ConsultarImpuestos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EnumeradoAccion enumeradoAccion = EnumeradoAccion.Alta;

            CatImpuestos impuestoNuevo = new CatImpuestos();

            frmAgregaEditaImpuestos vistaEdicion = new frmAgregaEditaImpuestos(_contextoAplicacion, enumeradoAccion, this, impuestoNuevo);
            vistaEdicion.ShowDialog();
        }

        private void gridImpuestos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridImpuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosDeGridAObjeto();
        }
        private void gridImpuestos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_impuestoLocal.EsActivo)
            {
                string mensaje = string.Format("{0} {1} {2}", "No se puede editar el registro de", _impuestoLocal.Descripcion, "porque está dado de baja. Si quiere hacer cambios tendrá que reactivar el registro, favor de verificar");
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }

            EnumeradoAccion enumeradoAccion = EnumeradoAccion.Edicion;

            frmAgregaEditaImpuestos vistaEdicion = new frmAgregaEditaImpuestos(_contextoAplicacion, enumeradoAccion, this, _impuestoLocal);
            vistaEdicion.ShowDialog();
        }
    }
}
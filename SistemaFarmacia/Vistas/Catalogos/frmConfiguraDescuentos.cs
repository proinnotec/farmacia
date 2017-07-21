using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmConfiguraDescuentos : frmBase
    {
        private CatDescuentos _descuento;
        private ContextoAplicacion _contexto;
        private ConfiguraDescuentoController _configuraDescuentoController;
        private ConfiguracionDescuento _configuracionDescuento;
        private ConfiguracionDescuento _descuentoGrid;
        private ToolTip _toolTipActivaDesactiva;

        public frmConfiguraDescuentos(ContextoAplicacion contextoAplicacion, frmCatDescuentos vistaLlamada, CatDescuentos descuento)
        {
            InitializeComponent();
            _descuento = descuento;
            _contexto = contextoAplicacion;
            _configuraDescuentoController = new ConfiguraDescuentoController(this);
            _configuracionDescuento = new ConfiguracionDescuento();
            _toolTipActivaDesactiva = new ToolTip();
            _descuentoGrid = new ConfiguracionDescuento();
        }

        private void frmConfiguraDescuentos_Load(object sender, EventArgs e)
        {
            ToolTip toolAgregar = new ToolTip();
            toolAgregar.SetToolTip(btnAgregar, "Agregar F5");

            ToolTip toolCancelar = new ToolTip();
            toolCancelar.SetToolTip(btnCancelar, "Cerrar F4");

            AsignarDatosCabecera();
            _configuraDescuentoController.ConsultarDiasSemana();
        }

        private void AsignarDatosCabecera()
        {
            lblDescripcion.Text = _descuento.Descripcion;
            lblPorcentaje.Text = _descuento.Porcentaje.ToString() + "%";

            _configuraDescuentoController.ConsultarDescuentoConfiguracion(_descuento.IdDescuento);
        }

        public void AsignarListaDescuentos(List<ConfiguracionDescuento> lista)
        {
            gridConfiguracionDescuentos.AutoGenerateColumns = false;
            gridConfiguracionDescuentos.DataSource = null;
            gridConfiguracionDescuentos.DataSource = lista;

            if (lista.Count > 0)
                AsignarDatosDeGridAObjeto();
        }

        public void ReestablecerDatos()
        {
            dtpInicio.Value = DateTime.Parse("00:00:00");
            dtpFin.Value = DateTime.Parse("23:59:59");
        }

        public void LlenarDatosComboDias(List<DiasSemana> lista)
        {
            cmbDia.Items.Clear();
            cmbDia.DataSource = lista;
            cmbDia.DisplayMember = "Dia";
            cmbDia.ValueMember = "IdDia";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AsignarDatosAObjeto();
            GuardarConfiguracion();
        }

        private bool ValidarGuardado()
        {
            string mensaje = string.Empty;

            if (_configuracionDescuento.IdDia <= 0)
            {
                mensaje = "Debe seleccionar un día para guardar la configuración del descuento.";
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return false;
            }

            if(_configuracionDescuento.HoraFin < _configuracionDescuento.HoraInicio)
            {
                mensaje = "La hora de fin no puede ser menor a la hora de inicio.";
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return false;
            }

            if (!ValidaTraslapes(_configuracionDescuento))
                return false;

            return true;
        }

        private void AsignarDatosDeGridAObjeto()
        {
            _descuentoGrid.IdDescuentoConfiguracion = (int)gridConfiguracionDescuentos.SelectedRows[0].Cells["IdDescuentoConfiguracion"].Value;
            _descuentoGrid.IdDescuento = (int)gridConfiguracionDescuentos.SelectedRows[0].Cells["IdDescuento"].Value;
            _descuentoGrid.IdDia = (int)gridConfiguracionDescuentos.SelectedRows[0].Cells["IdDia"].Value;
            _descuentoGrid.HoraInicio = (DateTime)gridConfiguracionDescuentos.SelectedRows[0].Cells["HoraInicio"].Value;
            _descuentoGrid.HoraFin = (DateTime)gridConfiguracionDescuentos.SelectedRows[0].Cells["HoraFinal"].Value;
            _descuentoGrid.EsActivo = (bool)gridConfiguracionDescuentos.SelectedRows[0].Cells["EsActivo"].Value;
            _descuentoGrid.IdUsuario = _contexto.Usuario.IdUsuario;

            string mensajeToolTip = string.Empty;

            if (_descuentoGrid.EsActivo)
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

        private void AsignarDatosAObjeto()
        {
            int dia = (int)cmbDia.SelectedValue;
            DateTime inicio = dtpInicio.Value;
            DateTime fin = dtpFin.Value;

            _configuracionDescuento.IdDescuento = _descuento.IdDescuento;
            _configuracionDescuento.IdDia = dia;
            _configuracionDescuento.HoraInicio = inicio;
            _configuracionDescuento.HoraFin = fin;
            _configuracionDescuento.IdUsuario = _contexto.Usuario.IdUsuario;
            
        }

        private void GuardarConfiguracion()
        {
            if (!ValidarGuardado())
                return;

            if (!ConfirmarGuardado())
                return;

            _configuraDescuentoController.GuardarDescuentoConfiguracion(_configuracionDescuento);
        }

        bool ConfirmarGuardado()
        {
            string mensaje = string.Empty;

            mensaje = "¿Seguro que desea guardar la información del descuento?";

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;

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

        private void ActivarDesactivarRegistro()
        {
            string accion;
            bool esActivo;

            if (_descuentoGrid.EsActivo)
            {
                accion = "dar de baja";
                esActivo = false;
            }
            else
            {
                accion = "reactivar";
                esActivo = true;

                if (!ValidaTraslapes(_descuentoGrid))
                    return;
            }

            bool respuesta = ConfirmarActivacionDesactivacion(accion);

            if (respuesta)
            {
                _descuentoGrid.EsActivo = esActivo;
                _configuraDescuentoController.ActivarDesactivarDescuentoConfiguracion(_descuentoGrid);
            }

        }

        private void btnActDes_Click(object sender, EventArgs e)
        {
            ActivarDesactivarRegistro();
        }

        private bool ValidaTraslapes(ConfiguracionDescuento confDescuento)
        {
            string mensaje = string.Empty;

            foreach (DataGridViewRow fila in gridConfiguracionDescuentos.Rows)
            {
                int idDescuentoConfiguracion, dia;
                DateTime horaInicio, horaFinal;
                bool esActivoGrid;

                idDescuentoConfiguracion = (int)fila.Cells["IdDescuentoConfiguracion"].Value;
                dia = (int)fila.Cells["IdDia"].Value;
                horaInicio = (DateTime)fila.Cells["HoraInicio"].Value;
                horaFinal = (DateTime)fila.Cells["HoraFinal"].Value;
                esActivoGrid = (bool)fila.Cells["EsActivo"].Value;

                if (idDescuentoConfiguracion != confDescuento.IdDescuentoConfiguracion)
                {
                    if (confDescuento.IdDia == dia && esActivoGrid)
                    {
                        if ((confDescuento.HoraInicio.TimeOfDay >= horaInicio.TimeOfDay && confDescuento.HoraInicio.TimeOfDay <= horaFinal.TimeOfDay) ||
                            (confDescuento.HoraFin.TimeOfDay <= horaFinal.TimeOfDay && confDescuento.HoraFin.TimeOfDay >= horaInicio.TimeOfDay) ||
                            (confDescuento.HoraInicio.TimeOfDay <= horaInicio.TimeOfDay && confDescuento.HoraFin.TimeOfDay >= horaFinal.TimeOfDay))
                        {
                            mensaje = "Existe un registro que se traslapa con esta configuración que intenta agregar, favor de verificar.";
                            MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                            return false;
                        }
                    }
                }

            }

            return true;
        }

        bool ConfirmarActivacionDesactivacion(string accion)
        {
            string mensaje = string.Format("{0} {1} {2}", "¿Seguro que desea", accion, "la configuración seleccionada?");

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;
        }

        private void gridConfiguracionDescuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AsignarDatosDeGridAObjeto();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F5:
                    AsignarDatosAObjeto();
                    GuardarConfiguracion();
                    break;

                case Keys.F7:
                    ActivarDesactivarRegistro();
                    break;
            }

            return false;
        }

        private void gridConfiguracionDescuentos_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Down:
                    AsignarDatosDeGridAObjeto();
                    break;

                case Keys.Up:
                    AsignarDatosDeGridAObjeto();
                    break;

                case Keys.Enter:
                    AsignarDatosDeGridAObjeto();
                    break;
            }
        }
    }
}

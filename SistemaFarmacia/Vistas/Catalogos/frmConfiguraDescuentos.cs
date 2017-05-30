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
        private List<DiasSemana> _listaDiasSemana;
        private ContextoAplicacion _contexto;
        private ConfiguraDescuentoController _configuraDescuentoController;
        private ConfiguracionDescuento _configuracionDescuento;
        ConfiguracionDescuento _descuentoGrid;
        private ToolTip _toolTipActivaDesactiva;

        public frmConfiguraDescuentos(ContextoAplicacion contextoAplicacion, frmCatDescuentos vistaLlamada, CatDescuentos descuento)
        {
            InitializeComponent();
            _descuento = descuento;
            _contexto = contextoAplicacion;
            _listaDiasSemana = new List<DiasSemana>();
            _configuraDescuentoController = new ConfiguraDescuentoController(this);
            _configuracionDescuento = new ConfiguracionDescuento();
            _toolTipActivaDesactiva = new ToolTip();
            _descuentoGrid = new ConfiguracionDescuento();
        }

        private void frmConfiguraDescuentos_Load(object sender, EventArgs e)
        {
            ToolTip ToolAgregar = new ToolTip();
            ToolAgregar.SetToolTip(btnAgregar, "Agregar");
            
            LlenarDatosComboDias();
            AsignarDatosCabecera();
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
            cmbDia.SelectedValue = 0;
            dtpInicio.Value = DateTime.Parse("00:00:00");
            dtpFin.Value = DateTime.Parse("23:59:59");
        }

        private void LlenarDatosComboDias()
        {
            DiasSemana diaSemana;

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 0;
            diaSemana.Dia = "--Seleccione--";
            _listaDiasSemana.Add(diaSemana);

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 1;
            diaSemana.Dia = "Lunes";
            _listaDiasSemana.Add(diaSemana);

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 2;
            diaSemana.Dia = "Martes";
            _listaDiasSemana.Add(diaSemana);

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 3;
            diaSemana.Dia = "Miércoles";
            _listaDiasSemana.Add(diaSemana);

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 4;
            diaSemana.Dia = "Jueves";
            _listaDiasSemana.Add(diaSemana);

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 5;
            diaSemana.Dia = "Viernes";
            _listaDiasSemana.Add(diaSemana);

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 6;
            diaSemana.Dia = "Sábado";
            _listaDiasSemana.Add(diaSemana);

            diaSemana = new DiasSemana();
            diaSemana.IdDia = 7;
            diaSemana.Dia = "Domingo";
            _listaDiasSemana.Add(diaSemana);

            cmbDia.Items.Clear();
            cmbDia.DataSource = _listaDiasSemana;
            cmbDia.DisplayMember = "Dia";
            cmbDia.ValueMember = "IdDia";
            cmbDia.SelectedValue = 0;
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

            foreach (DataGridViewRow fila in gridConfiguracionDescuentos.Rows)
            {
                int idDescuentoConfiguracion, dia;
                DateTime horaInicio, horaFinal;
                bool esActivo;
                
                idDescuentoConfiguracion = (int)fila.Cells["IdDescuentoConfiguracion"].Value;
                dia = (int)fila.Cells["IdDia"].Value;
                horaInicio = (DateTime)fila.Cells["HoraInicio"].Value;
                horaFinal = (DateTime)fila.Cells["HoraFinal"].Value;
                esActivo = (bool)fila.Cells["EsActivo"].Value;

                if (_configuracionDescuento.IdDia == dia && esActivo)
                {
                    if( (_configuracionDescuento.HoraInicio.TimeOfDay >= horaInicio.TimeOfDay &&  _configuracionDescuento.HoraInicio.TimeOfDay <= horaFinal.TimeOfDay) ||
                        (_configuracionDescuento.HoraFin.TimeOfDay <= horaFinal.TimeOfDay && _configuracionDescuento.HoraFin.TimeOfDay >= horaInicio.TimeOfDay))
                        
                    {
                        mensaje = "Existe un registro que se traslapa con esta configuración que intenta agregar, favor de verificar.";
                        MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                        return false;
                    }
                }


            }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnActDes_Click(object sender, EventArgs e)
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
            }

            bool respuesta = ConfirmarActivacionDesactivacion(accion);

            if (respuesta)
            {
                _descuentoGrid.EsActivo = esActivo;
                _configuraDescuentoController.ActivarDesactivarDescuentoConfiguracion(_descuentoGrid);
            }
            
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
    }
}

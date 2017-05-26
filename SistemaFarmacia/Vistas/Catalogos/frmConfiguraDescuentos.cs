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

        public frmConfiguraDescuentos(ContextoAplicacion contextoAplicacion, frmCatDescuentos vistaLlamada, CatDescuentos descuento)
        {
            InitializeComponent();
            _descuento = descuento;
            _contexto = contextoAplicacion;
            _listaDiasSemana = new List<DiasSemana>();
            _configuraDescuentoController = new ConfiguraDescuentoController(this);
        }

        private void frmConfiguraDescuentos_Load(object sender, EventArgs e)
        {
            ToolTip ToolAgregar = new ToolTip();
            ToolAgregar.SetToolTip(btnAgregar, "Agregar");

            ToolTip ToolTipQuitar = new ToolTip();
            ToolTipQuitar.SetToolTip(btnQuitar, "Quitar");
            
            LlenarDatosComboDias();
            AsignarDatos();
        }

        private void AsignarDatos()
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
        }

        private void AsignarDatosAObjeto()
        {
            int dia = (int)cmbDia.SelectedValue;
            DateTime inicio = dtpInicio.Value;
            DateTime fin = dtpFin.Value;

            ConfiguracionDescuento configuracionDescuento = new ConfiguracionDescuento();

            configuracionDescuento.IdDescuento = _descuento.IdDescuento;
            configuracionDescuento.IdDia = dia;
            configuracionDescuento.HoraInicio = inicio;
            configuracionDescuento.HoraFin = fin;
            configuracionDescuento.IdUsuario = _contexto.Usuario.IdUsuario;

            _configuraDescuentoController.GuardarDescuentoConfiguracion(configuracionDescuento);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

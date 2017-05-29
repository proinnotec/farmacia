using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmAgregaEditaImpuestos : frmBase
    {
        ContextoAplicacion _contextoAplicacion;
        private EnumeradoAccion _accion;
        private frmCatImpuestos _vistaLlamada;
        private CatImpuestos _impuesto;
        private AgregaEditaImpuestosController _agregaEditaImpuestosController;
        public frmAgregaEditaImpuestos(ContextoAplicacion contextoAplicacion, EnumeradoAccion accion, frmCatImpuestos vistaLlamada, CatImpuestos impuesto)
        {
            InitializeComponent();
            _impuesto = new CatImpuestos();
            _agregaEditaImpuestosController = new AgregaEditaImpuestosController(this);

            _accion = accion;
            _vistaLlamada = vistaLlamada;
            _impuesto = impuesto;
            _contextoAplicacion = contextoAplicacion;

            this.Text = "Alta de Impuesto";

            if (_accion == EnumeradoAccion.Edicion)
                this.Text = "Modificación de Impuesto";
        }

        private void frmAgregaEditaImpuestos_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipGuardar = new ToolTip();
            ToolTipGuardar.SetToolTip(btnGuardar, "Guardar");

            if (_accion == EnumeradoAccion.Edicion)
                AsignaDatosAControles();

            nudPorcentaje.Focus();
        }

        private void AsignaDatosAControles()
        {
            nudPorcentaje.Value = _impuesto.Porcentaje;
            txtDescripcion.Text = _impuesto.Descripcion;
        }



        public void Cerrar()
        {
            _vistaLlamada.ConsultarImpuestos();

            this.Close();
            this.Dispose();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarImpuesto();
        }

        private void GuardarImpuesto()
        {
            decimal porcentaje = nudPorcentaje.Value;
            string descripcion = txtDescripcion.Text;
            string mensaje = string.Empty;

            if (porcentaje <= 0)
                mensaje = "El porcentaje debe ser mayor a cero. \n";

            descripcion = descripcion.TrimEnd().TrimStart();

            if (string.IsNullOrEmpty(descripcion))
                mensaje = mensaje + "Capture una descripción para el impuesto.";

            if (mensaje.Length > 0)
            {
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }

            _impuesto.Porcentaje = porcentaje;
            _impuesto.Descripcion = descripcion;
            _impuesto.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

            if (!ConfirmarGuardado())
                return;

            _agregaEditaImpuestosController.GuardarImpuesto(_impuesto, _accion);
        }

        bool ConfirmarGuardado()
        {
            string mensaje = string.Empty;

            switch (_accion)
            {
                case EnumeradoAccion.Alta:
                    mensaje = "¿Seguro que desea guardar la información del impuesto?";
                    break;

                case EnumeradoAccion.Edicion:
                    mensaje = "¿Seguro que desea actualizar la información del impuesto?";
                    break;
            }

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;

        }
    }
}

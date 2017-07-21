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
    public partial class frmAgregaEditaDescuentos : frmBase
    {
        ContextoAplicacion _contextoAplicacion;
        private EnumeradoAccion _accion;
        private frmCatDescuentos _vistaLlamada;
        private CatDescuentos _descuento;
        private AgregaEditaDescuentosController _agregaEditaDescuentosController;
        public frmAgregaEditaDescuentos(ContextoAplicacion contextoAplicacion, EnumeradoAccion accion, frmCatDescuentos vistaLlamada, CatDescuentos descuento)
        {
            InitializeComponent();
            _descuento = new CatDescuentos();
            _agregaEditaDescuentosController = new AgregaEditaDescuentosController(this);

            _accion = accion;
            _vistaLlamada = vistaLlamada;
            _descuento = descuento;
            _contextoAplicacion = contextoAplicacion;

            this.Text = "Alta de Descuento";

            if (_accion == EnumeradoAccion.Edicion)
                this.Text = "Modificación de Descuento";

        }

        private void frmAgregaEditaDescuentos_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipGuardar = new ToolTip();
            ToolTipGuardar.SetToolTip(btnGuardar, "Guardar F5");
            
            nudPorcentaje.Select();

            if (_accion == EnumeradoAccion.Edicion)
                AsignaDatosAControles();
        }

        private void AsignaDatosAControles()
        {
            nudPorcentaje.Value = _descuento.Porcentaje;
            txtDescripcion.Text = _descuento.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDescuento();
        }

        private void GuardarDescuento()
        {
            decimal porcentaje = nudPorcentaje.Value;
            string descripcion = txtDescripcion.Text;
            string mensaje = string.Empty;

            if (porcentaje <= 0)
                mensaje = "El porcentaje debe ser mayor a cero. \n";

            descripcion = descripcion.TrimEnd().TrimStart();

            if (string.IsNullOrEmpty(descripcion))
                mensaje = mensaje + "Capture una descripción para el descuento.";

            if (mensaje.Length > 0)
            {
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }

            _descuento.Porcentaje = porcentaje;
            _descuento.Descripcion = descripcion;
            _descuento.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

            if (!ConfirmarGuardado())
                return;

            _agregaEditaDescuentosController.GuardarDescuento(_descuento, _accion);
        }

        bool ConfirmarGuardado()
        {
            string mensaje = string.Empty;

            switch (_accion)
            {
                case EnumeradoAccion.Alta:
                    mensaje = "¿Seguro que desea guardar la información del descuento?";
                    break;

                case EnumeradoAccion.Edicion:
                    mensaje = "¿Seguro que desea actualizar la información del descuento?";
                    break;
            }

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F5:
                    GuardarDescuento();
                    break;
            }

            return false;
        }

        public void Cerrar()
        {
            _vistaLlamada.ConsultarDescuentos();

            this.Close();
            this.Dispose();

        }
    }
}

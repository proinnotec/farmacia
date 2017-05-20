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
        private EnumeradoAccion _accion;
        private frmCatDescuentos _vistaLlamada;
        private CatDescuentos _descuento;
        public frmAgregaEditaDescuentos(EnumeradoAccion accion, frmCatDescuentos vistaLlamada, CatDescuentos descuento)
        {
            InitializeComponent();
            _descuento = new CatDescuentos();

            _accion = accion;
            _vistaLlamada = vistaLlamada;
            _descuento = descuento;

            this.Text = "Alta de Descuento";

            if (_accion == EnumeradoAccion.Edicion)
                this.Text = "Modificación de Descuento";

        }

        private void frmAgregaEditaDescuentos_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipGuardar = new ToolTip();
            ToolTipGuardar.SetToolTip(btnGuardar, "Guardar");

            if (_accion == EnumeradoAccion.Edicion)
                AsignaDatosAControles();
        }

        private void AsignaDatosAControles()
        {
            nudPorcentaje.Value = _descuento.Porcentaje;
            txtDescripcion.Text = _descuento.Descripcion;
        }
    }
}

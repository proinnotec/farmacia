using System;
using System.Windows.Forms;
using SistemaFarmacia.Vistas.Base;

namespace SistemaFarmacia.Vistas.Dialogos
{
    public partial class Dlg_Confirmacion : frmBase
    {
        private string _mensaje;
        private string _tituloVentana;

        public Dlg_Confirmacion(string tituloVentana, string mensaje)
        {
            InitializeComponent();

            _tituloVentana = tituloVentana;
            _mensaje = mensaje;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;

            Close();
        }

        private void Dlg_Confirmacion_Load(object sender, EventArgs e)
        {
            this.Text = _tituloVentana;

            lblMensaje.Text = _mensaje;

            picImagen.Image = SistemaFarmacia.Resource.Interrogativo;
        }
    }
}

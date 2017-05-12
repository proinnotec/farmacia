using System;
using System.Drawing;
using System.Windows.Forms;
using SistemaFarmacia.Vistas.Base;

namespace SistemaFarmacia.Vistas.Dialogos
{
    public partial class Dlg_Resultado : frmBase
    {
        private string _mensajeUsuario;
        private string _mensajeExcepcion;
        private string _tituloVentana;
        private bool _esOperacionExitosa;

        public Dlg_Resultado(string tituloVentana, string mensajeUsuario, string mensajeExcepcion, bool esOperacionExitosa)
        {
            InitializeComponent();

            _tituloVentana = tituloVentana;
            _mensajeUsuario = mensajeUsuario;
            _mensajeExcepcion = mensajeExcepcion;
            _esOperacionExitosa = esOperacionExitosa;
        }

        private void Dlg_Resultado_Load(object sender, EventArgs e)
        {
            this.Text = _tituloVentana;
            lblMensaje.Text = _mensajeUsuario;
            txtExcepcion.Text = _mensajeExcepcion;
            

            if (_esOperacionExitosa)
            {
                picImagen.Image = SistemaFarmacia.Resource.Correcto;

                tabDlgResultado.TabPages.Remove(tabExcepcion);
                
            }
            else
            {
                picImagen.Image = SistemaFarmacia.Resource.Incorrecto;

                if (string.IsNullOrEmpty(_mensajeExcepcion.TrimStart().TrimEnd()))
                {
                    tabDlgResultado.TabPages.Remove(tabExcepcion);
                }
                
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;

            Close();
        }


    }
}

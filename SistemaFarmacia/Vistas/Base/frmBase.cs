using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Vistas.Dialogos;


namespace SistemaFarmacia.Vistas.Base
{
    public partial class frmBase : Form
    {
        public ContextoAplicacion ContextoAplicacion;

        public frmBase()
        {
            ConfiguracionVista();
        }

        public frmBase(ContextoAplicacion contextoAplicacion)
        {
            ContextoAplicacion = contextoAplicacion;

            InitializeComponent();

            ConfiguracionVista();
        }

        private void ConfiguracionVista()
        {
            BackColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.WindowState = FormWindowState.Normal;
        }

        public DialogResult MostrarDialogoResultado(string tituloVentana, string mensajeUsuario, string mensajeExcepcion, bool operacion)
        {
            Dlg_Resultado dlg_Resultado = new Dlg_Resultado(tituloVentana, mensajeUsuario, mensajeExcepcion, operacion);
            return dlg_Resultado.ShowDialog();
        }

        public DialogResult MostrarDialogoConfirmacion(string tituloVentana, string mensaje)
        {
            Dlg_Confirmacion dlg_Confirmacion = new Dlg_Confirmacion(tituloVentana, mensaje);
            return dlg_Confirmacion.ShowDialog();
        }
    }
}

using SistemaFarmacia.Controladores.Administracion;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio;
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

namespace SistemaFarmacia.Vistas.Administracion
{
    public partial class frmCatUsuarios : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private CatUsuariosController _catUsuariosController;
        private EnumeradoAccion _enumeradoAccion;

        public frmCatUsuarios(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = _contextoAplicacion;
            _catUsuariosController = new CatUsuariosController(this);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmCatUsuarios_Load(object sender, EventArgs e)
        {
            _catUsuariosController.ObtenerUsuarios();
        }

        public void AsigarListaUsuarios(List<Usuario> listaUsuarios)
        {
            gridUsuarios.AutoGenerateColumns = false;
            gridUsuarios.DataSource = null;
            gridUsuarios.DataSource = listaUsuarios;
        }
    }
}

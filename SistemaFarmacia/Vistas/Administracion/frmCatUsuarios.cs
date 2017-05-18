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
        private Usuario _usuarioLocal;

        public frmCatUsuarios(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = _contextoAplicacion;
            _catUsuariosController = new CatUsuariosController(this);
            _usuarioLocal = new Usuario();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmCatUsuarios_Load(object sender, EventArgs e)
        {
            ObtenerUsuarios();
        }

        public void ObtenerUsuarios()
        {
            _catUsuariosController.ObtenerUsuarios();
        }

        public void AsigarListaUsuarios(List<Usuario> listaUsuarios)
        {
            gridUsuarios.AutoGenerateColumns = false;
            gridUsuarios.DataSource = null;
            gridUsuarios.DataSource = listaUsuarios;

            CargarDatosDeGridAObjeto();
        }

       private void CargarDatosDeGridAObjeto()
        {
            _usuarioLocal.IdUsuario = (int)gridUsuarios.SelectedRows[0].Cells["IdUsuario"].Value;
            _usuarioLocal.Nombre = gridUsuarios.SelectedRows[0].Cells["Nombre"].Value.ToString();
            _usuarioLocal.ApellidoPaterno = gridUsuarios.SelectedRows[0].Cells["ApellidoPaterno"].Value.ToString();
            _usuarioLocal.ApellidoMaterno = gridUsuarios.SelectedRows[0].Cells["ApellidoMaterno"].Value.ToString();
            _usuarioLocal.NombreUsuario = gridUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();
            _usuarioLocal.EsActivo = (bool)gridUsuarios.SelectedRows[0].Cells["EsActivo"].Value;
        }

        bool ConfirmarActivacionDesactivacion(string accion)
        {
            string mensaje = string.Format("{0} {1} {2} {3} {4}", "¿Seguro que desea", accion, "al usuario", _usuarioLocal.Nombre, _usuarioLocal.ApellidoPaterno, "?");

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnActDes_Click(object sender, EventArgs e)
        {
            string accion;

            if (_usuarioLocal.EsActivo)
            {
                _enumeradoAccion = EnumeradoAccion.Baja;
                accion = "dar de baja";
                _usuarioLocal.EsActivo = false;
            }
            else
            {
                accion = "reactivar";
                _enumeradoAccion = EnumeradoAccion.Reactivacion;
                _usuarioLocal.EsActivo = true;
            }
            
            bool respuesta = ConfirmarActivacionDesactivacion(accion);

            if (respuesta)
                _catUsuariosController.ActivarDesactivarUsuario(_usuarioLocal);

        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosDeGridAObjeto();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _enumeradoAccion = EnumeradoAccion.Alta;

            frmAgregaEditaUsuario vistaEdicion = new frmAgregaEditaUsuario(_usuarioLocal, _enumeradoAccion, this);
            vistaEdicion.ShowDialog();
        }
    }
}

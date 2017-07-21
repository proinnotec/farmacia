using SistemaFarmacia.Controladores.Administracion;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Administracion
{
    public partial class frmCatUsuarios : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private CatUsuariosController _catUsuariosController;
        private EnumeradoAccion _enumeradoAccion;
        private Usuario _usuarioLocal;
        ToolTip _toolTipActivaDesactiva;

        public frmCatUsuarios(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _catUsuariosController = new CatUsuariosController(this);
            _usuarioLocal = new Usuario();
            _toolTipActivaDesactiva = new ToolTip();
            _usuarioLocal.IdUsuarioRegistra = contextoAplicacion.Usuario.IdUsuario;
        }

        private void Cerrar()
        {
            this.Close();
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void frmCatUsuarios_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo F2");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información F3");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar el catálogo F4");

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
            if (!VerificaExistenciaRegistros())
                return;

            _usuarioLocal.IdUsuario = (int)gridUsuarios.SelectedRows[0].Cells["IdUsuario"].Value;
            _usuarioLocal.Nombre = gridUsuarios.SelectedRows[0].Cells["Nombre"].Value.ToString();
            _usuarioLocal.ApellidoPaterno = gridUsuarios.SelectedRows[0].Cells["ApellidoPaterno"].Value.ToString();
            _usuarioLocal.ApellidoMaterno = gridUsuarios.SelectedRows[0].Cells["ApellidoMaterno"].Value.ToString();
            _usuarioLocal.NombreUsuario = gridUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();
            _usuarioLocal.UserPassword = gridUsuarios.SelectedRows[0].Cells["UserPassword"].Value.ToString();
            _usuarioLocal.IdPerfil = (int)gridUsuarios.SelectedRows[0].Cells["IdPerfil"].Value;
            _usuarioLocal.Perfil = gridUsuarios.SelectedRows[0].Cells["Perfil"].Value.ToString();
            _usuarioLocal.EsActivo = (bool)gridUsuarios.SelectedRows[0].Cells["EsActivo"].Value;

            string mensajeToolTip = string.Empty;

            if (_usuarioLocal.EsActivo)
            {
                btnActDes.BackgroundImage = Resource.bloquear;
                mensajeToolTip = "Dar de baja el registro F7";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
            else
            {
                btnActDes.BackgroundImage = Resource.activar;
                mensajeToolTip = "Reactivar el registro F7";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
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

        private bool VerificaExistenciaRegistros()
        {
            if (gridUsuarios.RowCount <= 0)
            {
                MostrarDialogoResultado(this.Text, "No hay registros para mostrar.", string.Empty, false);
                return false;
            }

            return true;
        }

        private void ActivaDesactivaRegistro()
        {
            if (!VerificaExistenciaRegistros())
                return;

            string accion;
            bool esActivo;

            if (_usuarioLocal.EsActivo)
            {
                _enumeradoAccion = EnumeradoAccion.Baja;
                accion = "dar de baja";
                esActivo = false;
            }
            else
            {
                accion = "reactivar";
                _enumeradoAccion = EnumeradoAccion.Reactivacion;
                esActivo = true;
            }

            bool respuesta = ConfirmarActivacionDesactivacion(accion);

            if (respuesta)
            {
                _usuarioLocal.EsActivo = esActivo;
                _catUsuariosController.ActivarDesactivarUsuario(_usuarioLocal);
            }
        }

        private void btnActDes_Click(object sender, EventArgs e)
        {
            ActivaDesactivaRegistro();
        }

        private void gridUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosDeGridAObjeto();
        }

        private void Nuevo()
        {
            _enumeradoAccion = EnumeradoAccion.Alta;

            Usuario usuarioNuevo = new Usuario();
            usuarioNuevo.IdUsuarioRegistra = _contextoAplicacion.Usuario.IdUsuario;

            frmAgregaEditaUsuario vistaEdicion = new frmAgregaEditaUsuario(_enumeradoAccion, this, usuarioNuevo);
            vistaEdicion.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void gridUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!_usuarioLocal.EsActivo)
            {
                string mensaje = string.Format("{0} {1} {2} {3}", "No se puede editar el registro de", _usuarioLocal.Nombre, _usuarioLocal.ApellidoPaterno, "porque está dado de baja. Si quiere hacer cambios tendrá que reactivar el registro, favor de verificar"); 
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }
                
            _enumeradoAccion = EnumeradoAccion.Edicion;

            frmAgregaEditaUsuario vistaEdicion = new frmAgregaEditaUsuario(_enumeradoAccion, this, _usuarioLocal);
            vistaEdicion.ShowDialog();

        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ObtenerUsuarios();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F2:
                    Nuevo();
                    break;

                case Keys.F3:
                    ObtenerUsuarios();
                    break;

                case Keys.F4:
                    Cerrar();
                    break;

                case Keys.F7:
                    ActivaDesactivaRegistro();
                    break;
            }

            return false;
        }
    }
}

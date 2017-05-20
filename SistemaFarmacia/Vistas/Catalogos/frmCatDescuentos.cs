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
    public partial class frmCatDescuentos : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private ToolTip _toolTipActivaDesactiva;
        private CatDescuentosController _catDescuentosController;
        private CatDescuentos _descuentoLocal;
        public frmCatDescuentos(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = _contextoAplicacion;
            _toolTipActivaDesactiva = new ToolTip();
            _catDescuentosController = new CatDescuentosController(this);
            _descuentoLocal = new CatDescuentos();

        }

        private void frmCatDescuentos_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipNuevo = new ToolTip();
            ToolTipNuevo.SetToolTip(btnNuevo, "Nuevo");

            ToolTip ToolTipRecargar = new ToolTip();
            ToolTipRecargar.SetToolTip(btnRecargar, "Recargar información");

            ToolTip ToolTipSalir = new ToolTip();
            ToolTipSalir.SetToolTip(btnCancelar, "Cerrar el catálogo");

            ConsultarDescuentos();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void ConsultarDescuentos()
        {
            _catDescuentosController.ConsultarDescuentos();
        }

        public void AsignarListaDescuentos(List<CatDescuentos> lista)
        {
            gridDescuentos.AutoGenerateColumns = false;
            gridDescuentos.DataSource = null;
            gridDescuentos.DataSource = lista;

            CargarDatosDeGridAObjeto();
        }

        private void CargarDatosDeGridAObjeto()
        {
            _descuentoLocal.IdDescuento = (int)gridDescuentos.SelectedRows[0].Cells["IdDescuento"].Value;
            _descuentoLocal.Porcentaje = (decimal)gridDescuentos.SelectedRows[0].Cells["Porcentaje"].Value;
            _descuentoLocal.Descripcion = gridDescuentos.SelectedRows[0].Cells["Descripcion"].Value.ToString();
            _descuentoLocal.EsActivo = (bool)gridDescuentos.SelectedRows[0].Cells["EsActivo"].Value;

            string mensajeToolTip = string.Empty;

            if (_descuentoLocal.EsActivo)
            {
                btnActDes.BackgroundImage = Resource.bloquear;
                mensajeToolTip = "Dar de baja el registro";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
            else
            {
                btnActDes.BackgroundImage = Resource.activar;
                mensajeToolTip = "Reactivar el registro";

                _toolTipActivaDesactiva.SetToolTip(btnActDes, mensajeToolTip);

            }
        }
        
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            ConsultarDescuentos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EnumeradoAccion enumeradoAccion = EnumeradoAccion.Alta;

            CatDescuentos descuentoNuevo = new CatDescuentos();

            frmAgregaEditaDescuentos vistaEdicion = new frmAgregaEditaDescuentos(enumeradoAccion, this, descuentoNuevo);
            vistaEdicion.ShowDialog();
        }

        private void gridDescuentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnumeradoAccion enumeradoAccion = EnumeradoAccion.Edicion;

            frmAgregaEditaDescuentos vistaEdicion = new frmAgregaEditaDescuentos(enumeradoAccion, this, _descuentoLocal);
            vistaEdicion.ShowDialog();
        }
    }
}

using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes;
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

namespace SistemaFarmacia.Vistas.Procesos
{
    public partial class frmAjustes : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private AjustesController _ajustesController;

        public frmAjustes(ContextoAplicacion contextoAplicacion, EnumeradoAccion accion, frmListadoAjustes vistaLlamada, AjustesProductosListado ajusteProductosListado)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _ajustesController = new AjustesController(this);
        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {
            CatTipoAjustes tipoAjustes = new CatTipoAjustes();

            tipoAjustes.IdTipoAjuste = 0;
            tipoAjustes.EsActivo = false;
            tipoAjustes.Descripcion = "";

            _ajustesController.ConsultarTiposAjustes(tipoAjustes);

        }

        public void LlenarComboAjustes(List<CatTipoAjustes> lista)
        {
            cmbTiposAjustes.Items.Clear();
            cmbTiposAjustes.DataSource = lista;
            cmbTiposAjustes.DisplayMember = "Descripcion";
            cmbTiposAjustes.ValueMember = "IdTipoAjuste";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

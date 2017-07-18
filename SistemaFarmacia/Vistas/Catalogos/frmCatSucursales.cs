using SistemaFarmacia.Controladores.Catalogos;
using SistemaFarmacia.Entidades.Contextos;
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
    public partial class frmCatSucursales : frmBase
    {
        private ContextoAplicacion _contextoAplicacion;
        private CatSucursalesController _catSucursalesController;
        public frmCatSucursales(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();

            _contextoAplicacion = contextoAplicacion;
            _catSucursalesController = new CatSucursalesController(this);

        }

        private void frmCatSucursales_Load(object sender, EventArgs e)
        {
            ToolTip ToolTipGuardar = new ToolTip();
            ToolTipGuardar.SetToolTip(btnGuardar, "Guardar");

            txtSucursal.Select();

            _catSucursalesController.ConsultarSucursales();

        }

        public void CargarDatos(List<CatSucursal> lista)
        {
            lblId.Text = lista[0].IdSucursalObjeto.ToString();
            txtSucursal.Text = lista[0].SucursalObjeto;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarInformacion();
        }

        private void GuardarInformacion()
        {
            if (!ConfirmarGuardado())
                return;

            CatSucursal sucursal = new CatSucursal();

            sucursal.IdSucursal = Convert.ToInt32(lblId.Text);
            sucursal.Sucursal = txtSucursal.Text.TrimEnd().TrimStart();
            sucursal.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

            _catSucursalesController.ActualizarSucursal(sucursal);

            _contextoAplicacion.Usuario.Sucursal = sucursal.Sucursal;
        }

        bool ConfirmarGuardado()
        {
            string mensaje = string.Empty;

            mensaje = "¿Seguro que desea guardar la información?";

            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta == DialogResult.Yes)
                return true;

            else
                return false;

        }

        private void txtSucursal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GuardarInformacion();
            }
        }
    }
}

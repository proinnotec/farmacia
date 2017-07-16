using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
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
        AutoCompleteStringCollection ResultadosBusqueda;
        public ContextoAplicacion _contextoAplicacion { get; set; }
        private AjustesController _ajustesController;
        frmListadoAjustes _vistaLlamada;

        public frmAjustes(ContextoAplicacion contextoAplicacion, EnumeradoAccion accion, frmListadoAjustes vistaLlamada, AjustesProductosListado ajusteProductosListado)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _ajustesController = new AjustesController(this);

            ResultadosBusqueda = new AutoCompleteStringCollection();
            txtBusqueda.AutoCompleteCustomSource = ResultadosBusqueda;
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.None;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
            _vistaLlamada = vistaLlamada;
        }

        private void frmAjustes_Load(object sender, EventArgs e)
        {
            CatTipoAjustes tipoAjustes = new CatTipoAjustes();

            tipoAjustes.IdTipoAjuste = 0;
            tipoAjustes.EsActivo = false;
            tipoAjustes.Descripcion = "";

            _ajustesController.ConsultarTiposAjustes(tipoAjustes);
            LlenarListaProductos();

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

        private void gpoBoxGenerales_Enter(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        public void LlenarListaProductos()
        {
        
            List<ProductosListado> listaProductos = _ajustesController.LlenarListaProductos();

            foreach (ProductosListado producto in listaProductos)
            {
                ResultadosBusqueda.Add(producto.DescripcionCompleta);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ltbResultados.BringToFront();
            ltbResultados.Items.Clear();
           if (txtBusqueda.Text.Length == 0)
            {
                EsconderResultados();
                return;
            }

            foreach (String s in txtBusqueda.AutoCompleteCustomSource)
            {
                if (!s.Contains(txtBusqueda.Text.ToUpper())) continue;

                ltbResultados.Items.Add(s);
                ltbResultados.Visible = true;
            }
        }

        private void EsconderResultados()
        {
            ltbResultados.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            decimal cantidad = nudCantidad.Value;
            int idproducto = int.Parse(txtIdProducto.Text);
            string motivo = richMotivo.Text;
            string mensaje = string.Empty;

            if (cantidad <= 0)
                mensaje = "La cantidad debe ser mayor a cero. \n";

            motivo = motivo.TrimEnd().TrimStart();

            if (string.IsNullOrEmpty(motivo))
                mensaje = mensaje + "Capture un motivo para el ajuste.";

            if (mensaje.Length > 0)
            {
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);
                return;
            }

            mensaje = "¿Confirma que desea guardar el ajuste?";
            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta != DialogResult.Yes)
                return;

            AjustesProductos ajuste = new AjustesProductos();

            ajuste.IdSucursal = _contextoAplicacion.Usuario.IdSucursal;
            ajuste.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

            AjustesProductosDetalles detalle = new AjustesProductosDetalles();
            detalle.TipoAjuste = (int)cmbTiposAjustes.SelectedValue;
            detalle.Descripcion = richMotivo.Text;
            detalle.Cantidad = nudCantidad.Value;
            detalle.IdProducto = idproducto;
            detalle.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

            ajuste.ListaAjustesProductosDetalles.Add(detalle);

            _ajustesController.GuardarAjuste(ajuste);
        }

        public void CargarDatos()
        {
            _vistaLlamada.CargarDatos();
        }
        public void Cerrar()
        {
            CargarDatos();
            this.Close();
            this.Dispose();
        }

        public void LimpiarCampos()
        {
            txtBusqueda.Text = "";
            txtClaveProducto.Text = "";
            txtIdProducto.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            nudCantidad.Value = 0;
            richMotivo.Text = "";
        }

        private void SeleccionarItemLista()
        {
            int IdxClaveProducto = 0;
            int IdxDescripcion = 0;
            int IdxIdProducto = 0;

            String Producto = ltbResultados.Items[ltbResultados.SelectedIndex].ToString();

            IdxClaveProducto = Producto.IndexOf(" CV: ");
            IdxDescripcion = Producto.IndexOf(" DSC: ");
            IdxIdProducto = Producto.IndexOf(" ID: ");

            if (ltbResultados.SelectedItem == null) return;

            txtCodigo.Text = Producto.Substring(4, IdxClaveProducto - 4);
            txtClaveProducto.Text = Producto.Substring(IdxClaveProducto + 5, IdxDescripcion - (IdxClaveProducto + 5));
            txtDescripcion.Text = Producto.Substring(IdxDescripcion + 6, IdxIdProducto - (IdxDescripcion + 6));
            txtIdProducto.Text = Producto.Substring(IdxIdProducto + 5, Producto.Length - (IdxIdProducto + 5));

            txtBusqueda.Text = Producto.Substring(0, IdxIdProducto);
            EsconderResultados();
        }


        private void txtBusqueda_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Down:
                    if (ltbResultados.Items.Count > 0)
                    {
                        ltbResultados.Select();
                        ltbResultados.SetSelected(0, true);
                    }

                    break;
            }
        }

        private void ltbResultados_Click(object sender, EventArgs e)
        {
            SeleccionarItemLista();
        }

        private void ltbResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                SeleccionarItemLista();
            }

            if ((int)e.KeyChar == (int)Keys.Back)
            {
                txtBusqueda.Select();
            }
        }
    }
}

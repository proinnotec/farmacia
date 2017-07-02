using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacia.Vistas.Base;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Controladores.Ventas;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using SistemaFarmacia.Entidades.Negocio;

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmVenta : frmBase
    {
        AutoCompleteStringCollection _resultadosBusqueda;
        ComplementoVenta _complementoVenta;
        frmVentaController _frmVentaController;

        public frmVenta(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _frmVentaController = new frmVentaController(this);
            _resultadosBusqueda = new AutoCompleteStringCollection();
            LlenarListaProductos();
            _complementoVenta = _frmVentaController.ObtenerComplementoVenta();
        }

        public void LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _frmVentaController.LlenarListaProductos();

            foreach (ProductosListado producto in listaProductos)
            {
                _resultadosBusqueda.Add(producto.DescripcionCompleta);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmDialogoProductoVenta dialogo = new frmDialogoProductoVenta(_resultadosBusqueda, _complementoVenta);
            DialogResult resultado = dialogo.ShowDialog();

            if (resultado == DialogResult.Yes)
            {

            }

        }
    }
}

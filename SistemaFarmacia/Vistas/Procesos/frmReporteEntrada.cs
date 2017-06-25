using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Reportes;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Data;


namespace SistemaFarmacia.Vistas.Procesos
{
    public partial class frmReporteEntrada : frmBase
    {
        List<EntradaProductoListado> _lista;

        public frmReporteEntrada(List<EntradaProductoListado> lista)
        {
            InitializeComponent();

            _lista = lista;
        }

        private void frmReporteEntrada_Load(object sender, EventArgs e)
        {
            rptEntradasProductos rptEntradaImpresion = new rptEntradasProductos();
            rptEntradaImpresion.SetDataSource(_lista);

            rptEntradas.ReportSource = rptEntradaImpresion;
            rptEntradas.Refresh();
        }
    }
}

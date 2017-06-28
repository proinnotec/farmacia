using SistemaFarmacia.Entidades.Contextos;
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
        ContextoAplicacion _contexto;

        public frmReporteEntrada(List<EntradaProductoListado> lista, ContextoAplicacion contexto)
        {
            InitializeComponent();

            _lista = lista;
            _contexto = contexto;
        }

        private void frmReporteEntrada_Load(object sender, EventArgs e)
        {
            rptEntradasProductos rptEntradaImpresion = new rptEntradasProductos();

            rptEntradaImpresion.SetDataSource(_lista);
            rptEntradaImpresion.SetParameterValue("Empresa", _contexto.Usuario.Sucursal);
            rptEntradaImpresion.SetParameterValue("UsuarioEmite", _contexto.Usuario.NombreUsuario);

            rptEntradas.ReportSource = rptEntradaImpresion;
            rptEntradas.Refresh();
        }
    }
}

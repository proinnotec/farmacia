using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Reportes;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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
            TopMost = true;
        }

        private void frmReporteEntrada_Load(object sender, EventArgs e)
        {
            frmTipoRepEntrada tipoReporte = new frmTipoRepEntrada(_contexto);

            DialogResult respuesta = tipoReporte.ShowDialog();

            if (respuesta != DialogResult.Yes)
            {
                return;
            }                

            TipoReporteEntrada tipoReporteEnum = tipoReporte.TipoReporte;

            switch(tipoReporteEnum)
            {
                case TipoReporteEntrada.Basico:
                    rptEntradaProductoBasica rptEntradaImpresionBasico = new rptEntradaProductoBasica();

                    rptEntradaImpresionBasico.SetDataSource(_lista);
                    rptEntradaImpresionBasico.SetParameterValue("Empresa", _contexto.Usuario.Sucursal);

                    rptEntradas.ReportSource = rptEntradaImpresionBasico;

                    break;

                case TipoReporteEntrada.Detallado:
                    rptEntradasProductos rptEntradaImpresion = new rptEntradasProductos();

                    rptEntradaImpresion.SetDataSource(_lista);
                    rptEntradaImpresion.SetParameterValue("Empresa", _contexto.Usuario.Sucursal);
                    rptEntradaImpresion.SetParameterValue("UsuarioEmite", _contexto.Usuario.NombreUsuario);

                    rptEntradas.ReportSource = rptEntradaImpresion;

                    break;
            }

           
            rptEntradas.Refresh();
        }

        private void Cerrar()
        {
            Close();
            Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F4:
                    Cerrar();
                    break;
            }

            return false;
        }
    }
}

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
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Controladores;

namespace SistemaFarmacia.Vistas.Catalogos
{
    public partial class frmCatProductos : frmBase
    {
        public ContextoAplicacion _contextoAplicacion { get; set; }

        public frmCatProductos(ContextoAplicacion contextoAplicacion)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;            
        }
    }
}

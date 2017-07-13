using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class VentaDetalleImpuesto
    {
        public Int64 Consecutivo { get; set; }
        public int IdProducto { get; set; }
        public Int16 IdImpuesto { get; set; }
        public decimal Porcentaje { get; set; }
    }
}

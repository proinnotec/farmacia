using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class VentaImportes
    {
        public string Impuesto { get; set; }
        public Int16 IdImpuesto { get; set; }
        public decimal Total { get; set; }
    }
}

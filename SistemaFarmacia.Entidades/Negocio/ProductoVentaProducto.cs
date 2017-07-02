using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class ProductoVentaProducto
    {
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public bool AplicaDescuentoCatalogo { get; set; }
    }
}

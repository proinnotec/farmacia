using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class ComplementoVenta
    {
        public List<ProductoVentaImpuesto> ListaProductoVentaImpuesto { get; set; }
        public List<CatProducto> ListaProductos { get; set; }
    }
}

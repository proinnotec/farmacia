using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Entidades.Contextos
{
    public class ContextoVenta
    {
        public CatProducto Producto { get; set; }
        public CatImpuestos Impuesto { get; set; }
        public decimal Cantidad;
    }
}

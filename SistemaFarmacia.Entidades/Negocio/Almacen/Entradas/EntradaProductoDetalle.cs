using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Entradas
{
    public class EntradaProductoDetalle : ClaseBase
    {
        public int IdEntradaProductoDetalle { get; set; }
        public int IdEntradaProducto { get; set; }
        public decimal Cantidad { get; set; }
        public CatProducto Producto { get; set; }
        public decimal Precio { get; set; }

    }
}

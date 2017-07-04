using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Reportes
{
    public class Inventario: ClaseBase
    {
        public int IdFamiliaProducto { get; set; }
        public string Familia { get; set; }
        public int Prioridad { get; set; }
        public int IdProducto { get; set; }
        public string ClaveProducto { get; set; }
        public string Producto { get; set; }
        public decimal Existencia { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal UPrecioEntrada { get; set; }
    }
}

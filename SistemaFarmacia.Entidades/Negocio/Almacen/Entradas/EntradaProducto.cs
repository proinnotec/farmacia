using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Entradas
{
    public class EntradaProducto : ClaseBase
    {
        public int IdEntradaProducto { get; set; }
        public CatProveedor Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public List<EntradaProductoDetalle> EntradaDetalles { get; set; }
        
        public EntradaProducto()
        {
            Proveedor = new CatProveedor();
            EntradaDetalles = new List<EntradaProductoDetalle>();
        }
    }
}

using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class VentaDetalle
    {
        public Int64 IdVentaDetalle { get; set; }
        public int IdProducto { get; set; }
        public string ClaveProducto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public decimal Total { get; set; }
        public Int16 CantidadPromocion { get; set; }
        public decimal PrecioPromocion { get; set; }

        public decimal Existencia { get; set; }
    }
}

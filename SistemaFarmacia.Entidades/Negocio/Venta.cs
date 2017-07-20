using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class Venta : ClaseBase
    {
        public Int64 IdVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public decimal Descuento { get; set; }
        public int IdDescuento { get; set; }
        public decimal Porcentaje { get; set; }
        public Int64 Consecutivo { get; set; } 
        public List<VentaDetalle> DetalleVenta { get; set; }
        public List<VentaDetalleImpuesto> DetalleVentaImpuesto { get; set; }
        public string NombreVendedor { get; set; }
        
    }
}

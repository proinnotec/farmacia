using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Contextos
{
    public class ContextoTicket
    {
        public Int64 Consecutivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string ClaveProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Pago { get; set; }

    }
}

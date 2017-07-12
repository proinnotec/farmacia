using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Ventas
{
    public class CorteCajaReporte: ClaseBase
    {
        public Int64 IdVenta { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public int IdVendedor { get; set; }
        public string Vendedor { get; set; }
        public int IdCorteCaja { get; set;}
        public DateTime FechaCorte { get; set; }
        public int IdVendedorCorte { get; set; }
        public string VendedorCorte { get; set; }
        public Int64 Ticket { get; set; }

    }
}

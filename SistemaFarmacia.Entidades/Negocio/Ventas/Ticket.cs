using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Ventas
{
    public class Ticket: ClaseBase
    {
        public Int64 IdVenta { get; set; }
        public Int64 NoTicket { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Total { get; set; }
        public int IdUsuarioTicket { get; set; }
        public string VendedorTicket { get; set; }
        public int CorteCaja { get; set; }
    }
}

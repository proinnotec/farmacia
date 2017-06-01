using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Entradas
{
    public class EntradaProducto:ClaseBase
    {
        public int IdEntradaProducto { get; set; }
        public int IdProveedor { get; set; }
        public DateTime FechaAplica { get; set; }
        
    }
}

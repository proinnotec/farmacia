using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Ventas
{
    public class CorteCaja: ClaseBase
    {
        public int IdCorteCaja { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreUsuario { get; set; }
        public bool CorteAbierto { get; set; }

    }
}

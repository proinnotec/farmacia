using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class ClaseBase
    {
        public int IdUsuario { get; set; }
        public bool EsActivo { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}

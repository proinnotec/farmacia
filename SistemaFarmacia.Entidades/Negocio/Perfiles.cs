using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class Perfiles : ClaseBase
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

    }
}

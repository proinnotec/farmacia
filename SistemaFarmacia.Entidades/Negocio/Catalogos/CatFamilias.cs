using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class CatFamilias : ClaseBase
    {
        public int IdFamiliaProducto { get; set; }
        public string Descripcion { get; set; }
        public int Prioridad { get; set; }
    }
}

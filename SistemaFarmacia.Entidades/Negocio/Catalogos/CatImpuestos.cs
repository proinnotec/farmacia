using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class CatImpuestos : ClaseBase
    {
        public Int16 IdImpuesto { get; set; }
        public decimal Porcentaje { get; set; }
        public string Descripcion { get; set; }

    }
}

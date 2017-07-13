using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio
{
    public class DescuentoVenta
    {
        public CatDescuentos Descuento { get; set; }
        public ConfiguracionDescuento ConfiguracionDescuento { get; set; }
    }
}

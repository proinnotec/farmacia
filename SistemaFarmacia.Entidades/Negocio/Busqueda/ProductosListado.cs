using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Busqueda
{
    public class ProductosListado : ClaseBase
    {
        public int IdProducto { get; set; }
        public string ClaveProducto { get; set; }
        public string Descripcion { get; set; }
        public string CodigoBarras { get; set; }
        public string DescripcionCompleta { get; set; }
    }
}

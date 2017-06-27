using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes
{
    public class AjustesProductosListado
    {
        public int IdAjusteProducto { get; set; }
        public int IdSucursal { get; set; }
        public DateTime Fecha { get; set; }
        public int IdAjusteProductoDetalle { get; set; }
        public int IdTipoAjuste { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public int IdProducto { get; set; }
        public string ClaveProducto { get; set; }
        public decimal Precio { get; set; }
        public string DescripcionProducto { get; set; }
    }
}

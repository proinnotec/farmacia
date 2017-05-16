using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes
{
    public class AjustesProductosDetalles : ClaseBase
    {
        public int IdAjusteProductoDetalle { get; set; }
        public AjustesProductos AjusteProducto { get; set; }
        public CatTipoAjustes TipoAjuste { get; set; }
        public string Descripcion { get; set; }
        public Decimal Cantidad { get; set; }
        public int ClaveProducto { get; set; } //Falta generar la entidad producto
        public Decimal Precio { get; set; }
        public Usuario Usuario { get; set; }

        public AjustesProductosDetalles()
        {
            AjusteProducto = new AjustesProductos();
            TipoAjuste = new CatTipoAjustes();
            Usuario = new Usuario();

        }
    }
}

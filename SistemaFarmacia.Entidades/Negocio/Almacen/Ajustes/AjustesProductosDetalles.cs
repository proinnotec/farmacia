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
        public int TipoAjuste { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
        public Usuario Usuario { get; set; }

        public AjustesProductosDetalles()
        {
            AjusteProducto = new AjustesProductos();
            Usuario = new Usuario();

        }
    }
}

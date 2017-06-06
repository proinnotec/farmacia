using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Entradas
{
    public class EntradaProductoListado: ClaseBase
    {
        public int IdEntradaProducto { get; set; }
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public int IdProducto { get; set; }
        public string ClaveProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Reportes
{
    public class KardexEntidad: ClaseBase
    {
        public string TipoMovimiento { get; set; }
        public Int64 IdRegistro { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuarioKardex { get; set; }
        public string UsuarioKardex { get; set; }
        public Int64 IdRegistroDetalle { get; set; }
        public string DescripcionRegistro { get; set; }
        public decimal Cantidad { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string ClaveProducto { get; set; }
        public int IdFamiliaProducto { get; set; }
        public string Familia { get; set; }
        public int Prioridad { get; set; }
        public decimal PrecioRegistro { get; set; }
        public decimal PrecioVenta { get; set; }
        public int IdTipoAjuste { get; set; }
        public string TipoAjuste { get; set; }
    }
}

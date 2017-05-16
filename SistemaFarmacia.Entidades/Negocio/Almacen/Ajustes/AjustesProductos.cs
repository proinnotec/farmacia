using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;

namespace SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes
{
    public class AjustesProductos:ClaseBase
    {
        public int IdAjusteProducto { get; set; }
        public CatSucursal Sucursal { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Usuario { get; set; }
        public List<AjustesProductosDetalles> ListaAjustesProductosDetalles { get; set; }
        
        public AjustesProductos()
        {
            Sucursal = new CatSucursal();
            Usuario = new Usuario();
            ListaAjustesProductosDetalles = new List<AjustesProductosDetalles>();

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class CatProducto : ClaseBase
    {
        public string ClaveProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public bool AplicaDescuentoCatalogo { get; set; }
        public int IdFamiliaProducto { get; set; }
        public List<CodigoBarraProducto> ListaCodigoBarra { get; set; }
        public int IdProducto { get; set; }
        public List<CatImpuestos> ListaImpuestos { get; set; }
        public bool AplicaPromocion { get; set; }
        public Int16 CantidadPromocion { get; set; }
        public decimal PrecioPromocion { get; set; }
    }
}

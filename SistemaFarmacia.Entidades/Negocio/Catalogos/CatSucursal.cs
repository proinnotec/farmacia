using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class CatSucursal: ClaseBase
    {
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public Usuario Usuario { get; set; }

        public CatSucursal()
        {
            Usuario = new Usuario();
        }
    }
}

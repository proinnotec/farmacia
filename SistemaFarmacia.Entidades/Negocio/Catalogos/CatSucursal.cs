using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class CatSucursal: ClaseBase
    {
        public int IdSucursalObjeto { get; set; }
        public string SucursalObjeto { get; set; }
        public Usuario Usuario { get; set; }

        public CatSucursal()
        {
            Usuario = new Usuario();
        }
    }
}

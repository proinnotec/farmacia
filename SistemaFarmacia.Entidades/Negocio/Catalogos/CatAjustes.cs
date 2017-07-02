using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Entidades.Negocio.Catalogos
{
    public class CatAjustes : ClaseBase
    {
        public int IdTipoAjuste { get; set; }
        public string Descripcion { get; set; }
        public bool TipoAjuste { get; set; }
        public Usuario Usuario { get; set; }

        public CatAjustes()
        {
            Usuario = new Usuario();
        }
    }
}

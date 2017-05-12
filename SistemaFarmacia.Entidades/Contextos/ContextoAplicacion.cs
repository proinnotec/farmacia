using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaFarmacia.Entidades.Negocio;

namespace SistemaFarmacia.Entidades.Contextos
{
    public class ContextoAplicacion
    {
        public Usuario Usuario { get; set; }

        public ContextoAplicacion()
        {
            Usuario = new Usuario();
        }
    }
}

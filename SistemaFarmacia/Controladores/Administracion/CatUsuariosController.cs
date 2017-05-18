using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Servicios.Negocio.Administracion;
using SistemaFarmacia.Vistas.Administracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Administracion
{
    public class CatUsuariosController : BaseController
    {
        private frmCatUsuarios _vista;
        ServicioCatalogoUsuarios _servicioCatalogoUsuarios;

        public CatUsuariosController(frmCatUsuarios vista)
        {
            _vista = vista;
            _servicioCatalogoUsuarios = new ServicioCatalogoUsuarios(BaseDeDatosTienda);

        }

        public void ObtenerUsuarios()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoUsuarios.ObtenerUsuarios();

            if(resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la información de los usuarios, no se pueden cargar los datos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
            }

            List<Usuario> lista = _servicioCatalogoUsuarios.ListaUsuarios;

            _vista.AsigarListaUsuarios(lista);
        }
    }
}

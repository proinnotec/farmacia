//using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Vistas.Operaciones;
//using ProInnotec.Core.Entidades.ManejoExcepciones;
//using System.Collections.Generic;
//using System.Linq;

namespace SistemaFarmacia.Controladores
{
    public class frmPrincipalController : BaseController
    {
        private frmPrincipal _vista;

        //ServicioDatosMenu servicioDatosMenu;

        public string Servidor { get; set; }

        public string BaseDatos { get; set; }

        public frmPrincipalController(frmPrincipal vista)
        {
            _vista = vista;

            //servicioDatosMenu = new ServicioDatosMenu(BaseDeDatosTienda);

            Servidor = InstanciaServidor;

            BaseDatos = NombreBaseDatos;
        }

        public void CargarMenu(int idUsuario)
        {
            //ExcepcionPersonalizada excepcion = servicioDatosMenu.ConsultarMenu(idUsuario);

            //if (excepcion == null)
            //{
            //    List<ElementoMenu> _listaMenu = new List<ElementoMenu>();               

            //    _listaMenu = servicioDatosMenu.ListaMenu;

            //    bool existePadre = _listaMenu.Exists(elemento => elemento.IdPadre == 0);

            //    if (existePadre == true)
            //    {
            //        int idMenu = _listaMenu.First(elemento => elemento.IdPadre == 0).IdMenu;

            //        _vista.CrearMenu(_listaMenu, idMenu);

            //    }
            //    else
            //    {
            //        string mensaje = "Usted no tiene un perfil asignado.";

            //        _vista.MostrarDialogoResultado(_vista.Text, mensaje, string.Empty, false);
            //    }

            //}
            //else
            //{
            //    _vista.MostrarDialogoResultado(_vista.Text, excepcion.Message, excepcion.InnerException.ToString(), false);
            //}
        }

       
    }
}
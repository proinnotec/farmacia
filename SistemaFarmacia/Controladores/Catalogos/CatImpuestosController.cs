using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Catalogos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Controladores.Catalogos
{
    class CatImpuestosController : BaseController
    {
        private frmCatImpuestos _vista;
        ServicioCatalogoImpuestos _servicioCatalogoImpuestos;

        public CatImpuestosController(frmCatImpuestos vista)
        {
            _servicioCatalogoImpuestos = new ServicioCatalogoImpuestos(BaseDeDatosTienda);
            _vista = vista;
        }

        public void ConsultarImpuestos()
        {
            ExcepcionPersonalizada resultado = _servicioCatalogoImpuestos.ConsultarImpuestos();

            if (resultado != null)
            {
                string mensaje = "Hubo un error al intentar obtener la información de los impuestos, no se pueden cargar los datos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<CatImpuestos> lista = _servicioCatalogoImpuestos.ListaCatImpuestos;

            _vista.AsignarListaImpuestos(lista);
        }

        public void ActivarDesactivarImpuesto(CatImpuestos impuesto)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioCatalogoImpuestos.ActivarDesactivarImpuesto(impuesto);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar actualizar la información de los impuestos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            mensaje = "Se ha guardado correctamente la información del usuario.";
            _vista.MostrarDialogoResultado(_vista.Text, mensaje, "", true);

            ConsultarImpuestos();
        }
    }
}

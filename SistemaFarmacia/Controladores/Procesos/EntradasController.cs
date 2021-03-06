﻿using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Servicios.Negocio.Almacen;
using SistemaFarmacia.Vistas.Procesos;
using System.Collections.Generic;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class EntradasController:BaseController
    {
        private ServicioEntradas _servicioEntradas;
        private frmEntradas _vista;

        public EntradasController(frmEntradas vista)
        {
            _servicioEntradas = new ServicioEntradas(BaseDeDatosTienda);
            _vista = vista;
        }

        public void ConsultaEntradasCabecera(int anio)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.ConsultarEntradasCabecera(anio);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de las entradas.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<EntradaProductoListado> ListaEntradas = _servicioEntradas.ListaEntradasProductos;
            _vista.AsignarListaEntradas(ListaEntradas);
            
        }

        public void ConsultaReporte(int idEntrada)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.ConsultarEntradasReporte(idEntrada);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de las entradas.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<EntradaProductoListado> listaEntradas = _servicioEntradas.ListaEntradasProductos;

            _vista.LlenaInformacionReporte(listaEntradas);
        }
    }
}

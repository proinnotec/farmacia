﻿using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Servicios.Negocio.Almacen;
using SistemaFarmacia.Vistas.Procesos;
using System.Collections.Generic;
using SistemaFarmacia.Servicios.Negocio.Catalogos;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Controladores.Procesos
{
    public class EntradasEditaController: BaseController
    {
        private ServicioEntradas _servicioEntradas;
        private ServicioCatalogoProductos _servicioCatalogoProductos;
        private frmEditaEntradas _vista;
        public List<CatProducto> ListaProductos { get; private set; }

        public EntradasEditaController(frmEditaEntradas vista)
        {
            _servicioEntradas = new ServicioEntradas(BaseDeDatosTienda);
            _servicioCatalogoProductos = new ServicioCatalogoProductos(BaseDeDatosTienda);
            _vista = vista;
        }

        public void ConsultaEntradasDetalles(int idEntrada)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioEntradas.ConsultarDetalles(idEntrada);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de los detalles de las entradas.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            List<EntradaProductoDetalle> listaEntradaDetalles = _servicioEntradas.ListaEntradasDetalles;
            _vista.AsignarListaDetalles(listaEntradaDetalles);

        }

        public void ConsultaProductosLista(int idProducto)
        {
            string mensaje = string.Empty;
            ExcepcionPersonalizada resultado = _servicioCatalogoProductos.ConsultarProductosActivos(idProducto);

            if (resultado != null)
            {
                mensaje = "Hubo un error al intentar consultar la información de los productos.";
                _vista.MostrarDialogoResultado(_vista.Text, mensaje, resultado.ToString(), false);
                return;
            }

            ListaProductos = _servicioCatalogoProductos.ListaProductos;

            if(idProducto == 0)
                _vista.LlenarComboProductos(ListaProductos);
        }
        
    }
}

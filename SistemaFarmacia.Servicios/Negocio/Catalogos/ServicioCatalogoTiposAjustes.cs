using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Servicios.Negocio.Catalogos
{
    public class ServicioCatalogoTiposAjustes
    {
        private IBaseDeDatos _baseDatos;


        public ServicioCatalogoTiposAjustes(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }
    }
}

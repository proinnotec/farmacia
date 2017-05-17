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

        public List<CatTipoAjustes> ListaTipoAjustes { get; private set; }

        public ServicioCatalogoTiposAjustes(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;

        }

        public ExcepcionPersonalizada ConsultarTiposAjustes(CatTipoAjustes catalogoAjustes)
        {
            IDbConnection conexion = null;

            ListaTipoAjustes = new List<CatTipoAjustes>();

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatTipoAjustes", conexion);

                if ( catalogoAjustes.EsActivo )
                {
                    IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@EsActivo", catalogoAjustes.EsActivo, ParameterDirection.Input);
                }

                if ( catalogoAjustes.IdTipoAjuste > 0)
                {
                    IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@IdTipoAjuste", catalogoAjustes.EsActivo, ParameterDirection.Input);
                }

                catalogoAjustes.Descripcion = catalogoAjustes.Descripcion.TrimEnd().TrimStart();

                if ( catalogoAjustes.Descripcion.Length > 0)
                {
                    IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@IdTipoAjuste", catalogoAjustes.EsActivo, ParameterDirection.Input);
                }

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CatTipoAjustes catTipoAjustes = new CatTipoAjustes();

                    catTipoAjustes.IdTipoAjuste = (int)lector["IdTipoAjuste"];
                    catTipoAjustes.Descripcion = lector["Descripcion"].ToString();
                    catTipoAjustes.IdUsuario = (int)lector["IdUsuario"];
                    catTipoAjustes.EsActivo = (bool)lector["EsActivo"];

                    ListaTipoAjustes.Add(catTipoAjustes);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de los elementos del catálogo de tipos de ajustes.", excepcionCapturada);
                return excepcion;

            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }

        }
    }
}

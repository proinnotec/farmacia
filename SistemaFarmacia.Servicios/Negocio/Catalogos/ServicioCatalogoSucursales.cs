using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Catalogos
{
    public class ServicioCatalogoSucursales
    {
        private IBaseDeDatos _baseDatos;
        public List<CatSucursal> ListaSucursales { get; set; }

        public ServicioCatalogoSucursales(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarSucursales()
        {
            ListaSucursales = new List<CatSucursal>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatSucursal", conexion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CatSucursal sucursal = new CatSucursal();

                    sucursal.IdSucursalObjeto = (int)lector["IdSucursal"];
                    sucursal.SucursalObjeto = lector["Sucursal"].ToString();

                    ListaSucursales.Add(sucursal);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de las sucursales.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
                    
            }
        }
    }
}

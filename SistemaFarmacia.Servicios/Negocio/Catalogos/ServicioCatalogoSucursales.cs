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

        public ExcepcionPersonalizada ActualizarSucursal(CatSucursal sucursal)
        {
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatSucursal", conexion);

                IDataParameter parametroIdSucursal = _baseDatos.CrearParametro("@IdSucursal", sucursal.IdSucursal, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdSucursal);
                
                IDataParameter parametroSucursal = _baseDatos.CrearParametro("@Sucursal", sucursal.Sucursal, ParameterDirection.Input);
                comando.Parameters.Add(parametroSucursal);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", sucursal.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spU_CatSucursal).");
                }

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar el cambio en el catálogo de sucursales.", excepcionCapturada);
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

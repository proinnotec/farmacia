using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Servicios.Negocio.Catalogos
{
    public class ServicioCatalogoFamilias
    {
        private IBaseDeDatos _baseDatos;

        public List<CatFamilias> ListaFamilias { get; private set; }

        public ServicioCatalogoFamilias(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarFamilias()
        {
            ListaFamilias = new List<CatFamilias>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatFamiliasProductos", conexion);

                IDataReader Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    CatFamilias familia = new CatFamilias();

                    familia.IdFamiliaProducto = (int)Lector["IdFamiliaProducto"];
                    familia.Descripcion = Lector["Descripcion"].ToString();

                    ListaFamilias.Add(familia);
                }

                Lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de las familias de productos.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }

        }

        public ExcepcionPersonalizada EliminarFamilia(CatFamilias familia)
        {
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spD_CatFamiliasProductos", conexion);

                IDataParameter parametroIdFamiliaProducto = _baseDatos.CrearParametro("@IdFamiliaProducto", familia.IdFamiliaProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdFamiliaProducto);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", familia.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spD_CatFamiliasProductos).");
                }

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible eliminar la familia.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada EditarFamilia(CatFamilias familia)
        {
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatFamiliasProductos", conexion);

                IDataParameter parametroIdFamiliaProducto = _baseDatos.CrearParametro("@IdFamiliaProducto", familia.IdFamiliaProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdFamiliaProducto);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", familia.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", familia.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spU_CatFamiliasProductos).");
                }

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible editar la familia.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada GuardarFamilia(CatFamilias familia)
        {
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_CatFamiliasProductos", conexion);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", familia.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", familia.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spI_CatFamiliasProductos).");
                }

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar la familia.", excepcionCapturada);
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

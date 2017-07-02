using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using SistemaFarmacia.Entidades.Negocio.Catalogos;

namespace SistemaFarmacia.Servicios.Negocio.Catalogos
{
    public class ServicioCatalogoAjustes
    {
        private IBaseDeDatos _baseDatos;
        public List<CatAjustes> ListaAjustes { get; private set; }

        public ServicioCatalogoAjustes(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarAjustes()
        {
            ListaAjustes = new List<CatAjustes>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatTipoAjustes", conexion);

                IDataReader Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    CatAjustes ajuste = new CatAjustes();

                    ajuste.IdTipoAjuste = (int)Lector["IdTipoAjuste"];
                    ajuste.Descripcion = Lector["Descripcion"].ToString();
                    ajuste.TipoAjuste = (bool)Lector["TipoAjuste"];
                    ajuste.EsActivo = (bool)Lector["EsActivo"];

                    ListaAjustes.Add(ajuste);
                }

                Lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de los tipos de ajuste.", excepcionCapturada);
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

        public ExcepcionPersonalizada EliminarAjuste(CatAjustes ajuste)
        {
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatAjustesActivarDesactivar", conexion);

                IDataParameter parametroIdTipoAjuste = _baseDatos.CrearParametro("@IdTipoAjuste", ajuste.IdTipoAjuste, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdTipoAjuste);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", ajuste.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroActivo = _baseDatos.CrearParametro("@EsActivo", ajuste.EsActivo, ParameterDirection.Input);
                comando.Parameters.Add(parametroActivo);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_CatAjustesActivarDesactivar).");

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible eliminar el tipo de ajuste.", excepcionCapturada);
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

        public ExcepcionPersonalizada EditarAjuste(CatAjustes ajuste)
        {
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatTipoAjustes", conexion);

                IDataParameter parametroIdTipoAjuste = _baseDatos.CrearParametro("@IdTipoAjuste", ajuste.IdTipoAjuste, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdTipoAjuste);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", ajuste.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", ajuste.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);
                
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spU_CatTipoAjustes).");
                }

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible editar el tipo de ajuste.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada GuardarAjuste(CatAjustes ajuste)
        {
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_CatTipoAjustes", conexion);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", ajuste.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroTipoAjuste = _baseDatos.CrearParametro("@TipoAjuste", ajuste.TipoAjuste, ParameterDirection.Input);
                comando.Parameters.Add(parametroTipoAjuste);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", ajuste.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);
                
                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spI_CatTipoAjustes).");
                }

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar el tipo de ajuste.", excepcionCapturada);
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

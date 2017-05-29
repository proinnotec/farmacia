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
    public class ServicioCatalogoImpuestos
    {
        private IBaseDeDatos _baseDatos;
        public List<CatImpuestos> ListaCatImpuestos { get; private set; }

        public ServicioCatalogoImpuestos(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarImpuestos()
        {
            ListaCatImpuestos = new List<CatImpuestos>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatImpuestos", conexion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CatImpuestos impuesto = new CatImpuestos();

                    impuesto.IdImpuesto = (Int16)lector["IdImpuesto"];
                    impuesto.Porcentaje = (decimal)lector["Porcentaje"];
                    impuesto.Descripcion = lector["Descripcion"].ToString();
                    impuesto.EsActivo = (bool)lector["EsActivo"];

                    ListaCatImpuestos.Add(impuesto);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de impuestos.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();

                conexion.Dispose();
            }
        }


        public ExcepcionPersonalizada GuardarImpuesto(CatImpuestos impuesto)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_CatImpuestos", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroPorcentaje = _baseDatos.CrearParametro("@Porcentaje", impuesto.Porcentaje, ParameterDirection.Input);
                comando.Parameters.Add(parametroPorcentaje);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", impuesto.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", impuesto.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spI_CatImpuestos).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar el impuesto.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada ActualizarImpuesto(CatImpuestos impuesto)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatImpuestos", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdImpuesto = _baseDatos.CrearParametro("@IdImpuesto", impuesto.IdImpuesto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdImpuesto);

                IDataParameter parametroPorcentaje = _baseDatos.CrearParametro("@Porcentaje", impuesto.Porcentaje, ParameterDirection.Input);
                comando.Parameters.Add(parametroPorcentaje);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", impuesto.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", impuesto.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_CatImpuestos).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible actualizar el impuesto.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada ActivarDesactivarImpuesto(CatImpuestos impuesto)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatImpuestosActivarDesactivar", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdImpuesto = _baseDatos.CrearParametro("@IdImpuesto", impuesto.IdImpuesto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdImpuesto);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", impuesto.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@EsActivo", impuesto.EsActivo, ParameterDirection.Input);
                comando.Parameters.Add(parametroEsActivo);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                    throw new Exception("No se afectaron filas (spU_CatImpuestosActivarDesactivar).");

                transaccion.Commit();
                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue realizar la operación del impuesto.", excepcionCapturada);

                if (transaccion != null)
                    transaccion.Rollback();

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

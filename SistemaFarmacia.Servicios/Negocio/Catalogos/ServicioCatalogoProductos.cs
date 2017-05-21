using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using System.Data;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Utilerias;


namespace SistemaFarmacia.Servicios.Negocio.Catalogos
{
    public class ServicioCatalogoProductos
    {
        private IBaseDeDatos _baseDatos;
        public List<CatProducto> ListaProductos { get; private set; }
        public List<CodigoBarraProducto> ListaCodigoBarra { get; private set; }

        public ServicioCatalogoProductos(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada EditarProducto(CatProducto producto)
        {
            IDbConnection conexion = null;
            Serializar serializar = new Serializar();
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                string codigosDeBarra = serializar.XmlSerialize(producto.ListaCodigoBarra);

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatProductos", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroClaveProducto = _baseDatos.CrearParametro("@ClaveProducto", producto.ClaveProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroClaveProducto);

                IDataParameter parametroIdFamiliaProducto = _baseDatos.CrearParametro("@IdFamiliaProducto", producto.IdFamiliaProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdFamiliaProducto);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", producto.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroPrecio = _baseDatos.CrearParametro("@Precio", producto.Precio, ParameterDirection.Input);
                comando.Parameters.Add(parametroPrecio);

                IDataParameter parametroAplicaDescuentoCatalogo = _baseDatos.CrearParametro("@AplicaDescuentoCatalogo", producto.AplicaDescuentoCatalogo, ParameterDirection.Input);
                comando.Parameters.Add(parametroAplicaDescuentoCatalogo);

                IDataParameter parametroAplicaIdUsuario = _baseDatos.CrearParametro("@IdUsuario", producto.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroAplicaIdUsuario);

                IDataParameter parametroXmlCodigos = _baseDatos.CrearParametro("@XmlCodigos", codigosDeBarra, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlCodigos);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spU_CatProductos).");
                }

                transaccion.Commit();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible editar el producto.", excepcionCapturada);

                if (transaccion != null)
                {
                    transaccion.Rollback();
                }

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada GuardarProducto(CatProducto producto)
        {
            IDbConnection conexion = null;
            Serializar serializar = new Serializar();
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                string codigosDeBarra = serializar.XmlSerialize(producto.ListaCodigoBarra);

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spI_CatProductos", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroClaveProducto = _baseDatos.CrearParametro("@ClaveProducto", producto.ClaveProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroClaveProducto);

                IDataParameter parametroIdFamiliaProducto = _baseDatos.CrearParametro("@IdFamiliaProducto", producto.IdFamiliaProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdFamiliaProducto);

                IDataParameter parametroDescripcion = _baseDatos.CrearParametro("@Descripcion", producto.Descripcion, ParameterDirection.Input);
                comando.Parameters.Add(parametroDescripcion);

                IDataParameter parametroPrecio = _baseDatos.CrearParametro("@Precio", producto.Precio, ParameterDirection.Input);
                comando.Parameters.Add(parametroPrecio);

                IDataParameter parametroAplicaDescuentoCatalogo = _baseDatos.CrearParametro("@AplicaDescuentoCatalogo", producto.AplicaDescuentoCatalogo, ParameterDirection.Input);
                comando.Parameters.Add(parametroAplicaDescuentoCatalogo);

                IDataParameter parametroAplicaIdUsuario = _baseDatos.CrearParametro("@IdUsuario", producto.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroAplicaIdUsuario);

                IDataParameter parametroXmlCodigos = _baseDatos.CrearParametro("@XmlCodigos", codigosDeBarra, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlCodigos);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spI_CatProductos).");
                }

                transaccion.Commit();

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible registrar el producto.", excepcionCapturada);

                if (transaccion != null)
                {
                    transaccion.Rollback();
                }

                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }
        }

        public ExcepcionPersonalizada ConsultarProductos(int idFamiliaProducto)
        {
            ListaProductos = new List<CatProducto>();
            ListaCodigoBarra = new List<CodigoBarraProducto>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_Productos", conexion);

                IDataParameter parametroIdFamiliaProducto = _baseDatos.CrearParametro("@IdFamiliaProducto", idFamiliaProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdFamiliaProducto);

                IDataReader Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    CatProducto producto = new CatProducto();
                    producto.ClaveProducto = (int)Lector["ClaveProducto"];
                    producto.Descripcion = Lector["Descripcion"].ToString();
                    producto.Precio = (decimal)Lector["Precio"];
                    producto.AplicaDescuentoCatalogo = (bool)Lector["AplicaDescuentoCatalogo"];
                    producto.IdFamiliaProducto = (int)Lector["IdFamiliaProducto"];
                    producto.ListaCodigoBarra = new List<CodigoBarraProducto>();
                    ListaProductos.Add(producto);
                }

                Lector.NextResult();

                while (Lector.Read())
                {
                    CodigoBarraProducto codigoBarra = new CodigoBarraProducto();
                    codigoBarra.CodigoBarras = Lector["CodigoBarras"].ToString();
                    CatProducto producto = ListaProductos.Find(e => e.ClaveProducto == (int)Lector["ClaveProducto"]);
                    producto.ListaCodigoBarra.Add(codigoBarra);
                }

                Lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de productos.", excepcionCapturada);
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

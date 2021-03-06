﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using System.Data;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Servicios.Utilerias;
using SistemaFarmacia.Entidades.Negocio;
using SistemaFarmacia.Entidades;

namespace SistemaFarmacia.Servicios.Negocio.Catalogos
{
    public class ServicioCatalogoProductos
    {
        private IBaseDeDatos _baseDatos;
        public List<CatProducto> ListaProductos { get; private set; }
        public ComplementoVenta ComplementoVenta { get; private set; }

        public ServicioCatalogoProductos(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada EditarEstadoProducto(CatProducto producto)
        {
            IDbConnection conexion = null;
            IDbTransaction transaccion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                transaccion = conexion.BeginTransaction();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spU_CatProductosActivarDesactivar", conexion);
                comando.Transaction = transaccion;

                IDataParameter parametroIdProducto = _baseDatos.CrearParametro("@IdProducto", producto.IdProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdProducto);

                IDataParameter parametroEsActivo = _baseDatos.CrearParametro("@EsActivo", producto.EsActivo, ParameterDirection.Input);
                comando.Parameters.Add(parametroEsActivo);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", producto.IdUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas.Equals(0))
                {
                    throw new Exception("No se afectaron filas (spU_CatProductosActivarDesactivar).");
                }

                transaccion.Commit();

                return null;

            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible editar el estado del producto.", excepcionCapturada);

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

        public ExcepcionPersonalizada ValidarCodigosBarra(CatProducto producto, bool esAlta)
        {
            ListaProductos = new List<CatProducto>();
            IDbConnection conexion = null;
            Serializar serializar = new Serializar();

            try
            {
                string codigosDeBarra = serializar.ClaseXmlString(producto.ListaCodigoBarra);

                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_ValidaCodigoBarras", conexion);

                IDataParameter parametroIdProducto = _baseDatos.CrearParametro("@IdProducto", producto.IdProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdProducto);

                IDataParameter parametroXmlCodigos = _baseDatos.CrearParametro("@XmlCodigos", codigosDeBarra, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlCodigos);

                IDataParameter parametroEsAlta = _baseDatos.CrearParametro("@EsAlta", esAlta, ParameterDirection.Input);
                comando.Parameters.Add(parametroEsAlta);

                IDataReader Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    CatProducto productoInvalido = new CatProducto();
                    productoInvalido.ClaveProducto = (string)Lector["ClaveProducto"];
                    productoInvalido.ListaCodigoBarra = new List<CodigoBarraProducto>();
                    productoInvalido.ListaCodigoBarra.Add(new CodigoBarraProducto { CodigoBarras = Lector["CodigoBarras"].ToString() });
                    ListaProductos.Add(productoInvalido);
                }
                
                Lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible validar los códigos de barra.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }
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

                string codigosDeBarra = serializar.ClaseXmlString(producto.ListaCodigoBarra);
                string impuestoProducto = serializar.ClaseXmlString(producto.ListaImpuestos);

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

                IDataParameter parametroIdProducto = _baseDatos.CrearParametro("@IdProducto", producto.IdProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdProducto);

                IDataParameter parametroXmlImpuestos = _baseDatos.CrearParametro("@XmlImpuestos", impuestoProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlImpuestos);

                IDataParameter parametroAplicaPromocion = _baseDatos.CrearParametro("@AplicaPromocion", producto.AplicaPromocion, ParameterDirection.Input);
                comando.Parameters.Add(parametroAplicaPromocion);

                IDataParameter parametroCantidadPromocion = _baseDatos.CrearParametro("@CantidadPromocion", producto.CantidadPromocion, ParameterDirection.Input);
                comando.Parameters.Add(parametroCantidadPromocion);

                IDataParameter parametroPrecioPromocion = _baseDatos.CrearParametro("@PrecioPromocion", producto.PrecioPromocion, ParameterDirection.Input);
                comando.Parameters.Add(parametroPrecioPromocion);

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

                string codigosDeBarra = serializar.ClaseXmlString(producto.ListaCodigoBarra);
                string impuestosProducto = serializar.ClaseXmlString(producto.ListaImpuestos);

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

                IDataParameter parametroXmlImpuestos = _baseDatos.CrearParametro("@XmlImpuestos", impuestosProducto, ParameterDirection.Input);
                comando.Parameters.Add(parametroXmlImpuestos);

                IDataParameter parametroAplicaPromocion = _baseDatos.CrearParametro("@AplicaPromocion", producto.AplicaPromocion, ParameterDirection.Input);
                comando.Parameters.Add(parametroAplicaPromocion);

                IDataParameter parametroCantidadPromocion = _baseDatos.CrearParametro("@CantidadPromocion", producto.CantidadPromocion, ParameterDirection.Input);
                comando.Parameters.Add(parametroCantidadPromocion);

                IDataParameter parametroPrecioPromocion = _baseDatos.CrearParametro("@PrecioPromocion", producto.PrecioPromocion, ParameterDirection.Input);
                comando.Parameters.Add(parametroPrecioPromocion);

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
                    producto.ClaveProducto = (string)Lector["ClaveProducto"];
                    producto.Descripcion = Lector["Descripcion"].ToString();
                    producto.Precio = (decimal)Lector["Precio"];
                    producto.AplicaDescuentoCatalogo = (bool)Lector["AplicaDescuentoCatalogo"];
                    producto.IdFamiliaProducto = (int)Lector["IdFamiliaProducto"];
                    producto.IdProducto = (int)Lector["IdProducto"];
                    producto.EsActivo = (bool)Lector["EsActivo"];
                    producto.ListaCodigoBarra = new List<CodigoBarraProducto>();
                    producto.ListaImpuestos = new List<CatImpuestos>();
                    producto.AplicaPromocion = (bool)Lector["AplicaPromocion"];
                    producto.CantidadPromocion = (Int16)Lector["CantidadPromocion"];
                    producto.PrecioPromocion = (decimal)Lector["PrecioPromocion"];
                    ListaProductos.Add(producto);
                }

                Lector.NextResult();

                while (Lector.Read())
                {
                    CodigoBarraProducto codigoBarra = new CodigoBarraProducto();
                    codigoBarra.CodigoBarras = Lector["CodigoBarras"].ToString();
                    CatProducto producto = ListaProductos.Find(e => e.IdProducto == (int)Lector["IdProducto"]);
                    producto.ListaCodigoBarra.Add(codigoBarra);
                }

                Lector.NextResult();

                while (Lector.Read())
                {
                    CatImpuestos impuesto = new CatImpuestos();
                    impuesto.IdImpuesto = (Int16)Lector["IdImpuesto"];
                    impuesto.Descripcion = Lector["Descripcion"].ToString();
                    CatProducto producto = ListaProductos.Find(e => e.IdProducto == (int)Lector["IdProducto"]);
                    producto.ListaImpuestos.Add(impuesto);
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

        public ExcepcionPersonalizada ConsultarComplementoVenta()
        {
            ComplementoVenta = new ComplementoVenta();
            ComplementoVenta.ListaProductoVentaImpuesto = new List<ProductoVentaImpuesto>();
            ComplementoVenta.ListaProductos = new List<CatProducto>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_ComplementoVenta", conexion);

                IDataReader Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    CatProducto producto = new CatProducto();
                    producto.IdProducto = (int)Lector["IdProducto"];
                    producto.Precio = (decimal)Lector["Precio"];
                    producto.AplicaDescuentoCatalogo = (bool)Lector["AplicaDescuentoCatalogo"];
                    producto.AplicaPromocion = (bool)Lector["AplicaPromocion"];
                    producto.CantidadPromocion = (Int16)Lector["CantidadPromocion"];
                    producto.PrecioPromocion = (decimal)Lector["PrecioPromocion"];
                    ComplementoVenta.ListaProductos.Add(producto);
                }

                Lector.NextResult();

                while (Lector.Read())
                {
                    ProductoVentaImpuesto impuesto = new ProductoVentaImpuesto();
                    impuesto.IdProducto = (int)Lector["IdProducto"];
                    impuesto.IdImpuesto = (Int16)Lector["IdImpuesto"];
                    impuesto.Descripcion = Lector["Descripcion"].ToString();
                    impuesto.Porcentaje = (decimal)Lector["Porcentaje"];
                    ComplementoVenta.ListaProductoVentaImpuesto.Add(impuesto);
                }

                Lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener las listas de complementos de venta.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                    conexion.Close();
                    conexion.Dispose();
            }
        }


        public ExcepcionPersonalizada ConsultarProductosActivos(int idProducto, string claveProducto)
        {
            ListaProductos = new List<CatProducto>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatProductosDescripcion", conexion);

                if (idProducto > 0)
                {
                    IDataParameter parametroIdProducto = _baseDatos.CrearParametro("@IdProducto", idProducto, ParameterDirection.Input);
                    comando.Parameters.Add(parametroIdProducto);
                }

                claveProducto = claveProducto.TrimEnd().TrimStart();

                if (claveProducto.Length > 0)
                {
                    IDataParameter parametroClave = _baseDatos.CrearParametro("@ClaveProducto", claveProducto, ParameterDirection.Input);
                    comando.Parameters.Add(parametroClave);
                }

                IDataReader Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    CatProducto producto = new CatProducto();
                    producto.IdProducto = (int)Lector["IdProducto"];
                    producto.ClaveProducto = Lector["ClaveProducto"].ToString();
                    producto.Descripcion = Lector["Descripcion"].ToString();
                    producto.Precio = (decimal)Lector["Precio"];
                    
                    ListaProductos.Add(producto);
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
                {
                    conexion.Close();
                    conexion.Dispose();
                }
                    
            }
        }

    }
}

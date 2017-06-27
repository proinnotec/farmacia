using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio.Busqueda
{
    public class ServicioBusqueda
    {
        private IBaseDeDatos _baseDatos;
        public List<ProductosListado> ListaProductos { get; set; }

        public ServicioBusqueda(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public List<ProductosListado> ObtenerListadoProductos()
        {
            IDbConnection conexion = null;

            if (ListaProductos == null)
                ListaProductos = new List<ProductosListado>();
            else
                ListaProductos.Clear();

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_ListadoProductos", conexion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ProductosListado producto = new ProductosListado();
                    producto.IdProducto = (int)lector["IdProducto"];
                    producto.ClaveProducto = lector["ClaveProducto"].ToString();
                    producto.CodigoBarras = lector["CodigoBarras"].ToString();
                    producto.Descripcion = lector["Descripcion"].ToString();
                    producto.DescripcionCompleta = lector["DescripcionCompleta"].ToString();
                    ListaProductos.Add(producto);
                }

                lector.Close();

                return ListaProductos;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de productos.", excepcionCapturada);
                return ListaProductos;
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

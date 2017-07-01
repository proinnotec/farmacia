using ProInnotec.Core.Entidades.Datos;
using SistemaFarmacia.Entidades.Negocio.Almacen.Ajustes;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaFarmacia.Servicios.Negocio.Ajustes
{
    public class ServicioListadoAjustes
    {
        private IBaseDeDatos _baseDatos;
        public List<AjustesProductosListado> ListaAjustesProductos { get; set; }
        public List<AjustesProductosDetalles> ListaAjusteProductosDetalles { get; set; }

        public ServicioListadoAjustes(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarAjustesProductos(int anio)
        {
            ListaAjustesProductos = new List<AjustesProductosListado>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_AjustesProductosListado", conexion);

                IDataParameter parametroAnio = _baseDatos.CrearParametro("@Anio", anio, ParameterDirection.Input);
                comando.Parameters.Add(parametroAnio);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    AjustesProductosListado ajuste = new AjustesProductosListado();
                    ajuste.IdAjusteProducto = (int)lector["IdAjusteProducto"];
                    ajuste.IdSucursal = (int)lector["IdSucursal"];
                    ajuste.Fecha = (DateTime)lector["Fecha"];
                    ajuste.IdAjusteProductoDetalle = (int)lector["IdAjusteProductoDetalle"];
                    ajuste.IdTipoAjuste = (int)lector["IdTipoAjuste"];
                    ajuste.Ajuste = lector["Ajuste"].ToString();
                    ajuste.Descripcion = lector["Descripcion"].ToString();
                    ajuste.Cantidad = Convert.ToDecimal(lector["Cantidad"].ToString());
                    ajuste.IdProducto = (int)lector["IdProducto"];
                    ajuste.ClaveProducto = lector["ClaveProducto"].ToString();
                    ajuste.DescripcionProducto = lector["DescripcionProducto"].ToString();

                    ListaAjustesProductos.Add(ajuste);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de ajustes.", excepcionCapturada);
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

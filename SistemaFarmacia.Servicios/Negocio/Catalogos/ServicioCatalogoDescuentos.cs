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
    public class ServicioCatalogoDescuentos
    {
        private IBaseDeDatos _baseDatos;
        public List<CatDescuentos> ListaCatDescuentos { get; private set; }

        public ServicioCatalogoDescuentos(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarDescuentos()
        {
            ListaCatDescuentos = new List<CatDescuentos>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatDescuentos", conexion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CatDescuentos descuento = new CatDescuentos();

                    descuento.IdDescuento = (int)lector["IdDescuento"];
                    descuento.Porcentaje = (decimal)lector["Porcentaje"];
                    descuento.Descripcion = lector["Descripcion"].ToString();
                    descuento.EsActivo = (bool)lector["EsActivo"];

                    ListaCatDescuentos.Add(descuento);
                }

                lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de descuentos.", excepcionCapturada);
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

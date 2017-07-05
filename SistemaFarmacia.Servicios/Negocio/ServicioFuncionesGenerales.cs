using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFarmacia.Servicios.Negocio
{
    public class ServicioFuncionesGenerales
    {
        private IBaseDeDatos _baseDatos;
        public List<DiasSemana> ListaDiasSemana;

        public ServicioFuncionesGenerales(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ObtenerDiasSemana()
        {
            ListaDiasSemana = new List<DiasSemana>();

            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();

                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_CatDiasSemana", conexion);

                IDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    DiasSemana diaSemana = new DiasSemana();

                    diaSemana.IdDia = (int)lector["IdDia"];
                    diaSemana.Dia = lector["Dia"].ToString();

                    ListaDiasSemana.Add(diaSemana);
                }

                lector.Close();

                return null;
            }
            catch(Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("Hubo un error al intentar obtener la lista de los días de la semana.", excepcionCapturada);
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

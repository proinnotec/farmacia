using ProInnotec.Core.Entidades.Datos;
using ProInnotec.Core.Entidades.ManejoExcepciones;
using SistemaFarmacia.Entidades.Negocio;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemaFarmacia.Servicios.Operaciones
{
    public class ServicioDatosMenu
    {
       private IBaseDeDatos _baseDatos;

        public List<ElementoMenu> ListaMenu { get; private set; }

        public ServicioDatosMenu(IBaseDeDatos baseDatos)
        {
            _baseDatos = baseDatos;
        }

        public ExcepcionPersonalizada ConsultarMenu(int idUsuario)
        {
            ListaMenu = new List<ElementoMenu>();
            IDbConnection conexion = null;

            try
            {
                conexion = _baseDatos.CrearConexionAbierta();
                IDbCommand comando = _baseDatos.CrearComandoStoredProcedure("spS_MenuPrincipal", conexion);

                IDataParameter parametroIdUsuario = _baseDatos.CrearParametro("@IdUsuario", idUsuario, ParameterDirection.Input);
                comando.Parameters.Add(parametroIdUsuario);

                IDataReader Lector = comando.ExecuteReader();

                while (Lector.Read())
                {
                    ElementoMenu menu = new ElementoMenu();

                    menu.IdMenu = (int)Lector["IdMenu"];
                    menu.TextoVinculo = Lector["TextoVinculo"].ToString();
                    menu.Descripcion = Lector["Descripcion"].ToString();                
                    menu.Vista = Lector["Vista"].ToString();
                    menu.IdPadre = (int)Lector["IdPadre"];
                    menu.Posicion = (int)Lector["Posicion"];
                    menu.Nivel = (int)Lector["Nivel"];                  
                            
                    ListaMenu.Add(menu);
                }

                Lector.Close();

                return null;
            }
            catch (Exception excepcionCapturada)
            {
                ExcepcionPersonalizada excepcion = new ExcepcionPersonalizada("No fue posible obtener la lista de los elementos del menú.", excepcionCapturada);
                return excepcion;
            }
            finally
            {
                if (conexion != null)
                {
                    if (conexion.State != ConnectionState.Closed)
                    {
                        conexion.Close();
                    }

                    conexion.Dispose();
                }                    
            }
        }
    }
}

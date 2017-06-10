using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Procesos
{
    public partial class frmEditaEntradas : frmBase
    {
        private ContextoAplicacion _contextoAplicacion;
        private EntradasEditaController _entradasEditaController;
        private EntradaProductosDetalle _entradaProductoListado;
        private EnumeradoAccion _accion;

        public frmEditaEntradas(ContextoAplicacion contextoAplicacion, EnumeradoAccion accion, frmEntradas vistaLlamada, EntradaProductosDetalle entradaProductoListado)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _entradasEditaController = new EntradasEditaController(this);
            _entradaProductoListado = entradaProductoListado;
            _accion = accion;
        }

        private void frmEditaEntradas_Load(object sender, EventArgs e)
        {
            switch (_accion)
            {
                case EnumeradoAccion.Alta:
                    lblEntradaNo.Text = string.Empty;
                    lblNumProveedor.Text = string.Empty;
                    lblRazonSocial.Text = string.Empty;

                    break;

                case EnumeradoAccion.Edicion:
                    lblEntradaNo.Text = _entradaProductoListado.IdEntradaProducto.ToString();
                    lblNumProveedor.Text = _entradaProductoListado.IdProveedor.ToString();
                    lblRazonSocial.Text = _entradaProductoListado.RazonSocial;
                    dtpFecha.Value = _entradaProductoListado.Fecha;

                    _entradasEditaController.ConsultaEntradasDetalles(_entradaProductoListado.IdEntradaProducto);

                    break;
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogoAbrir = new OpenFileDialog();
            dialogoAbrir.Filter = "Archivos de Excel|*.xls;*.xlsx";
            dialogoAbrir.Title = "Registros de Entradas";

            if (dialogoAbrir.ShowDialog() == DialogResult.OK)
            {
                string hoja = string.Empty;
                hoja = dialogoAbrir.FileName;
                lblArchivo.Text = hoja;
                //hoja = txtHoja.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
               // LLenarGrid(hoja); //se manda a llamar al metodo
            }
        }

        public void AsignarListaDetalles(List<EntradaProductoDetalle> lista)
        {
            gridPartidas.AutoGenerateColumns = false;
            gridPartidas.DataSource = null;
            gridPartidas.DataSource = lista;
        }

        private void LLenarGrid(string archivo)
        {
            //declaramos las variables
            OleDbConnection conexion = null;
            DataSet dataset = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + archivo + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(archivo))
                MessageBox.Show("No hay una hoja para leer");

            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataset = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataset, archivo);//llenamos el dataset
                    gridPartidas.DataSource = dataset.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    gridPartidas.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    string mensaje = string.Format("{0} {1}", "Error al intentar leer el archivo", archivo);
                    MostrarDialogoResultado(this.Text, mensaje, ex.Message, false);
                    
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}

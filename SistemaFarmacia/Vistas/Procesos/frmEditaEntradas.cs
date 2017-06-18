using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Entidades.Negocio.Catalogos;
using SistemaFarmacia.Vistas.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaFarmacia.Vistas.Procesos
{
    public partial class frmEditaEntradas : frmBase
    {
        private ContextoAplicacion _contextoAplicacion;
        private EntradasEditaController _entradasEditaController;
        private EntradaProductoListado _entradaProductoListado;
        private EntradaProducto _entradaProducto;
        private EnumeradoAccion _accion;
        private frmEntradas _vistaLlamada;

        public frmEditaEntradas(ContextoAplicacion contextoAplicacion, EnumeradoAccion accion, frmEntradas vistaLlamada, EntradaProductoListado entradaProductoListado)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _entradasEditaController = new EntradasEditaController(this);
            _entradaProductoListado = entradaProductoListado;
            _entradaProducto = new EntradaProducto();
            _accion = accion;
            _vistaLlamada = vistaLlamada;
        }

        private void frmEditaEntradas_Load(object sender, EventArgs e)
        {
            ToolTip toolTipNuevo = new ToolTip();
            toolTipNuevo.SetToolTip(btnBuscar, "Buscar Archivo");

            ToolTip toolTipRecargar = new ToolTip();
            toolTipRecargar.SetToolTip(btnAgregar, "Agregar");

            ToolTip toolTipGuardar = new ToolTip();
            toolTipGuardar.SetToolTip(btnGuardar, "Guardar");

            ToolTip toolTipQuitar = new ToolTip();
            toolTipQuitar.SetToolTip(btnActDes, "Quitar");

            ToolTip toolTipSalir = new ToolTip();
            toolTipSalir.SetToolTip(btnCancelar, "Cerrar");

            dtpFecha.Enabled = false;

            switch (_accion)
            {
                case EnumeradoAccion.Alta:
                    lblEntradaNo.Text = string.Empty;
                    lblNumProveedor.Text = string.Empty;
                    lblRazonSocial.Text = string.Empty;
                    _entradasEditaController.ConsultaProductosLista(0);

                    break;

                case EnumeradoAccion.Edicion:
                    lblEntradaNo.Text = _entradaProductoListado.IdEntradaProducto.ToString();
                    lblNumProveedor.Text = _entradaProductoListado.IdProveedor.ToString();
                    lblRazonSocial.Text = _entradaProductoListado.RazonSocial;
                    dtpFecha.Value = _entradaProductoListado.Fecha;

                    _entradaProducto.IdUsuario = _entradaProductoListado.IdUsuario;

                    _entradasEditaController.ConsultaEntradasDetalles(_entradaProductoListado.IdEntradaProducto);

                    btnActDes.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnAgregar.Enabled = false;
                    btnGuardar.Enabled = false;
                    cmbProductos.Enabled = false;
                    gridPartidas.Enabled = false;

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

        public void LlenarComboProductos(List<CatProducto> lista)
        {
            cmbProductos.Items.Clear();
            cmbProductos.DataSource = lista;
            cmbProductos.DisplayMember = "Descripcion";
            cmbProductos.ValueMember = "IdProducto";
            cmbProductos.SelectedValue = 0;

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int productoId = 0;

            if (cmbProductos.SelectedValue != null)
            {
                productoId = (int)cmbProductos.SelectedValue;
            }                
                       
            if (productoId <= 0)
            {
                string mensaje = string.Format("{0}", "Debe seleccionar un producto para poder continuar");
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);

                return;
            }

            _entradasEditaController.ConsultaProductosLista(productoId);
      
            string claveProducto = _entradasEditaController.ListaProductos[0].ClaveProducto;
            string descripcion = _entradasEditaController.ListaProductos[0].Descripcion;
            decimal precioActual = _entradasEditaController.ListaProductos[0].Precio;
            decimal cantidad = 0;
            decimal precio = 0;
            bool actualizaPrecio = false;
                        
            gridPartidas.Rows.Add(0, 0, productoId, cantidad, claveProducto, descripcion, precioActual, precio, actualizaPrecio);
            cmbProductos.SelectedValue = 0;
                        
        }

        private void RecuperaDatosDeGrid()
        {
            if(gridPartidas.ReadOnly == true)
                gridPartidas.ReadOnly = false;

            if (!VerificaExistenciaRegistros())
                return;
            
            gridPartidas.SelectedRows[0].Cells["Precio"].ReadOnly = false;
            gridPartidas.SelectedRows[0].Cells["Cantidad"].ReadOnly = false;
            gridPartidas.SelectedRows[0].Cells["ActPrecioCatalogo"].ReadOnly = false;
            gridPartidas.SelectedRows[0].Cells["ClaveProducto"].ReadOnly = true;
            gridPartidas.SelectedRows[0].Cells["PrecioActual"].ReadOnly = true;
            gridPartidas.SelectedRows[0].Cells["Descripcion"].ReadOnly = true;

        }

        private bool VerificaExistenciaRegistros()
        {
            if (gridPartidas.RowCount <= 0)
            {
                MostrarDialogoResultado(this.Text, "No hay registros para continuar.", string.Empty, false);
                return false;
            }

            return true;
        }

        private void btnActDes_Click(object sender, EventArgs e)
        {
            if (!VerificaExistenciaRegistros())
                return;

            string mensaje = "¿Confirma que desea quitar el registro seleccionado?";
            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta != DialogResult.Yes)
                return;

            gridPartidas.Rows.Remove(gridPartidas.CurrentRow);
        }

        private void gridPartidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RecuperaDatosDeGrid();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!VerificaExistenciaRegistros())
                return;

            string mensaje = "¿Confirma que desea guardar la entrada?";
            DialogResult respuesta = MostrarDialogoConfirmacion(this.Text, mensaje);

            if (respuesta != DialogResult.Yes)
                return;


            EntradaProducto entrada = new EntradaProducto();

            entrada.Proveedor.IdProveedor = 1;
            entrada.IdSucursal = _contextoAplicacion.Usuario.IdSucursal;
            entrada.IdUsuario = _contextoAplicacion.Usuario.IdUsuario;

            foreach(DataGridViewRow fila in gridPartidas.Rows)
            {
                EntradaProductoDetalle detalle = new EntradaProductoDetalle();
                detalle.IdProducto = (int)fila.Cells["IdProducto"].Value;
                detalle.ClaveProducto = fila.Cells["ClaveProducto"].Value.ToString();
                detalle.Cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                detalle.PrecioActual = Convert.ToDecimal(fila.Cells["PrecioActual"].Value);
                detalle.PrecioEntrada = Convert.ToDecimal(fila.Cells["Precio"].Value);
                detalle.ActualizaPrecio = (bool)fila.Cells["ActPrecioCatalogo"].Value;

                entrada.EntradaDetalles.Add(detalle);
                
            }

            _entradasEditaController.GuardarDescuentoConfiguracion(entrada);

        }

        public void Cerrar()
        {
            _vistaLlamada.CargarDatos();

            this.Close();
            this.Dispose();

        }
    }
}

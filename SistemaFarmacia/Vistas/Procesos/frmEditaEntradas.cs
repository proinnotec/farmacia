using SistemaFarmacia.Controladores.Procesos;
using SistemaFarmacia.Entidades.Contextos;
using SistemaFarmacia.Entidades.Enumerados;
using SistemaFarmacia.Entidades.Negocio.Almacen.Entradas;
using SistemaFarmacia.Entidades.Negocio.Busqueda;
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

        AutoCompleteStringCollection ResultadosBusqueda;

        public frmEditaEntradas(ContextoAplicacion contextoAplicacion, EnumeradoAccion accion, frmEntradas vistaLlamada, EntradaProductoListado entradaProductoListado)
        {
            InitializeComponent();
            _contextoAplicacion = contextoAplicacion;
            _entradasEditaController = new EntradasEditaController(this);
            _entradaProductoListado = entradaProductoListado;
            _entradaProducto = new EntradaProducto();
            _accion = accion;
            _vistaLlamada = vistaLlamada;

            ResultadosBusqueda = new AutoCompleteStringCollection();
            txtBusqueda.AutoCompleteCustomSource = ResultadosBusqueda;
            txtBusqueda.AutoCompleteMode = AutoCompleteMode.None;
            txtBusqueda.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void frmEditaEntradas_Load(object sender, EventArgs e)
        {
            ToolTip toolTipNuevo = new ToolTip();
            toolTipNuevo.SetToolTip(btnBuscar, "Buscar Archivo de Excel");
                        
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
                                        
                    LlenarListaProductos();

                    txtBusqueda.Focus();

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
                    btnGuardar.Enabled = false;
                    gridPartidas.Enabled = false;
                    txtBusqueda.Enabled = false;

                    break;
            }
            
        }

        public void LlenarListaProductos()
        {
            List<ProductosListado> listaProductos = _entradasEditaController.LlenarListaProductos();

            foreach (ProductosListado producto in listaProductos)
            {
                ResultadosBusqueda.Add(producto.DescripcionCompleta);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            importarExcel();

        }
        public void importarExcel()
        {
            OleDbConnection conn;
            OleDbDataAdapter MyDataAdapter;
            DataTable dt;
            
            string ruta = "";
            
            try
            {
                OpenFileDialog dialogoAbrir = new OpenFileDialog();
                dialogoAbrir.Filter = "Archivos de Excel|*.xls;*.xlsx";
                dialogoAbrir.Title = "Registros de Entradas";

                if (dialogoAbrir.ShowDialog() != DialogResult.OK)
                    return;

                gridPartidas.Rows.Clear();

                btnActDes.Enabled = false;
                txtBusqueda.Enabled = false;
                
                ruta = dialogoAbrir.FileName;
                lblArchivo.Text = ruta;
                ruta = lblArchivo.Text;

                int posicionInicial = ruta.LastIndexOf('.');
                int posicionFinal = ruta.Length - posicionInicial;

                string conexionString = string.Empty;
                string tipoArchivo = string.Empty;

                tipoArchivo = ruta.Substring(posicionInicial, posicionFinal);
               
                switch(tipoArchivo)
                {
                    case ".xls":
                        conexionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + ruta + "';Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'";
                        break;

                    case ".xlsx":
                        conexionString = "Provider=Microsoft.ACE.OLEDB.12.0;data source=" + ruta + ";Extended Properties='Excel 12.0 Xml;HDR=Yes'";
                        break;
                }

                conn = new OleDbConnection(conexionString);

                MyDataAdapter = new OleDbDataAdapter("Select Cantidad, ClaveProducto from [Hoja1$]", conn);
                dt = new DataTable();
                MyDataAdapter.Fill(dt);

                string clave;

                if(dt.Rows.Count <= 0)
                {
                    string mensaje = string.Format("{0}", "El archivo no contiene datos, favor de verificar");
                    MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);

                    return;
                }

                foreach (DataRow row in dt.Rows)
                {

                    clave = row["ClaveProducto"].ToString();

                    _entradasEditaController.ConsultaProductosLista(0, clave);

                    if(_entradasEditaController.ListaProductos.Count <= 0)
                    {
                        string mensaje = string.Format("{0} {1}", "No se puede continuar con la carga del archivo, porque no se encontraron datos con la clave del producto ", clave);
                        MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);

                        gridPartidas.Rows.Clear();

                        return;
                    }

                    int productoId = _entradasEditaController.ListaProductos[0].IdProducto;
                    string claveProducto = _entradasEditaController.ListaProductos[0].ClaveProducto;
                    string descripcion = _entradasEditaController.ListaProductos[0].Descripcion;
                    decimal precioActual = _entradasEditaController.ListaProductos[0].Precio;

                    decimal cantidad;
                    bool sePuedeConvertir = decimal.TryParse(row["Cantidad"].ToString(), out cantidad);

                    if(!sePuedeConvertir)
                    {
                        string mensaje = string.Format("{0} {1} {2} {3}", "El valor de la cantidad no es numérico en el producto", clave, descripcion, "favor de verificar");
                        MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);

                        gridPartidas.Rows.Clear();

                        return;
                    }

                    decimal precio = 0;
                    bool actualizaPrecio = false;

                    gridPartidas.Rows.Add(0, 0, productoId, cantidad, claveProducto, descripcion, precioActual, precio, actualizaPrecio);
                    
                }

            }
            catch (Exception ex)
            {
                string mensaje = string.Format("{0} {1}", "Error al intentar leer el archivo", ruta);
                MostrarDialogoResultado(this.Text, mensaje, ex.Message, false);
            }
        }
    
        public void AsignarListaDetalles(List<EntradaProductoDetalle> lista)
        {
            gridPartidas.AutoGenerateColumns = false;
            gridPartidas.DataSource = null;
            gridPartidas.DataSource = lista;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void RecuperaDatosDeGrid()
        {
            if(gridPartidas.ReadOnly == true)
                gridPartidas.ReadOnly = false;

            if (!VerificaExistenciaRegistros())
                return;
            
            gridPartidas.SelectedRows[0].Cells["Precio"].ReadOnly = false;
            gridPartidas.SelectedRows[0].Cells["PrecioActual"].ReadOnly = false;
            gridPartidas.SelectedRows[0].Cells["Cantidad"].ReadOnly = false;
            gridPartidas.SelectedRows[0].Cells["ActPrecioCatalogo"].ReadOnly = false;
            gridPartidas.SelectedRows[0].Cells["ClaveProducto"].ReadOnly = true;
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
                detalle.Descripcion = fila.Cells["Descripcion"].Value.ToString();

                decimal cantidad;

                bool sePuedeConvertirCantidad = decimal.TryParse(fila.Cells["Cantidad"].Value.ToString(), out cantidad);

                if (!sePuedeConvertirCantidad)
                {
                    string mensajeConversion = string.Format("{0} {1} {2} {3}", "El valor de la cantidad no es numérico en el producto", detalle.ClaveProducto, detalle.Descripcion , "favor de verificar");
                    MostrarDialogoResultado(this.Text, mensajeConversion, string.Empty, false);
                    return;
                }

                detalle.Cantidad = cantidad;

                decimal precioActual;

                bool sePuedeConvertirPrecioActual = decimal.TryParse(fila.Cells["PrecioActual"].Value.ToString(), out precioActual);

                if (!sePuedeConvertirPrecioActual)
                {
                    string mensajeConversion = string.Format("{0} {1} {2} {3}", "El valor del precio actual no es numérico en el producto", detalle.ClaveProducto, detalle.Descripcion, "favor de verificar");
                    MostrarDialogoResultado(this.Text, mensajeConversion, string.Empty, false);
                    return;
                }

                detalle.PrecioActual = precioActual;

                decimal precioEntrada;

                bool sePuedeConvertirPrecioEntrada = decimal.TryParse(fila.Cells["Precio"].Value.ToString(), out precioEntrada);

                if (!sePuedeConvertirPrecioEntrada)
                {
                    string mensajeConversion = string.Format("{0} {1} {2} {3}", "El valor del precio de entrada no es numérico en el producto", detalle.ClaveProducto, detalle.Descripcion, "favor de verificar");
                    MostrarDialogoResultado(this.Text, mensajeConversion, string.Empty, false);
                    return;
                }

                detalle.PrecioEntrada = precioEntrada;

                detalle.ActualizaPrecio = Convert.ToBoolean(fila.Cells["ActPrecioCatalogo"].Value);

                string mensajeDetalles = string.Empty;

                if (detalle.Cantidad <= 0)
                {
                    mensajeDetalles = string.Format("La cantidad del producto {0} - {1} debe ser mayor a cero", detalle.ClaveProducto, detalle.Descripcion);
                    MostrarDialogoResultado(this.Text, mensajeDetalles, string.Empty, false);
                    return;
                }

                if (detalle.ActualizaPrecio && detalle.PrecioActual <= 0)
                {
                    mensajeDetalles = string.Format("El precio actual del producto {0} - {1} debe ser mayor a cero", detalle.ClaveProducto, detalle.Descripcion);
                    MostrarDialogoResultado(this.Text, mensajeDetalles, string.Empty, false);
                    return;
                }

                if (detalle.PrecioEntrada <= 0)
                {
                    mensajeDetalles = string.Format("El precio de entrada del producto {0} - {1} debe ser mayor a cero", detalle.ClaveProducto, detalle.Descripcion);
                    MostrarDialogoResultado(this.Text, mensajeDetalles, string.Empty, false);
                    return;
                }

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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ltbResultados.BringToFront();
            ltbResultados.Items.Clear();

            if (txtBusqueda.Text.Length == 0)
            {
                EsconderResultados();
                return;
            }

            foreach (String s in txtBusqueda.AutoCompleteCustomSource)
            {
                if (!s.Contains(txtBusqueda.Text.ToUpper())) continue;

                ltbResultados.Items.Add(s);
                ltbResultados.Visible = true;
            }
        }

        private void EsconderResultados()
        {
            ltbResultados.Visible = false;
        }

        private void ltbResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IdxClaveProducto = 0;
            int IdxDescripcion = 0;
            int IdxIdProducto = 0;

            string Producto = ltbResultados.Items[ltbResultados.SelectedIndex].ToString();

            IdxClaveProducto = Producto.IndexOf(" CV: ");
            IdxDescripcion = Producto.IndexOf(" DSC: ");
            IdxIdProducto = Producto.IndexOf(" ID: ");

            if (ltbResultados.SelectedItem == null) return;
            
            int productoId = 0;
            string idProducto = string.Empty;

            idProducto = Producto.Substring(IdxIdProducto + 5, Producto.Length - (IdxIdProducto + 5));

            productoId = Convert.ToInt32(idProducto);

            if (productoId <= 0)
            {
                string mensaje = string.Format("{0}", "Debe seleccionar un producto para poder continuar");
                MostrarDialogoResultado(this.Text, mensaje, string.Empty, false);

                return;
            }

            _entradasEditaController.ConsultaProductosLista(productoId, string.Empty);

            string claveProducto = _entradasEditaController.ListaProductos[0].ClaveProducto;
            string descripcion = _entradasEditaController.ListaProductos[0].Descripcion;
            decimal precioActual = _entradasEditaController.ListaProductos[0].Precio;
            decimal cantidad = 0;
            decimal precio = 0;
            bool actualizaPrecio = false;

            gridPartidas.Rows.Add(0, 0, productoId, cantidad, claveProducto, descripcion, precioActual, precio, actualizaPrecio);

            txtBusqueda.Text = string.Empty;
            EsconderResultados();
            btnBuscar.Enabled = false;

        }
    }
}

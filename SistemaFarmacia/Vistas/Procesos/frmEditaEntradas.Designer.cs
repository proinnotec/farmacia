namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmEditaEntradas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNumProveedor = new System.Windows.Forms.Label();
            this.lblProveedorTexto = new System.Windows.Forms.Label();
            this.lblEntradaNo = new System.Windows.Forms.Label();
            this.lblEntradaNoTexto = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.gridPartidas = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.btnCancelar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnActDes = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnGuardar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.IdEntradaProductoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEntradaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActPrecioCatalogo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "dialogoAbrir";
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblArchivo.Location = new System.Drawing.Point(15, 61);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(2, 18);
            this.lblArchivo.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblRazonSocial);
            this.groupBox2.Controls.Add(this.lblNumProveedor);
            this.groupBox2.Controls.Add(this.lblProveedorTexto);
            this.groupBox2.Controls.Add(this.lblEntradaNo);
            this.groupBox2.Controls.Add(this.lblEntradaNoTexto);
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(829, 56);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos generales de entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(693, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Entrada";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRazonSocial.Location = new System.Drawing.Point(215, 35);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(100, 16);
            this.lblRazonSocial.TabIndex = 5;
            this.lblRazonSocial.Text = "Razón Social";
            this.lblRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumProveedor
            // 
            this.lblNumProveedor.AutoSize = true;
            this.lblNumProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumProveedor.Location = new System.Drawing.Point(187, 35);
            this.lblNumProveedor.Name = "lblNumProveedor";
            this.lblNumProveedor.Size = new System.Drawing.Size(29, 16);
            this.lblNumProveedor.TabIndex = 4;
            this.lblNumProveedor.Text = "NP";
            this.lblNumProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProveedorTexto
            // 
            this.lblProveedorTexto.AutoSize = true;
            this.lblProveedorTexto.Location = new System.Drawing.Point(187, 17);
            this.lblProveedorTexto.Name = "lblProveedorTexto";
            this.lblProveedorTexto.Size = new System.Drawing.Size(81, 16);
            this.lblProveedorTexto.TabIndex = 3;
            this.lblProveedorTexto.Text = "Proveedor";
            // 
            // lblEntradaNo
            // 
            this.lblEntradaNo.AutoSize = true;
            this.lblEntradaNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEntradaNo.Location = new System.Drawing.Point(26, 35);
            this.lblEntradaNo.Name = "lblEntradaNo";
            this.lblEntradaNo.Size = new System.Drawing.Size(32, 16);
            this.lblEntradaNo.TabIndex = 2;
            this.lblEntradaNo.Text = "No.";
            this.lblEntradaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntradaNoTexto
            // 
            this.lblEntradaNoTexto.AutoSize = true;
            this.lblEntradaNoTexto.Location = new System.Drawing.Point(3, 17);
            this.lblEntradaNoTexto.Name = "lblEntradaNoTexto";
            this.lblEntradaNoTexto.Size = new System.Drawing.Size(90, 16);
            this.lblEntradaNoTexto.TabIndex = 1;
            this.lblEntradaNoTexto.Text = "Entrada No.";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(693, 29);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(131, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 65);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda de Productos";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(5, 21);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(818, 22);
            this.txtBusqueda.TabIndex = 22;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // gridPartidas
            // 
            this.gridPartidas.AllowUserToAddRows = false;
            this.gridPartidas.AllowUserToDeleteRows = false;
            this.gridPartidas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridPartidas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPartidas.BackgroundColor = System.Drawing.Color.White;
            this.gridPartidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPartidas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPartidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEntradaProductoDetalle,
            this.IdEntradaProducto,
            this.IdProducto,
            this.Cantidad,
            this.ClaveProducto,
            this.Descripcion,
            this.PrecioActual,
            this.Precio,
            this.ActPrecioCatalogo});
            this.gridPartidas.EnableHeadersVisualStyles = false;
            this.gridPartidas.Location = new System.Drawing.Point(12, 220);
            this.gridPartidas.MultiSelect = false;
            this.gridPartidas.Name = "gridPartidas";
            this.gridPartidas.ReadOnly = true;
            this.gridPartidas.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPartidas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridPartidas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPartidas.RowTemplate.Height = 20;
            this.gridPartidas.RowTemplate.ReadOnly = true;
            this.gridPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPartidas.Size = new System.Drawing.Size(829, 320);
            this.gridPartidas.TabIndex = 8;
            this.gridPartidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPartidas_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundImage = global::SistemaFarmacia.Resource.exit;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(847, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActDes
            // 
            this.btnActDes.BackColor = System.Drawing.Color.LightGray;
            this.btnActDes.BackgroundImage = global::SistemaFarmacia.Resource.bloquear;
            this.btnActDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActDes.Location = new System.Drawing.Point(847, 280);
            this.btnActDes.Name = "btnActDes";
            this.btnActDes.Size = new System.Drawing.Size(50, 50);
            this.btnActDes.TabIndex = 18;
            this.btnActDes.UseVisualStyleBackColor = false;
            this.btnActDes.Click += new System.EventHandler(this.btnActDes_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.BackgroundImage = global::SistemaFarmacia.Resource.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(847, 220);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::SistemaFarmacia.Resource.search2;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(847, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrucciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblInstrucciones.Location = new System.Drawing.Point(15, 5);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(767, 44);
            this.lblInstrucciones.TabIndex = 20;
            this.lblInstrucciones.Text = "Importante:  Para que el archivo de Excel se lea correctamente, en las Celdas A1," +
    " B1 y C1 deben estar las cabeceras \"Cantidad\", \"ClaveProducto\" y \"PrecioEntrada\"" +
    " respectivamente.";
            // 
            // ltbResultados
            // 
            this.ltbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.ItemHeight = 16;
            this.ltbResultados.Location = new System.Drawing.Point(18, 196);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(817, 100);
            this.ltbResultados.TabIndex = 21;
            this.ltbResultados.Visible = false;
            this.ltbResultados.SelectedIndexChanged += new System.EventHandler(this.ltbResultados_SelectedIndexChanged);
            // 
            // IdEntradaProductoDetalle
            // 
            this.IdEntradaProductoDetalle.DataPropertyName = "IdEntradaProductoDetalle";
            this.IdEntradaProductoDetalle.FillWeight = 137.2427F;
            this.IdEntradaProductoDetalle.HeaderText = "IdEntradaProductoDetalle";
            this.IdEntradaProductoDetalle.Name = "IdEntradaProductoDetalle";
            this.IdEntradaProductoDetalle.ReadOnly = true;
            this.IdEntradaProductoDetalle.Visible = false;
            // 
            // IdEntradaProducto
            // 
            this.IdEntradaProducto.DataPropertyName = "IdEntradaProducto";
            this.IdEntradaProducto.HeaderText = "Entrada";
            this.IdEntradaProducto.Name = "IdEntradaProducto";
            this.IdEntradaProducto.ReadOnly = true;
            this.IdEntradaProducto.Visible = false;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.FillWeight = 103.1952F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // ClaveProducto
            // 
            this.ClaveProducto.DataPropertyName = "ClaveProducto";
            this.ClaveProducto.HeaderText = "ClaveProducto";
            this.ClaveProducto.Name = "ClaveProducto";
            this.ClaveProducto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 5;
            // 
            // PrecioActual
            // 
            this.PrecioActual.DataPropertyName = "PrecioActual";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.PrecioActual.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecioActual.HeaderText = "PrecioActual";
            this.PrecioActual.Name = "PrecioActual";
            this.PrecioActual.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "PrecioEntrada";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle5;
            this.Precio.HeaderText = "Precio Entrada";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // ActPrecioCatalogo
            // 
            this.ActPrecioCatalogo.HeaderText = "Actualizar Precio Catalogo";
            this.ActPrecioCatalogo.Name = "ActPrecioCatalogo";
            this.ActPrecioCatalogo.ReadOnly = true;
            // 
            // frmEditaEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 552);
            this.Controls.Add(this.ltbResultados);
            this.Controls.Add(this.gridPartidas);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.btnActDes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "frmEditaEntradas";
            this.Text = "Entradas de Productos";
            this.Load += new System.EventHandler(this.frmEditaEntradas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ControlesPersonalizados.GridPersonalizado gridPartidas;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblArchivo;
        private ControlesPersonalizados.BotonPersonalizado btnActDes;
        private System.Windows.Forms.Label lblEntradaNo;
        private System.Windows.Forms.Label lblEntradaNoTexto;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNumProveedor;
        private System.Windows.Forms.Label lblProveedorTexto;
        private System.Windows.Forms.Label label1;
        private ControlesPersonalizados.BotonPersonalizado btnCancelar;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.ListBox ltbResultados;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEntradaProductoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEntradaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ActPrecioCatalogo;
    }
}
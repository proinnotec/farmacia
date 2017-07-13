namespace SistemaFarmacia.Vistas.Ventas
{
    partial class frmDialogoProductoVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.chkAplicaDescuento = new System.Windows.Forms.CheckBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.gridImpuestos = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.IdImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPromocion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(103, 71);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(644, 20);
            this.txtDescripcion.TabIndex = 36;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(100, 55);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 35;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.Enabled = false;
            this.txtClaveProducto.Location = new System.Drawing.Point(106, 120);
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(132, 20);
            this.txtClaveProducto.TabIndex = 34;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(103, 12);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(644, 31);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Búsqueda";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(103, 150);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 27;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(672, 287);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(106, 166);
            this.nupCantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(123, 20);
            this.nupCantidad.TabIndex = 25;
            this.nupCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAplicaDescuento
            // 
            this.chkAplicaDescuento.AutoSize = true;
            this.chkAplicaDescuento.Enabled = false;
            this.chkAplicaDescuento.Location = new System.Drawing.Point(245, 120);
            this.chkAplicaDescuento.Name = "chkAplicaDescuento";
            this.chkAplicaDescuento.Size = new System.Drawing.Size(108, 17);
            this.chkAplicaDescuento.TabIndex = 22;
            this.chkAplicaDescuento.Text = "Aplica descuento";
            this.chkAplicaDescuento.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(242, 150);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Precio:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Enabled = false;
            this.nudPrecio.Location = new System.Drawing.Point(245, 166);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(98, 20);
            this.nudPrecio.TabIndex = 19;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblClaveProducto
            // 
            this.lblClaveProducto.AutoSize = true;
            this.lblClaveProducto.Location = new System.Drawing.Point(103, 104);
            this.lblClaveProducto.Name = "lblClaveProducto";
            this.lblClaveProducto.Size = new System.Drawing.Size(82, 13);
            this.lblClaveProducto.TabIndex = 18;
            this.lblClaveProducto.Text = "Clave producto:";
            // 
            // ltbResultados
            // 
            this.ltbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.ItemHeight = 24;
            this.ltbResultados.Location = new System.Drawing.Point(103, 39);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(644, 124);
            this.ltbResultados.TabIndex = 33;
            this.ltbResultados.Visible = false;
            this.ltbResultados.SelectedIndexChanged += new System.EventHandler(this.ltbResultados_SelectedIndexChanged);
            // 
            // gridImpuestos
            // 
            this.gridImpuestos.AllowUserToAddRows = false;
            this.gridImpuestos.AllowUserToDeleteRows = false;
            this.gridImpuestos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridImpuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridImpuestos.BackgroundColor = System.Drawing.Color.White;
            this.gridImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridImpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdImpuesto,
            this.Descripcion,
            this.Porcentaje});
            this.gridImpuestos.EnableHeadersVisualStyles = false;
            this.gridImpuestos.Location = new System.Drawing.Point(103, 202);
            this.gridImpuestos.MultiSelect = false;
            this.gridImpuestos.Name = "gridImpuestos";
            this.gridImpuestos.ReadOnly = true;
            this.gridImpuestos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpuestos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridImpuestos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpuestos.RowTemplate.Height = 20;
            this.gridImpuestos.RowTemplate.ReadOnly = true;
            this.gridImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImpuestos.Size = new System.Drawing.Size(388, 108);
            this.gridImpuestos.TabIndex = 37;
            // 
            // IdImpuesto
            // 
            this.IdImpuesto.DataPropertyName = "IdImpuesto";
            dataGridViewCellStyle3.NullValue = null;
            this.IdImpuesto.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdImpuesto.HeaderText = "IdImpuesto";
            this.IdImpuesto.Name = "IdImpuesto";
            this.IdImpuesto.ReadOnly = true;
            this.IdImpuesto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Impuesto";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // lblPromocion
            // 
            this.lblPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPromocion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromocion.Location = new System.Drawing.Point(374, 120);
            this.lblPromocion.Name = "lblPromocion";
            this.lblPromocion.Size = new System.Drawing.Size(373, 66);
            this.lblPromocion.TabIndex = 38;
            this.lblPromocion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPromocion.Visible = false;
            // 
            // frmDialogoProductoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 320);
            this.Controls.Add(this.lblPromocion);
            this.Controls.Add(this.gridImpuestos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtClaveProducto);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.chkAplicaDescuento);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblClaveProducto);
            this.Controls.Add(this.ltbResultados);
            this.Name = "frmDialogoProductoVenta";
            this.Text = "Datos del producto";
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAplicaDescuento;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblClaveProducto;
        public System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbResultados;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private ControlesPersonalizados.GridPersonalizado gridImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.Label lblPromocion;
    }
}
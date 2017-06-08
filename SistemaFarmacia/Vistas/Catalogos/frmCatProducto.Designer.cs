namespace SistemaFarmacia.Vistas.Catalogos
{
    partial class frmCatProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.tbnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.gridCodigoBarra = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAplicaDescuento = new System.Windows.Forms.CheckBox();
            this.nudClaveProducto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.cmbFamilias = new SistemaFarmacia.ControlesPersonalizados.ComboPersonalizado();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbImpuesto = new SistemaFarmacia.ControlesPersonalizados.ComboPersonalizado();
            this.lblImpuesto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClaveProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.BackgroundImage = global::SistemaFarmacia.Resource.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(409, 339);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbnQuitar
            // 
            this.tbnQuitar.Location = new System.Drawing.Point(409, 301);
            this.tbnQuitar.Name = "tbnQuitar";
            this.tbnQuitar.Size = new System.Drawing.Size(27, 23);
            this.tbnQuitar.TabIndex = 14;
            this.tbnQuitar.Text = "-";
            this.tbnQuitar.UseVisualStyleBackColor = true;
            this.tbnQuitar.Click += new System.EventHandler(this.tbnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(409, 272);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Location = new System.Drawing.Point(15, 220);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoBarra.TabIndex = 12;
            this.lblCodigoBarra.Text = "Código de Barra:";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(15, 236);
            this.txtCodigoBarra.MaxLength = 100;
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(388, 20);
            this.txtCodigoBarra.TabIndex = 11;
            // 
            // gridCodigoBarra
            // 
            this.gridCodigoBarra.AllowUserToAddRows = false;
            this.gridCodigoBarra.AllowUserToDeleteRows = false;
            this.gridCodigoBarra.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridCodigoBarra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCodigoBarra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCodigoBarra.BackgroundColor = System.Drawing.Color.White;
            this.gridCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCodigoBarra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCodigoBarra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridCodigoBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCodigoBarra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBarras});
            this.gridCodigoBarra.EnableHeadersVisualStyles = false;
            this.gridCodigoBarra.Location = new System.Drawing.Point(16, 272);
            this.gridCodigoBarra.MultiSelect = false;
            this.gridCodigoBarra.Name = "gridCodigoBarra";
            this.gridCodigoBarra.ReadOnly = true;
            this.gridCodigoBarra.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCodigoBarra.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCodigoBarra.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCodigoBarra.RowTemplate.Height = 20;
            this.gridCodigoBarra.RowTemplate.ReadOnly = true;
            this.gridCodigoBarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCodigoBarra.Size = new System.Drawing.Size(387, 117);
            this.gridCodigoBarra.TabIndex = 10;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.DataPropertyName = "CodigoBarras";
            this.CodigoBarras.HeaderText = "Código de barras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            // 
            // chkAplicaDescuento
            // 
            this.chkAplicaDescuento.AutoSize = true;
            this.chkAplicaDescuento.Location = new System.Drawing.Point(164, 184);
            this.chkAplicaDescuento.Name = "chkAplicaDescuento";
            this.chkAplicaDescuento.Size = new System.Drawing.Size(108, 17);
            this.chkAplicaDescuento.TabIndex = 9;
            this.chkAplicaDescuento.Text = "Aplica descuento";
            this.chkAplicaDescuento.UseVisualStyleBackColor = true;
            // 
            // nudClaveProducto
            // 
            this.nudClaveProducto.Location = new System.Drawing.Point(15, 75);
            this.nudClaveProducto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudClaveProducto.Name = "nudClaveProducto";
            this.nudClaveProducto.Size = new System.Drawing.Size(123, 20);
            this.nudClaveProducto.TabIndex = 8;
            this.nudClaveProducto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 168);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(18, 184);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 6;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblClaveProducto
            // 
            this.lblClaveProducto.AutoSize = true;
            this.lblClaveProducto.Location = new System.Drawing.Point(12, 59);
            this.lblClaveProducto.Name = "lblClaveProducto";
            this.lblClaveProducto.Size = new System.Drawing.Size(82, 13);
            this.lblClaveProducto.TabIndex = 4;
            this.lblClaveProducto.Text = "Clave producto:";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(12, 9);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(112, 13);
            this.lblFamilia.TabIndex = 3;
            this.lblFamilia.Text = "Familias de productos:";
            // 
            // cmbFamilias
            // 
            this.cmbFamilias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFamilias.BackColor = System.Drawing.Color.White;
            this.cmbFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFamilias.FormattingEnabled = true;
            this.cmbFamilias.Location = new System.Drawing.Point(15, 25);
            this.cmbFamilias.Name = "cmbFamilias";
            this.cmbFamilias.Size = new System.Drawing.Size(388, 21);
            this.cmbFamilias.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 131);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(388, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbImpuesto.BackColor = System.Drawing.Color.White;
            this.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Location = new System.Drawing.Point(164, 75);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(239, 21);
            this.cmbImpuesto.TabIndex = 16;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(161, 59);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(47, 13);
            this.lblImpuesto.TabIndex = 17;
            this.lblImpuesto.Text = "Impesto:";
            // 
            // frmCatProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 401);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.cmbImpuesto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblCodigoBarra);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.gridCodigoBarra);
            this.Controls.Add(this.chkAplicaDescuento);
            this.Controls.Add(this.nudClaveProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblClaveProducto);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.cmbFamilias);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "frmCatProducto";
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClaveProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblFamilia;
        private ControlesPersonalizados.ComboPersonalizado cmbFamilias;
        private System.Windows.Forms.Label lblClaveProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.CheckBox chkAplicaDescuento;
        private ControlesPersonalizados.GridPersonalizado gridCodigoBarra;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button tbnQuitar;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        public System.Windows.Forms.NumericUpDown nudClaveProducto;
        private ControlesPersonalizados.ComboPersonalizado cmbImpuesto;
        private System.Windows.Forms.Label lblImpuesto;
    }
}
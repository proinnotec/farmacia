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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatProducto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGuardar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.chkAplicaDescuento = new System.Windows.Forms.CheckBox();
            this.tabProducto = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.txtClaveProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.cmbFamilias = new SistemaFarmacia.ControlesPersonalizados.ComboPersonalizado();
            this.tabImpuestos = new System.Windows.Forms.TabPage();
            this.btnQuitarImpuesto = new System.Windows.Forms.Button();
            this.btnAgregarImpuesto = new System.Windows.Forms.Button();
            this.gridImpuestos = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.IdImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.cmbImpuesto = new SistemaFarmacia.ControlesPersonalizados.ComboPersonalizado();
            this.tabCodigos = new System.Windows.Forms.TabPage();
            this.tbnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gridCodigoBarra = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigoBarra = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.tabPromocion = new System.Windows.Forms.TabPage();
            this.chkPromocion = new System.Windows.Forms.CheckBox();
            this.lblNotaPromocion = new System.Windows.Forms.Label();
            this.lblPrecioEspecial = new System.Windows.Forms.Label();
            this.nupPrecioPromocion = new System.Windows.Forms.NumericUpDown();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.nupCantidadPromocion = new System.Windows.Forms.NumericUpDown();
            this.tabProducto.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.tabImpuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).BeginInit();
            this.tabCodigos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigoBarra)).BeginInit();
            this.tabPromocion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecioPromocion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadPromocion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(402, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkAplicaDescuento
            // 
            this.chkAplicaDescuento.AutoSize = true;
            this.chkAplicaDescuento.Location = new System.Drawing.Point(296, 83);
            this.chkAplicaDescuento.Name = "chkAplicaDescuento";
            this.chkAplicaDescuento.Size = new System.Drawing.Size(108, 17);
            this.chkAplicaDescuento.TabIndex = 9;
            this.chkAplicaDescuento.Text = "Aplica descuento";
            this.chkAplicaDescuento.UseVisualStyleBackColor = true;
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.tabGeneral);
            this.tabProducto.Controls.Add(this.tabImpuestos);
            this.tabProducto.Controls.Add(this.tabCodigos);
            this.tabProducto.Controls.Add(this.tabPromocion);
            this.tabProducto.Location = new System.Drawing.Point(4, 4);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.SelectedIndex = 0;
            this.tabProducto.Size = new System.Drawing.Size(453, 248);
            this.tabProducto.TabIndex = 18;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.txtClaveProducto);
            this.tabGeneral.Controls.Add(this.lblDescripcion);
            this.tabGeneral.Controls.Add(this.txtDescripcion);
            this.tabGeneral.Controls.Add(this.lblPrecio);
            this.tabGeneral.Controls.Add(this.nudPrecio);
            this.tabGeneral.Controls.Add(this.lblClaveProducto);
            this.tabGeneral.Controls.Add(this.lblFamilia);
            this.tabGeneral.Controls.Add(this.cmbFamilias);
            this.tabGeneral.Controls.Add(this.chkAplicaDescuento);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(445, 222);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // txtClaveProducto
            // 
            this.txtClaveProducto.Location = new System.Drawing.Point(9, 80);
            this.txtClaveProducto.MaxLength = 6;
            this.txtClaveProducto.Name = "txtClaveProducto";
            this.txtClaveProducto.Size = new System.Drawing.Size(89, 20);
            this.txtClaveProducto.TabIndex = 15;
            this.txtClaveProducto.Leave += new System.EventHandler(this.txtClaveProducto_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 118);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(9, 134);
            this.txtDescripcion.MaxLength = 500;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(428, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(155, 64);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(158, 80);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 11;
            this.nudPrecio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblClaveProducto
            // 
            this.lblClaveProducto.AutoSize = true;
            this.lblClaveProducto.Location = new System.Drawing.Point(6, 64);
            this.lblClaveProducto.Name = "lblClaveProducto";
            this.lblClaveProducto.Size = new System.Drawing.Size(82, 13);
            this.lblClaveProducto.TabIndex = 9;
            this.lblClaveProducto.Text = "Clave producto:";
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(6, 13);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(112, 13);
            this.lblFamilia.TabIndex = 5;
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
            this.cmbFamilias.Location = new System.Drawing.Point(9, 29);
            this.cmbFamilias.Name = "cmbFamilias";
            this.cmbFamilias.Size = new System.Drawing.Size(428, 21);
            this.cmbFamilias.TabIndex = 4;
            // 
            // tabImpuestos
            // 
            this.tabImpuestos.Controls.Add(this.btnQuitarImpuesto);
            this.tabImpuestos.Controls.Add(this.btnAgregarImpuesto);
            this.tabImpuestos.Controls.Add(this.gridImpuestos);
            this.tabImpuestos.Controls.Add(this.lblImpuesto);
            this.tabImpuestos.Controls.Add(this.cmbImpuesto);
            this.tabImpuestos.Location = new System.Drawing.Point(4, 22);
            this.tabImpuestos.Name = "tabImpuestos";
            this.tabImpuestos.Padding = new System.Windows.Forms.Padding(3);
            this.tabImpuestos.Size = new System.Drawing.Size(445, 222);
            this.tabImpuestos.TabIndex = 1;
            this.tabImpuestos.Text = "Impuestos";
            this.tabImpuestos.UseVisualStyleBackColor = true;
            // 
            // btnQuitarImpuesto
            // 
            this.btnQuitarImpuesto.Location = new System.Drawing.Point(402, 98);
            this.btnQuitarImpuesto.Name = "btnQuitarImpuesto";
            this.btnQuitarImpuesto.Size = new System.Drawing.Size(27, 23);
            this.btnQuitarImpuesto.TabIndex = 22;
            this.btnQuitarImpuesto.Text = "-";
            this.btnQuitarImpuesto.UseVisualStyleBackColor = true;
            this.btnQuitarImpuesto.Click += new System.EventHandler(this.btnQuitarImpuesto_Click);
            // 
            // btnAgregarImpuesto
            // 
            this.btnAgregarImpuesto.Location = new System.Drawing.Point(402, 69);
            this.btnAgregarImpuesto.Name = "btnAgregarImpuesto";
            this.btnAgregarImpuesto.Size = new System.Drawing.Size(27, 23);
            this.btnAgregarImpuesto.TabIndex = 21;
            this.btnAgregarImpuesto.Text = "+";
            this.btnAgregarImpuesto.UseVisualStyleBackColor = true;
            this.btnAgregarImpuesto.Click += new System.EventHandler(this.btnAgregarImpuesto_Click);
            // 
            // gridImpuestos
            // 
            this.gridImpuestos.AllowUserToAddRows = false;
            this.gridImpuestos.AllowUserToDeleteRows = false;
            this.gridImpuestos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.gridImpuestos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridImpuestos.BackgroundColor = System.Drawing.Color.White;
            this.gridImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridImpuestos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpuestos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImpuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdImpuesto,
            this.Descripcion});
            this.gridImpuestos.EnableHeadersVisualStyles = false;
            this.gridImpuestos.Location = new System.Drawing.Point(9, 69);
            this.gridImpuestos.MultiSelect = false;
            this.gridImpuestos.Name = "gridImpuestos";
            this.gridImpuestos.ReadOnly = true;
            this.gridImpuestos.RowHeadersVisible = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpuestos.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gridImpuestos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImpuestos.RowTemplate.Height = 20;
            this.gridImpuestos.RowTemplate.ReadOnly = true;
            this.gridImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImpuestos.Size = new System.Drawing.Size(388, 134);
            this.gridImpuestos.TabIndex = 20;
            // 
            // IdImpuesto
            // 
            this.IdImpuesto.DataPropertyName = "IdImpuesto";
            dataGridViewCellStyle10.NullValue = null;
            this.IdImpuesto.DefaultCellStyle = dataGridViewCellStyle10;
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
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(6, 13);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(53, 13);
            this.lblImpuesto.TabIndex = 19;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbImpuesto.BackColor = System.Drawing.Color.White;
            this.cmbImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Location = new System.Drawing.Point(9, 29);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(236, 21);
            this.cmbImpuesto.TabIndex = 18;
            // 
            // tabCodigos
            // 
            this.tabCodigos.Controls.Add(this.tbnQuitar);
            this.tabCodigos.Controls.Add(this.btnAgregar);
            this.tabCodigos.Controls.Add(this.gridCodigoBarra);
            this.tabCodigos.Controls.Add(this.lblCodigoBarra);
            this.tabCodigos.Controls.Add(this.txtCodigoBarra);
            this.tabCodigos.Location = new System.Drawing.Point(4, 22);
            this.tabCodigos.Name = "tabCodigos";
            this.tabCodigos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCodigos.Size = new System.Drawing.Size(445, 222);
            this.tabCodigos.TabIndex = 2;
            this.tabCodigos.Text = "Códigos de barra";
            this.tabCodigos.UseVisualStyleBackColor = true;
            // 
            // tbnQuitar
            // 
            this.tbnQuitar.Location = new System.Drawing.Point(402, 98);
            this.tbnQuitar.Name = "tbnQuitar";
            this.tbnQuitar.Size = new System.Drawing.Size(27, 23);
            this.tbnQuitar.TabIndex = 17;
            this.tbnQuitar.Text = "-";
            this.tbnQuitar.UseVisualStyleBackColor = true;
            this.tbnQuitar.Click += new System.EventHandler(this.tbnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(402, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridCodigoBarra
            // 
            this.gridCodigoBarra.AllowUserToAddRows = false;
            this.gridCodigoBarra.AllowUserToDeleteRows = false;
            this.gridCodigoBarra.AllowUserToOrderColumns = true;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.gridCodigoBarra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gridCodigoBarra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCodigoBarra.BackgroundColor = System.Drawing.Color.White;
            this.gridCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridCodigoBarra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCodigoBarra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridCodigoBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCodigoBarra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoBarras});
            this.gridCodigoBarra.EnableHeadersVisualStyles = false;
            this.gridCodigoBarra.Location = new System.Drawing.Point(9, 69);
            this.gridCodigoBarra.MultiSelect = false;
            this.gridCodigoBarra.Name = "gridCodigoBarra";
            this.gridCodigoBarra.ReadOnly = true;
            this.gridCodigoBarra.RowHeadersVisible = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCodigoBarra.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.gridCodigoBarra.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCodigoBarra.RowTemplate.Height = 20;
            this.gridCodigoBarra.RowTemplate.ReadOnly = true;
            this.gridCodigoBarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCodigoBarra.Size = new System.Drawing.Size(388, 134);
            this.gridCodigoBarra.TabIndex = 15;
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.DataPropertyName = "CodigoBarras";
            this.CodigoBarras.HeaderText = "Código de barras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            // 
            // lblCodigoBarra
            // 
            this.lblCodigoBarra.AutoSize = true;
            this.lblCodigoBarra.Location = new System.Drawing.Point(6, 13);
            this.lblCodigoBarra.Name = "lblCodigoBarra";
            this.lblCodigoBarra.Size = new System.Drawing.Size(86, 13);
            this.lblCodigoBarra.TabIndex = 14;
            this.lblCodigoBarra.Text = "Código de Barra:";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(9, 29);
            this.txtCodigoBarra.MaxLength = 100;
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(388, 20);
            this.txtCodigoBarra.TabIndex = 13;
            // 
            // tabPromocion
            // 
            this.tabPromocion.Controls.Add(this.chkPromocion);
            this.tabPromocion.Controls.Add(this.lblNotaPromocion);
            this.tabPromocion.Controls.Add(this.lblPrecioEspecial);
            this.tabPromocion.Controls.Add(this.nupPrecioPromocion);
            this.tabPromocion.Controls.Add(this.lblCantidadProducto);
            this.tabPromocion.Controls.Add(this.nupCantidadPromocion);
            this.tabPromocion.Location = new System.Drawing.Point(4, 22);
            this.tabPromocion.Name = "tabPromocion";
            this.tabPromocion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPromocion.Size = new System.Drawing.Size(445, 222);
            this.tabPromocion.TabIndex = 3;
            this.tabPromocion.Text = "Promoción";
            this.tabPromocion.UseVisualStyleBackColor = true;
            // 
            // chkPromocion
            // 
            this.chkPromocion.AutoSize = true;
            this.chkPromocion.Location = new System.Drawing.Point(9, 122);
            this.chkPromocion.Name = "chkPromocion";
            this.chkPromocion.Size = new System.Drawing.Size(107, 17);
            this.chkPromocion.TabIndex = 24;
            this.chkPromocion.Text = "Aplica promoción";
            this.chkPromocion.UseVisualStyleBackColor = true;
            this.chkPromocion.CheckedChanged += new System.EventHandler(this.chkPromocion_CheckedChanged);
            // 
            // lblNotaPromocion
            // 
            this.lblNotaPromocion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotaPromocion.Location = new System.Drawing.Point(161, 29);
            this.lblNotaPromocion.Name = "lblNotaPromocion";
            this.lblNotaPromocion.Size = new System.Drawing.Size(264, 110);
            this.lblNotaPromocion.TabIndex = 23;
            this.lblNotaPromocion.Text = resources.GetString("lblNotaPromocion.Text");
            // 
            // lblPrecioEspecial
            // 
            this.lblPrecioEspecial.AutoSize = true;
            this.lblPrecioEspecial.Location = new System.Drawing.Point(6, 65);
            this.lblPrecioEspecial.Name = "lblPrecioEspecial";
            this.lblPrecioEspecial.Size = new System.Drawing.Size(82, 13);
            this.lblPrecioEspecial.TabIndex = 22;
            this.lblPrecioEspecial.Text = "Precio especial:";
            // 
            // nupPrecioPromocion
            // 
            this.nupPrecioPromocion.DecimalPlaces = 2;
            this.nupPrecioPromocion.Location = new System.Drawing.Point(9, 81);
            this.nupPrecioPromocion.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nupPrecioPromocion.Name = "nupPrecioPromocion";
            this.nupPrecioPromocion.Size = new System.Drawing.Size(120, 20);
            this.nupPrecioPromocion.TabIndex = 21;
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Location = new System.Drawing.Point(6, 13);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(52, 13);
            this.lblCantidadProducto.TabIndex = 20;
            this.lblCantidadProducto.Text = "Cantidad:";
            // 
            // nupCantidadPromocion
            // 
            this.nupCantidadPromocion.Location = new System.Drawing.Point(9, 29);
            this.nupCantidadPromocion.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nupCantidadPromocion.Name = "nupCantidadPromocion";
            this.nupCantidadPromocion.Size = new System.Drawing.Size(120, 20);
            this.nupCantidadPromocion.TabIndex = 12;
            // 
            // frmCatProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 320);
            this.Controls.Add(this.tabProducto);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmCatProducto";
            this.tabProducto.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.tabImpuestos.ResumeLayout(false);
            this.tabImpuestos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridImpuestos)).EndInit();
            this.tabCodigos.ResumeLayout(false);
            this.tabCodigos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigoBarra)).EndInit();
            this.tabPromocion.ResumeLayout(false);
            this.tabPromocion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecioPromocion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadPromocion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAplicaDescuento;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private System.Windows.Forms.TabControl tabProducto;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblClaveProducto;
        private System.Windows.Forms.Label lblFamilia;
        private ControlesPersonalizados.ComboPersonalizado cmbFamilias;
        private System.Windows.Forms.TabPage tabImpuestos;
        private System.Windows.Forms.Label lblImpuesto;
        private ControlesPersonalizados.ComboPersonalizado cmbImpuesto;
        private System.Windows.Forms.TabPage tabCodigos;
        private System.Windows.Forms.Button tbnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private ControlesPersonalizados.GridPersonalizado gridCodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
        private System.Windows.Forms.Label lblCodigoBarra;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Button btnQuitarImpuesto;
        private System.Windows.Forms.Button btnAgregarImpuesto;
        private ControlesPersonalizados.GridPersonalizado gridImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.TextBox txtClaveProducto;
        private System.Windows.Forms.TabPage tabPromocion;
        private System.Windows.Forms.CheckBox chkPromocion;
        private System.Windows.Forms.Label lblNotaPromocion;
        private System.Windows.Forms.Label lblPrecioEspecial;
        private System.Windows.Forms.NumericUpDown nupPrecioPromocion;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.NumericUpDown nupCantidadPromocion;
    }
}
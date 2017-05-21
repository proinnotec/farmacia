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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.cmbFamilias = new SistemaFarmacia.ControlesPersonalizados.ComboPersonalizado();
            this.lblClaveProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nudClaveProducto = new System.Windows.Forms.NumericUpDown();
            this.chkAplicaDescuento = new System.Windows.Forms.CheckBox();
            this.gridCodigoBarra = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnGuardar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnEliminar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.CodigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClaveProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigoBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(15, 131);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(419, 20);
            this.txtDescripcion.TabIndex = 1;
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
            this.cmbFamilias.Size = new System.Drawing.Size(446, 21);
            this.cmbFamilias.TabIndex = 2;
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
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(18, 184);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(120, 20);
            this.nudPrecio.TabIndex = 6;
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
            // nudClaveProducto
            // 
            this.nudClaveProducto.Location = new System.Drawing.Point(15, 75);
            this.nudClaveProducto.Name = "nudClaveProducto";
            this.nudClaveProducto.Size = new System.Drawing.Size(123, 20);
            this.nudClaveProducto.TabIndex = 8;
            // 
            // chkAplicaDescuento
            // 
            this.chkAplicaDescuento.AutoSize = true;
            this.chkAplicaDescuento.Location = new System.Drawing.Point(16, 222);
            this.chkAplicaDescuento.Name = "chkAplicaDescuento";
            this.chkAplicaDescuento.Size = new System.Drawing.Size(108, 17);
            this.chkAplicaDescuento.TabIndex = 9;
            this.chkAplicaDescuento.Text = "Aplica descuento";
            this.chkAplicaDescuento.UseVisualStyleBackColor = true;
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
            this.gridCodigoBarra.Location = new System.Drawing.Point(16, 306);
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
            this.gridCodigoBarra.Size = new System.Drawing.Size(387, 150);
            this.gridCodigoBarra.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Código de Barra:";
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(15, 270);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(387, 20);
            this.txtCodigoBarra.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(413, 306);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(27, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbnQuitar
            // 
            this.tbnQuitar.Location = new System.Drawing.Point(413, 335);
            this.tbnQuitar.Name = "tbnQuitar";
            this.tbnQuitar.Size = new System.Drawing.Size(27, 23);
            this.tbnQuitar.TabIndex = 14;
            this.tbnQuitar.Text = "-";
            this.tbnQuitar.UseVisualStyleBackColor = true;
            this.tbnQuitar.Click += new System.EventHandler(this.tbnQuitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(247, 473);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(328, 473);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(15, 473);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // CodigoBarras
            // 
            this.CodigoBarras.DataPropertyName = "CodigoBarras";
            this.CodigoBarras.HeaderText = "Código de barras";
            this.CodigoBarras.Name = "CodigoBarras";
            this.CodigoBarras.ReadOnly = true;
            // 
            // frmCatProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 508);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tbnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClaveProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCodigoBarra)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button tbnQuitar;
        private ControlesPersonalizados.BotonPersonalizado btnCancelar;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private ControlesPersonalizados.BotonPersonalizado btnEliminar;
        private System.Windows.Forms.NumericUpDown nudClaveProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras;
    }
}
namespace SistemaFarmacia.Vistas.Catalogos
{
    partial class frmListaProductos
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
            this.cmbFamilias = new SistemaFarmacia.ControlesPersonalizados.ComboPersonalizado();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.gridProductos = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.btnNuevo = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.ClaveProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFamiliaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AplicaDescuentoCatalogo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFamilias
            // 
            this.cmbFamilias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFamilias.BackColor = System.Drawing.Color.White;
            this.cmbFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFamilias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFamilias.FormattingEnabled = true;
            this.cmbFamilias.Location = new System.Drawing.Point(21, 60);
            this.cmbFamilias.Name = "cmbFamilias";
            this.cmbFamilias.Size = new System.Drawing.Size(754, 21);
            this.cmbFamilias.TabIndex = 0;
            this.cmbFamilias.SelectedIndexChanged += new System.EventHandler(this.cmbFamilias_SelectedIndexChanged);
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.Location = new System.Drawing.Point(21, 44);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(112, 13);
            this.lblFamilia.TabIndex = 1;
            this.lblFamilia.Text = "Familias de productos:";
            // 
            // gridProductos
            // 
            this.gridProductos.AllowUserToAddRows = false;
            this.gridProductos.AllowUserToDeleteRows = false;
            this.gridProductos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProductos.BackgroundColor = System.Drawing.Color.White;
            this.gridProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveProducto,
            this.IdFamiliaProducto,
            this.Descripcion,
            this.Precio,
            this.AplicaDescuentoCatalogo});
            this.gridProductos.EnableHeadersVisualStyles = false;
            this.gridProductos.Location = new System.Drawing.Point(21, 101);
            this.gridProductos.MultiSelect = false;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.ReadOnly = true;
            this.gridProductos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProductos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProductos.RowTemplate.Height = 20;
            this.gridProductos.RowTemplate.ReadOnly = true;
            this.gridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductos.Size = new System.Drawing.Size(754, 372);
            this.gridProductos.TabIndex = 2;
            this.gridProductos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellContentDoubleClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightGray;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(21, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ClaveProducto
            // 
            this.ClaveProducto.DataPropertyName = "ClaveProducto";
            this.ClaveProducto.FillWeight = 50.76142F;
            this.ClaveProducto.HeaderText = "ClaveProducto";
            this.ClaveProducto.Name = "ClaveProducto";
            this.ClaveProducto.ReadOnly = true;
            // 
            // IdFamiliaProducto
            // 
            this.IdFamiliaProducto.DataPropertyName = "IdFamiliaProducto";
            this.IdFamiliaProducto.HeaderText = "IdFamiliaProducto";
            this.IdFamiliaProducto.Name = "IdFamiliaProducto";
            this.IdFamiliaProducto.ReadOnly = true;
            this.IdFamiliaProducto.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 116.4129F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.FillWeight = 116.4129F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // AplicaDescuentoCatalogo
            // 
            this.AplicaDescuentoCatalogo.DataPropertyName = "AplicaDescuentoCatalogo";
            this.AplicaDescuentoCatalogo.FillWeight = 116.4129F;
            this.AplicaDescuentoCatalogo.HeaderText = "Descuento";
            this.AplicaDescuentoCatalogo.Name = "AplicaDescuentoCatalogo";
            this.AplicaDescuentoCatalogo.ReadOnly = true;
            this.AplicaDescuentoCatalogo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AplicaDescuentoCatalogo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 489);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.cmbFamilias);
            this.Name = "frmListaProductos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.ComboPersonalizado cmbFamilias;
        private System.Windows.Forms.Label lblFamilia;
        private ControlesPersonalizados.GridPersonalizado gridProductos;
        private ControlesPersonalizados.BotonPersonalizado btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFamiliaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AplicaDescuentoCatalogo;
    }
}
﻿namespace SistemaFarmacia.Vistas.Ventas
{
    partial class frmVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridVenta = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.gridImportes = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.Leyenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiarGrid = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnCortes = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnAplicarDescuento = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnGuardar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnRemover = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.ClaveProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVenta
            // 
            this.gridVenta.AllowUserToAddRows = false;
            this.gridVenta.AllowUserToDeleteRows = false;
            this.gridVenta.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVenta.BackgroundColor = System.Drawing.Color.White;
            this.gridVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveProducto,
            this.IdProducto,
            this.Producto,
            this.Existencia,
            this.Cantidad,
            this.Precio,
            this.Total});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridVenta.EnableHeadersVisualStyles = false;
            this.gridVenta.Location = new System.Drawing.Point(12, 56);
            this.gridVenta.MultiSelect = false;
            this.gridVenta.Name = "gridVenta";
            this.gridVenta.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridVenta.RowHeadersVisible = false;
            this.gridVenta.RowHeadersWidth = 50;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVenta.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gridVenta.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridVenta.RowTemplate.Height = 25;
            this.gridVenta.RowTemplate.ReadOnly = true;
            this.gridVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVenta.Size = new System.Drawing.Size(1242, 352);
            this.gridVenta.TabIndex = 0;
            this.gridVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVenta_CellDoubleClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(93, 17);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(932, 22);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBusqueda_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Búsqueda:";
            // 
            // ltbResultados
            // 
            this.ltbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.ItemHeight = 16;
            this.ltbResultados.Location = new System.Drawing.Point(93, 39);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(932, 116);
            this.ltbResultados.TabIndex = 36;
            this.ltbResultados.Visible = false;
            this.ltbResultados.Click += new System.EventHandler(this.ltbResultados_Click);
            this.ltbResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ltbResultados_KeyPress);
            // 
            // gridImportes
            // 
            this.gridImportes.AllowUserToAddRows = false;
            this.gridImportes.AllowUserToDeleteRows = false;
            this.gridImportes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.gridImportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridImportes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gridImportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridImportes.BackgroundColor = System.Drawing.Color.White;
            this.gridImportes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridImportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridImportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridImportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Leyenda,
            this.Importe});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridImportes.DefaultCellStyle = dataGridViewCellStyle13;
            this.gridImportes.EnableHeadersVisualStyles = false;
            this.gridImportes.Location = new System.Drawing.Point(914, 414);
            this.gridImportes.MultiSelect = false;
            this.gridImportes.Name = "gridImportes";
            this.gridImportes.ReadOnly = true;
            this.gridImportes.RowHeadersVisible = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImportes.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.gridImportes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridImportes.RowTemplate.Height = 35;
            this.gridImportes.RowTemplate.ReadOnly = true;
            this.gridImportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridImportes.Size = new System.Drawing.Size(340, 157);
            this.gridImportes.TabIndex = 40;
            // 
            // Leyenda
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Leyenda.DefaultCellStyle = dataGridViewCellStyle11;
            this.Leyenda.HeaderText = "";
            this.Leyenda.Name = "Leyenda";
            this.Leyenda.ReadOnly = true;
            // 
            // Importe
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Importe.DefaultCellStyle = dataGridViewCellStyle12;
            this.Importe.HeaderText = "";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // btnLimpiarGrid
            // 
            this.btnLimpiarGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimpiarGrid.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarGrid.BackgroundImage = global::SistemaFarmacia.Resource.cancel;
            this.btnLimpiarGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarGrid.Location = new System.Drawing.Point(77, 521);
            this.btnLimpiarGrid.Name = "btnLimpiarGrid";
            this.btnLimpiarGrid.Size = new System.Drawing.Size(50, 50);
            this.btnLimpiarGrid.TabIndex = 4;
            this.btnLimpiarGrid.UseVisualStyleBackColor = true;
            this.btnLimpiarGrid.Click += new System.EventHandler(this.btnLimpiarGrid_Click);
            // 
            // btnCortes
            // 
            this.btnCortes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCortes.BackColor = System.Drawing.Color.LightGray;
            this.btnCortes.BackgroundImage = global::SistemaFarmacia.Resource.registradora;
            this.btnCortes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCortes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCortes.Location = new System.Drawing.Point(12, 521);
            this.btnCortes.Name = "btnCortes";
            this.btnCortes.Size = new System.Drawing.Size(50, 50);
            this.btnCortes.TabIndex = 3;
            this.btnCortes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCortes.UseVisualStyleBackColor = true;
            this.btnCortes.Click += new System.EventHandler(this.btnCortes_Click);
            // 
            // btnAplicarDescuento
            // 
            this.btnAplicarDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicarDescuento.BackColor = System.Drawing.Color.LightGray;
            this.btnAplicarDescuento.BackgroundImage = global::SistemaFarmacia.Resource._new;
            this.btnAplicarDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplicarDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarDescuento.Location = new System.Drawing.Point(1148, 3);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(50, 50);
            this.btnAplicarDescuento.TabIndex = 1;
            this.btnAplicarDescuento.UseVisualStyleBackColor = true;
            this.btnAplicarDescuento.Click += new System.EventHandler(this.btnAplicarDescuento_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(858, 521);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemover.BackColor = System.Drawing.Color.LightGray;
            this.btnRemover.BackgroundImage = global::SistemaFarmacia.Resource.menos;
            this.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(1204, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(50, 50);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // ClaveProducto
            // 
            this.ClaveProducto.DataPropertyName = "ClaveProducto";
            this.ClaveProducto.HeaderText = "Clave";
            this.ClaveProducto.Name = "ClaveProducto";
            this.ClaveProducto.ReadOnly = true;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Descripcion";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Existencia
            // 
            this.Existencia.DataPropertyName = "Existencia";
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle4;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle5;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 576);
            this.Controls.Add(this.btnLimpiarGrid);
            this.Controls.Add(this.btnCortes);
            this.Controls.Add(this.btnAplicarDescuento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.gridImportes);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbResultados);
            this.Controls.Add(this.gridVenta);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridImportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.GridPersonalizado gridVenta;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbResultados;
        private ControlesPersonalizados.GridPersonalizado gridImportes;
        private ControlesPersonalizados.BotonPersonalizado btnRemover;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private ControlesPersonalizados.BotonPersonalizado btnAplicarDescuento;
        private ControlesPersonalizados.BotonPersonalizado btnCortes;
        private ControlesPersonalizados.BotonPersonalizado btnLimpiarGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leyenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}
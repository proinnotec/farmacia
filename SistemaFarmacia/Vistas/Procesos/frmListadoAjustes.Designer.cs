namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmListadoAjustes
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
            this.gridListadoAjustes = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.lblAnio = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.btnRecargar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevo = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnCancelar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.IdAjusteProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAjusteProductoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoAjuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ajuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridListadoAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListadoAjustes
            // 
            this.gridListadoAjustes.AllowUserToAddRows = false;
            this.gridListadoAjustes.AllowUserToDeleteRows = false;
            this.gridListadoAjustes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridListadoAjustes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListadoAjustes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListadoAjustes.BackgroundColor = System.Drawing.Color.White;
            this.gridListadoAjustes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListadoAjustes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListadoAjustes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridListadoAjustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListadoAjustes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAjusteProducto,
            this.IdAjusteProductoDetalle,
            this.fecha,
            this.IdTipoAjuste,
            this.Ajuste,
            this.IdProducto,
            this.ClaveProducto,
            this.DescripcionProducto,
            this.Cantidad,
            this.Descripcion,
            this.IdSucursal});
            this.gridListadoAjustes.EnableHeadersVisualStyles = false;
            this.gridListadoAjustes.Location = new System.Drawing.Point(9, 32);
            this.gridListadoAjustes.MultiSelect = false;
            this.gridListadoAjustes.Name = "gridListadoAjustes";
            this.gridListadoAjustes.ReadOnly = true;
            this.gridListadoAjustes.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListadoAjustes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridListadoAjustes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListadoAjustes.RowTemplate.Height = 20;
            this.gridListadoAjustes.RowTemplate.ReadOnly = true;
            this.gridListadoAjustes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListadoAjustes.Size = new System.Drawing.Size(817, 411);
            this.gridListadoAjustes.TabIndex = 27;
            this.gridListadoAjustes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListadoAjustes_CellClick);
            this.gridListadoAjustes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListadoAjustes_CellContentClick);
            this.gridListadoAjustes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridListadoAjustes_CellDoubleClick);
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(6, 4);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(119, 16);
            this.lblAnio.TabIndex = 26;
            this.lblAnio.Text = "Año de consulta";
            // 
            // nudAnio
            // 
            this.nudAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnio.Location = new System.Drawing.Point(131, 4);
            this.nudAnio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(70, 22);
            this.nudAnio.TabIndex = 25;
            this.nudAnio.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.nudAnio.ValueChanged += new System.EventHandler(this.nudAnio_ValueChanged);
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.LightGray;
            this.btnRecargar.BackgroundImage = global::SistemaFarmacia.Resource.reload;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(832, 168);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(50, 50);
            this.btnRecargar.TabIndex = 24;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightGray;
            this.btnNuevo.BackgroundImage = global::SistemaFarmacia.Resource._new;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(832, 32);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundImage = global::SistemaFarmacia.Resource.exit;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(832, 394);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // IdAjusteProducto
            // 
            this.IdAjusteProducto.DataPropertyName = "IdAjusteProducto";
            this.IdAjusteProducto.FillWeight = 12.70824F;
            this.IdAjusteProducto.HeaderText = "Id Ajuste";
            this.IdAjusteProducto.Name = "IdAjusteProducto";
            this.IdAjusteProducto.ReadOnly = true;
            // 
            // IdAjusteProductoDetalle
            // 
            this.IdAjusteProductoDetalle.DataPropertyName = "IdAjusteProductoDetalle";
            this.IdAjusteProductoDetalle.HeaderText = "Id Detalle";
            this.IdAjusteProductoDetalle.Name = "IdAjusteProductoDetalle";
            this.IdAjusteProductoDetalle.ReadOnly = true;
            this.IdAjusteProductoDetalle.Visible = false;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.FillWeight = 34.94395F;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // IdTipoAjuste
            // 
            this.IdTipoAjuste.DataPropertyName = "IdTipoAjuste";
            this.IdTipoAjuste.HeaderText = "Tipo Ajuste";
            this.IdTipoAjuste.Name = "IdTipoAjuste";
            this.IdTipoAjuste.ReadOnly = true;
            this.IdTipoAjuste.Visible = false;
            // 
            // Ajuste
            // 
            this.Ajuste.DataPropertyName = "Ajuste";
            this.Ajuste.FillWeight = 66.00714F;
            this.Ajuste.HeaderText = "Ajuste";
            this.Ajuste.Name = "Ajuste";
            this.Ajuste.ReadOnly = true;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // ClaveProducto
            // 
            this.ClaveProducto.DataPropertyName = "ClaveProducto";
            this.ClaveProducto.FillWeight = 19.97182F;
            this.ClaveProducto.HeaderText = "Clave Producto";
            this.ClaveProducto.Name = "ClaveProducto";
            this.ClaveProducto.ReadOnly = true;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.DataPropertyName = "DescripcionProducto";
            this.DescripcionProducto.FillWeight = 19.97182F;
            this.DescripcionProducto.HeaderText = "Producto";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.FillWeight = 19.97182F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 151.5104F;
            this.Descripcion.HeaderText = "Motivo";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IdSucursal
            // 
            this.IdSucursal.DataPropertyName = "IdSucursal";
            this.IdSucursal.HeaderText = "IdSucursal";
            this.IdSucursal.Name = "IdSucursal";
            this.IdSucursal.ReadOnly = true;
            this.IdSucursal.Visible = false;
            // 
            // frmListadoAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 455);
            this.Controls.Add(this.gridListadoAjustes);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmListadoAjustes";
            this.Text = "Ajustes de Productos";
            this.Load += new System.EventHandler(this.frmListadoAjustes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListadoAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private ControlesPersonalizados.BotonPersonalizado btnRecargar;
        private ControlesPersonalizados.BotonPersonalizado btnNuevo;
        private ControlesPersonalizados.BotonPersonalizado btnCancelar;
        private ControlesPersonalizados.GridPersonalizado gridListadoAjustes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAjusteProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAjusteProductoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAjuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ajuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSucursal;
    }
}
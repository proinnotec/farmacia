namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmEntradas
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
            this.gridListadoEntradas = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.IdEntradaProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAplica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRecargar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevo = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnActDes = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnCancelar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.lblAnio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridListadoEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gridListadoEntradas
            // 
            this.gridListadoEntradas.AllowUserToAddRows = false;
            this.gridListadoEntradas.AllowUserToDeleteRows = false;
            this.gridListadoEntradas.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridListadoEntradas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListadoEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListadoEntradas.BackgroundColor = System.Drawing.Color.White;
            this.gridListadoEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListadoEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListadoEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridListadoEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListadoEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEntradaProducto,
            this.FechaAplica,
            this.IdProveedor,
            this.Proveedor,
            this.EsActivo});
            this.gridListadoEntradas.EnableHeadersVisualStyles = false;
            this.gridListadoEntradas.Location = new System.Drawing.Point(5, 34);
            this.gridListadoEntradas.MultiSelect = false;
            this.gridListadoEntradas.Name = "gridListadoEntradas";
            this.gridListadoEntradas.ReadOnly = true;
            this.gridListadoEntradas.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListadoEntradas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridListadoEntradas.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListadoEntradas.RowTemplate.Height = 20;
            this.gridListadoEntradas.RowTemplate.ReadOnly = true;
            this.gridListadoEntradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListadoEntradas.Size = new System.Drawing.Size(635, 318);
            this.gridListadoEntradas.TabIndex = 7;
            // 
            // IdEntradaProducto
            // 
            this.IdEntradaProducto.DataPropertyName = "IdEntradaProducto";
            this.IdEntradaProducto.HeaderText = "Entrada";
            this.IdEntradaProducto.Name = "IdEntradaProducto";
            this.IdEntradaProducto.ReadOnly = true;
            // 
            // FechaAplica
            // 
            this.FechaAplica.DataPropertyName = "FechaAplica";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaAplica.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaAplica.HeaderText = "Fecha";
            this.FechaAplica.Name = "FechaAplica";
            this.FechaAplica.ReadOnly = true;
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "IdProveedor";
            this.IdProveedor.FillWeight = 137.2427F;
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "Proveedor";
            this.Proveedor.FillWeight = 103.1952F;
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.FalseValue = "0";
            this.EsActivo.FillWeight = 45.68527F;
            this.EsActivo.HeaderText = "Activo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            this.EsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EsActivo.TrueValue = "1";
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.LightGray;
            this.btnRecargar.BackgroundImage = global::SistemaFarmacia.Resource.reload;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(646, 125);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(50, 50);
            this.btnRecargar.TabIndex = 19;
            this.btnRecargar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightGray;
            this.btnNuevo.BackgroundImage = global::SistemaFarmacia.Resource._new;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(646, 11);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActDes
            // 
            this.btnActDes.BackColor = System.Drawing.Color.LightGray;
            this.btnActDes.BackgroundImage = global::SistemaFarmacia.Resource.bloquear;
            this.btnActDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActDes.Location = new System.Drawing.Point(646, 68);
            this.btnActDes.Name = "btnActDes";
            this.btnActDes.Size = new System.Drawing.Size(50, 50);
            this.btnActDes.TabIndex = 17;
            this.btnActDes.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundImage = global::SistemaFarmacia.Resource.exit;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(646, 301);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudAnio
            // 
            this.nudAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnio.Location = new System.Drawing.Point(137, 6);
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
            this.nudAnio.TabIndex = 20;
            this.nudAnio.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.Location = new System.Drawing.Point(12, 6);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(119, 16);
            this.lblAnio.TabIndex = 21;
            this.lblAnio.Text = "Año de consulta";
            // 
            // frmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 364);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnActDes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gridListadoEntradas);
            this.Name = "frmEntradas";
            this.Text = "Entradas de Productos";
            this.Load += new System.EventHandler(this.frmEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridListadoEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ControlesPersonalizados.GridPersonalizado gridListadoEntradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEntradaProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAplica;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private ControlesPersonalizados.BotonPersonalizado btnRecargar;
        private ControlesPersonalizados.BotonPersonalizado btnNuevo;
        private ControlesPersonalizados.BotonPersonalizado btnActDes;
        private ControlesPersonalizados.BotonPersonalizado btnCancelar;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Label lblAnio;
    }
}
namespace SistemaFarmacia.Vistas.Catalogos
{
    partial class frmCatDescuentos
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
            this.gridDescuentos = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.IdDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnRecargar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnNuevo = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnActDes = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnCancelar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.gridDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDescuentos
            // 
            this.gridDescuentos.AllowUserToAddRows = false;
            this.gridDescuentos.AllowUserToDeleteRows = false;
            this.gridDescuentos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridDescuentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDescuentos.BackgroundColor = System.Drawing.Color.White;
            this.gridDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDescuentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDescuentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDescuento,
            this.Descripcion,
            this.Porcentaje,
            this.EsActivo});
            this.gridDescuentos.EnableHeadersVisualStyles = false;
            this.gridDescuentos.Location = new System.Drawing.Point(12, 12);
            this.gridDescuentos.MultiSelect = false;
            this.gridDescuentos.Name = "gridDescuentos";
            this.gridDescuentos.ReadOnly = true;
            this.gridDescuentos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDescuentos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDescuentos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDescuentos.RowTemplate.Height = 20;
            this.gridDescuentos.RowTemplate.ReadOnly = true;
            this.gridDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDescuentos.Size = new System.Drawing.Size(638, 240);
            this.gridDescuentos.TabIndex = 6;
            this.gridDescuentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDescuentos_CellDoubleClick);
            // 
            // IdDescuento
            // 
            this.IdDescuento.DataPropertyName = "IdDescuento";
            this.IdDescuento.HeaderText = "IdDescuento";
            this.IdDescuento.Name = "IdDescuento";
            this.IdDescuento.ReadOnly = true;
            this.IdDescuento.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 137.2427F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "Porcentaje";
            this.Porcentaje.FillWeight = 103.1952F;
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
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
            this.btnRecargar.Location = new System.Drawing.Point(656, 130);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(50, 50);
            this.btnRecargar.TabIndex = 15;
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
            this.btnNuevo.Location = new System.Drawing.Point(656, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 14;
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
            this.btnActDes.Location = new System.Drawing.Point(656, 71);
            this.btnActDes.Name = "btnActDes";
            this.btnActDes.Size = new System.Drawing.Size(50, 50);
            this.btnActDes.TabIndex = 13;
            this.btnActDes.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundImage = global::SistemaFarmacia.Resource.exit;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(656, 202);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCatDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 260);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnActDes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gridDescuentos);
            this.Name = "frmCatDescuentos";
            this.Text = "Catálogo de Descuentos";
            this.Load += new System.EventHandler(this.frmCatDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDescuentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.GridPersonalizado gridDescuentos;
        private ControlesPersonalizados.BotonPersonalizado btnRecargar;
        private ControlesPersonalizados.BotonPersonalizado btnNuevo;
        private ControlesPersonalizados.BotonPersonalizado btnActDes;
        private ControlesPersonalizados.BotonPersonalizado btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
    }
}
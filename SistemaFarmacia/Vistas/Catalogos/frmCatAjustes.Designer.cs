namespace SistemaFarmacia.Vistas.Catalogos
{
    partial class frmCatAjustes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRecargar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnActDes = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnCancelar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnGuardar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.gridTiposAjustes = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.IdTipoAjuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAjuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextoTipoAjuste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipoAjuste = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbTipoAjuste = new System.Windows.Forms.ComboBox();
            this.btnNuevo = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.gridTiposAjustes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.LightGray;
            this.btnRecargar.BackgroundImage = global::SistemaFarmacia.Resource.reload;
            this.btnRecargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.Location = new System.Drawing.Point(521, 119);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(50, 50);
            this.btnRecargar.TabIndex = 17;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnActDes
            // 
            this.btnActDes.BackColor = System.Drawing.Color.LightGray;
            this.btnActDes.BackgroundImage = global::SistemaFarmacia.Resource.bloquear;
            this.btnActDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActDes.Location = new System.Drawing.Point(521, 63);
            this.btnActDes.Name = "btnActDes";
            this.btnActDes.Size = new System.Drawing.Size(50, 50);
            this.btnActDes.TabIndex = 15;
            this.btnActDes.UseVisualStyleBackColor = false;
            this.btnActDes.Click += new System.EventHandler(this.btnActDes_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundImage = global::SistemaFarmacia.Resource.exit;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(521, 253);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.BackgroundImage = global::SistemaFarmacia.Resource.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(521, 195);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gridTiposAjustes
            // 
            this.gridTiposAjustes.AllowUserToAddRows = false;
            this.gridTiposAjustes.AllowUserToDeleteRows = false;
            this.gridTiposAjustes.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.gridTiposAjustes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gridTiposAjustes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTiposAjustes.BackgroundColor = System.Drawing.Color.White;
            this.gridTiposAjustes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTiposAjustes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTiposAjustes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gridTiposAjustes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTiposAjustes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTipoAjuste,
            this.Descripcion,
            this.TipoAjuste,
            this.TextoTipoAjuste,
            this.EsActivo});
            this.gridTiposAjustes.EnableHeadersVisualStyles = false;
            this.gridTiposAjustes.Location = new System.Drawing.Point(5, 7);
            this.gridTiposAjustes.MultiSelect = false;
            this.gridTiposAjustes.Name = "gridTiposAjustes";
            this.gridTiposAjustes.ReadOnly = true;
            this.gridTiposAjustes.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTiposAjustes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gridTiposAjustes.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTiposAjustes.RowTemplate.Height = 20;
            this.gridTiposAjustes.RowTemplate.ReadOnly = true;
            this.gridTiposAjustes.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gridTiposAjustes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTiposAjustes.Size = new System.Drawing.Size(510, 162);
            this.gridTiposAjustes.TabIndex = 18;
            this.gridTiposAjustes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTiposAjustes_CellClick);
            this.gridTiposAjustes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTiposAjustes_CellContentClick);
            // 
            // IdTipoAjuste
            // 
            this.IdTipoAjuste.DataPropertyName = "IdTipoAjuste";
            this.IdTipoAjuste.FillWeight = 64.2978F;
            this.IdTipoAjuste.HeaderText = "IdTipoAjuste";
            this.IdTipoAjuste.Name = "IdTipoAjuste";
            this.IdTipoAjuste.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 207.1066F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // TipoAjuste
            // 
            this.TipoAjuste.DataPropertyName = "TipoAjuste";
            this.TipoAjuste.HeaderText = "Tipo de Ajuste";
            this.TipoAjuste.Name = "TipoAjuste";
            this.TipoAjuste.ReadOnly = true;
            this.TipoAjuste.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoAjuste.Visible = false;
            // 
            // TextoTipoAjuste
            // 
            this.TextoTipoAjuste.DataPropertyName = "TextoTipoAjuste";
            this.TextoTipoAjuste.FillWeight = 64.2978F;
            this.TextoTipoAjuste.HeaderText = "Ajuste";
            this.TextoTipoAjuste.Name = "TextoTipoAjuste";
            this.TextoTipoAjuste.ReadOnly = true;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.FillWeight = 64.2978F;
            this.EsActivo.HeaderText = "Activo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            this.EsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(5, 195);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(95, 16);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblTipoAjuste
            // 
            this.lblTipoAjuste.AutoSize = true;
            this.lblTipoAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblTipoAjuste.Location = new System.Drawing.Point(5, 253);
            this.lblTipoAjuste.Name = "lblTipoAjuste";
            this.lblTipoAjuste.Size = new System.Drawing.Size(113, 16);
            this.lblTipoAjuste.TabIndex = 20;
            this.lblTipoAjuste.Text = "Tipo de Ajuste:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(122, 195);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(393, 22);
            this.txtDescripcion.TabIndex = 21;
            // 
            // cmbTipoAjuste
            // 
            this.cmbTipoAjuste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoAjuste.BackColor = System.Drawing.Color.White;
            this.cmbTipoAjuste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAjuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoAjuste.FormattingEnabled = true;
            this.cmbTipoAjuste.Location = new System.Drawing.Point(122, 247);
            this.cmbTipoAjuste.Name = "cmbTipoAjuste";
            this.cmbTipoAjuste.Size = new System.Drawing.Size(204, 24);
            this.cmbTipoAjuste.TabIndex = 22;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightGray;
            this.btnNuevo.BackgroundImage = global::SistemaFarmacia.Resource._new;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(521, 7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 50);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCatAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 312);
            this.Controls.Add(this.cmbTipoAjuste);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblTipoAjuste);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.gridTiposAjustes);
            this.Controls.Add(this.btnRecargar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnActDes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmCatAjustes";
            this.Text = "Catálogo de Tipos de Ajustes";
            this.Load += new System.EventHandler(this.frmCatAjustes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTiposAjustes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesPersonalizados.BotonPersonalizado btnRecargar;
        private ControlesPersonalizados.BotonPersonalizado btnActDes;
        private ControlesPersonalizados.BotonPersonalizado btnCancelar;
        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private ControlesPersonalizados.GridPersonalizado gridTiposAjustes;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipoAjuste;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbTipoAjuste;
        private ControlesPersonalizados.BotonPersonalizado btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoAjuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAjuste;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextoTipoAjuste;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
    }
}
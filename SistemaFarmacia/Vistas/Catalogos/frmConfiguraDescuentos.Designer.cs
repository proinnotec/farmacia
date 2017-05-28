namespace SistemaFarmacia.Vistas.Catalogos
{
    partial class frmConfiguraDescuentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAgregar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.gridConfiguracionDescuentos = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.IdDescuentoConfiguracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbOpciones = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnActDes = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfiguracionDescuentos)).BeginInit();
            this.gpbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.lblPorcentaje);
            this.gpbDatos.Controls.Add(this.lblDescripcion);
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(9, 0);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(598, 52);
            this.gpbDatos.TabIndex = 0;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos del descuento";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(6, 22);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(82, 16);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "porcentaje";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(115, 22);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 16);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "descripción";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.BackgroundImage = global::SistemaFarmacia.Resource.mas1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(613, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 50);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gridConfiguracionDescuentos
            // 
            this.gridConfiguracionDescuentos.AllowUserToAddRows = false;
            this.gridConfiguracionDescuentos.AllowUserToDeleteRows = false;
            this.gridConfiguracionDescuentos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridConfiguracionDescuentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridConfiguracionDescuentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridConfiguracionDescuentos.BackgroundColor = System.Drawing.Color.White;
            this.gridConfiguracionDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridConfiguracionDescuentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConfiguracionDescuentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridConfiguracionDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConfiguracionDescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDescuentoConfiguracion,
            this.IdDescuento,
            this.IdDia,
            this.Dia,
            this.HoraInicio,
            this.HoraFinal,
            this.EsActivo});
            this.gridConfiguracionDescuentos.EnableHeadersVisualStyles = false;
            this.gridConfiguracionDescuentos.Location = new System.Drawing.Point(9, 167);
            this.gridConfiguracionDescuentos.MultiSelect = false;
            this.gridConfiguracionDescuentos.Name = "gridConfiguracionDescuentos";
            this.gridConfiguracionDescuentos.ReadOnly = true;
            this.gridConfiguracionDescuentos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConfiguracionDescuentos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridConfiguracionDescuentos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConfiguracionDescuentos.RowTemplate.Height = 20;
            this.gridConfiguracionDescuentos.RowTemplate.ReadOnly = true;
            this.gridConfiguracionDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConfiguracionDescuentos.Size = new System.Drawing.Size(598, 214);
            this.gridConfiguracionDescuentos.TabIndex = 7;
            this.gridConfiguracionDescuentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConfiguracionDescuentos_CellClick);
            // 
            // IdDescuentoConfiguracion
            // 
            this.IdDescuentoConfiguracion.DataPropertyName = "IdDescuentoConfiguracion";
            this.IdDescuentoConfiguracion.HeaderText = "IdDescuentoConfiguracion";
            this.IdDescuentoConfiguracion.Name = "IdDescuentoConfiguracion";
            this.IdDescuentoConfiguracion.ReadOnly = true;
            this.IdDescuentoConfiguracion.Visible = false;
            // 
            // IdDescuento
            // 
            this.IdDescuento.DataPropertyName = "IdDescuento";
            this.IdDescuento.HeaderText = "IdDescuento";
            this.IdDescuento.Name = "IdDescuento";
            this.IdDescuento.ReadOnly = true;
            this.IdDescuento.Visible = false;
            // 
            // IdDia
            // 
            this.IdDia.DataPropertyName = "IdDia";
            this.IdDia.HeaderText = "IdDia";
            this.IdDia.Name = "IdDia";
            this.IdDia.ReadOnly = true;
            this.IdDia.Visible = false;
            // 
            // Dia
            // 
            this.Dia.DataPropertyName = "Dia";
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.DataPropertyName = "HoraInicio";
            dataGridViewCellStyle3.Format = "T";
            dataGridViewCellStyle3.NullValue = null;
            this.HoraInicio.DefaultCellStyle = dataGridViewCellStyle3;
            this.HoraInicio.HeaderText = "Hora de Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFinal
            // 
            this.HoraFinal.DataPropertyName = "HoraFin";
            dataGridViewCellStyle4.Format = "T";
            dataGridViewCellStyle4.NullValue = null;
            this.HoraFinal.DefaultCellStyle = dataGridViewCellStyle4;
            this.HoraFinal.HeaderText = "Hora Final";
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.ReadOnly = true;
            // 
            // EsActivo
            // 
            this.EsActivo.DataPropertyName = "EsActivo";
            this.EsActivo.HeaderText = "Activo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            // 
            // gpbOpciones
            // 
            this.gpbOpciones.Controls.Add(this.label2);
            this.gpbOpciones.Controls.Add(this.label1);
            this.gpbOpciones.Controls.Add(this.lblDia);
            this.gpbOpciones.Controls.Add(this.dtpFin);
            this.gpbOpciones.Controls.Add(this.dtpInicio);
            this.gpbOpciones.Controls.Add(this.cmbDia);
            this.gpbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpciones.Location = new System.Drawing.Point(9, 58);
            this.gpbOpciones.Name = "gpbOpciones";
            this.gpbOpciones.Size = new System.Drawing.Size(598, 88);
            this.gpbOpciones.TabIndex = 2;
            this.gpbOpciones.TabStop = false;
            this.gpbOpciones.Text = "Configure el descuento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hora de Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hora de Inicio";
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(6, 34);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(32, 16);
            this.lblDia.TabIndex = 15;
            this.lblDia.Text = "Día";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(406, 55);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.ShowUpDown = true;
            this.dtpFin.Size = new System.Drawing.Size(164, 22);
            this.dtpFin.TabIndex = 14;
            this.dtpFin.Value = new System.DateTime(2017, 5, 25, 23, 59, 59, 0);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicio.Location = new System.Drawing.Point(204, 55);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(164, 22);
            this.dtpInicio.TabIndex = 13;
            this.dtpInicio.Value = new System.DateTime(2017, 5, 25, 0, 0, 0, 0);
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(6, 53);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(164, 24);
            this.cmbDia.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundImage = global::SistemaFarmacia.Resource.exit;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(613, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActDes
            // 
            this.btnActDes.BackColor = System.Drawing.Color.LightGray;
            this.btnActDes.BackgroundImage = global::SistemaFarmacia.Resource.bloquear;
            this.btnActDes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActDes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActDes.Location = new System.Drawing.Point(613, 167);
            this.btnActDes.Name = "btnActDes";
            this.btnActDes.Size = new System.Drawing.Size(50, 50);
            this.btnActDes.TabIndex = 14;
            this.btnActDes.UseVisualStyleBackColor = false;
            this.btnActDes.Click += new System.EventHandler(this.btnActDes_Click);
            // 
            // frmConfiguraDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 392);
            this.Controls.Add(this.btnActDes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gpbOpciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gridConfiguracionDescuentos);
            this.Controls.Add(this.gpbDatos);
            this.Name = "frmConfiguraDescuentos";
            this.Text = "Configuración de Descuentos";
            this.Load += new System.EventHandler(this.frmConfiguraDescuentos_Load);
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfiguracionDescuentos)).EndInit();
            this.gpbOpciones.ResumeLayout(false);
            this.gpbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblDescripcion;
        private ControlesPersonalizados.GridPersonalizado gridConfiguracionDescuentos;
        private ControlesPersonalizados.BotonPersonalizado btnAgregar;
        private System.Windows.Forms.GroupBox gpbOpciones;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescuentoConfiguracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private ControlesPersonalizados.BotonPersonalizado btnCancelar;
        private ControlesPersonalizados.BotonPersonalizado btnActDes;
    }
}
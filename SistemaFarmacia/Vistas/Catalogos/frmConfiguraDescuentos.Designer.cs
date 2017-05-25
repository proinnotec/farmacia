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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnQuitar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.btnAgregar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.gridConfiguracionDescuentos = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.IdDescuentoConfiguracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaAplica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EsActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gpbOpciones = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbDia = new System.Windows.Forms.ComboBox();
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
            this.gpbDatos.Size = new System.Drawing.Size(598, 51);
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
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.LightGray;
            this.btnQuitar.BackgroundImage = global::SistemaFarmacia.Resource.menos;
            this.btnQuitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(613, 167);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(50, 50);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.BackgroundImage = global::SistemaFarmacia.Resource.mas1;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(613, 52);
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
            this.DiaAplica,
            this.HoraInicio,
            this.HoraFinal,
            this.EsActivo});
            this.gridConfiguracionDescuentos.EnableHeadersVisualStyles = false;
            this.gridConfiguracionDescuentos.Location = new System.Drawing.Point(9, 115);
            this.gridConfiguracionDescuentos.MultiSelect = false;
            this.gridConfiguracionDescuentos.Name = "gridConfiguracionDescuentos";
            this.gridConfiguracionDescuentos.ReadOnly = true;
            this.gridConfiguracionDescuentos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConfiguracionDescuentos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridConfiguracionDescuentos.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConfiguracionDescuentos.RowTemplate.Height = 20;
            this.gridConfiguracionDescuentos.RowTemplate.ReadOnly = true;
            this.gridConfiguracionDescuentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridConfiguracionDescuentos.Size = new System.Drawing.Size(598, 214);
            this.gridConfiguracionDescuentos.TabIndex = 7;
            // 
            // IdDescuentoConfiguracion
            // 
            this.IdDescuentoConfiguracion.HeaderText = "IdDescuentoCOnfiguracion";
            this.IdDescuentoConfiguracion.Name = "IdDescuentoConfiguracion";
            this.IdDescuentoConfiguracion.ReadOnly = true;
            this.IdDescuentoConfiguracion.Visible = false;
            // 
            // IdDescuento
            // 
            this.IdDescuento.HeaderText = "IdDescuento";
            this.IdDescuento.Name = "IdDescuento";
            this.IdDescuento.ReadOnly = true;
            this.IdDescuento.Visible = false;
            // 
            // DiaAplica
            // 
            this.DiaAplica.HeaderText = "Día que Aplica";
            this.DiaAplica.Name = "DiaAplica";
            this.DiaAplica.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora de Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFinal
            // 
            this.HoraFinal.HeaderText = "Hora Final";
            this.HoraFinal.Name = "HoraFinal";
            this.HoraFinal.ReadOnly = true;
            // 
            // EsActivo
            // 
            this.EsActivo.HeaderText = "Activo";
            this.EsActivo.Name = "EsActivo";
            this.EsActivo.ReadOnly = true;
            // 
            // gpbOpciones
            // 
            this.gpbOpciones.Controls.Add(this.dtpFin);
            this.gpbOpciones.Controls.Add(this.dtpInicio);
            this.gpbOpciones.Controls.Add(this.cmbDia);
            this.gpbOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpciones.Location = new System.Drawing.Point(9, 58);
            this.gpbOpciones.Name = "gpbOpciones";
            this.gpbOpciones.Size = new System.Drawing.Size(598, 51);
            this.gpbOpciones.TabIndex = 2;
            this.gpbOpciones.TabStop = false;
            this.gpbOpciones.Text = "Configure el descuento";
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(442, 19);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(121, 22);
            this.dtpFin.TabIndex = 14;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicio.Location = new System.Drawing.Point(224, 19);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(121, 22);
            this.dtpInicio.TabIndex = 13;
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(6, 21);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(121, 24);
            this.cmbDia.TabIndex = 12;
            // 
            // frmConfiguraDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 338);
            this.Controls.Add(this.gpbOpciones);
            this.Controls.Add(this.btnQuitar);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblDescripcion;
        private ControlesPersonalizados.GridPersonalizado gridConfiguracionDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescuentoConfiguracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaAplica;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsActivo;
        private ControlesPersonalizados.BotonPersonalizado btnAgregar;
        private ControlesPersonalizados.BotonPersonalizado btnQuitar;
        private System.Windows.Forms.GroupBox gpbOpciones;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}
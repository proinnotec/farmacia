namespace SistemaFarmacia.Vistas.Ventas
{
    partial class frmRepCortesCaja
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
            this.crvReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblDel = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.gpbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvReporte
            // 
            this.crvReporte.ActiveViewIndex = -1;
            this.crvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporte.Location = new System.Drawing.Point(0, 86);
            this.crvReporte.Name = "crvReporte";
            this.crvReporte.ShowCloseButton = false;
            this.crvReporte.ShowCopyButton = false;
            this.crvReporte.ShowParameterPanelButton = false;
            this.crvReporte.ShowRefreshButton = false;
            this.crvReporte.Size = new System.Drawing.Size(1082, 511);
            this.crvReporte.TabIndex = 1;
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbConsulta.Controls.Add(this.lblAl);
            this.gpbConsulta.Controls.Add(this.lblDel);
            this.gpbConsulta.Controls.Add(this.dtpFechaFin);
            this.gpbConsulta.Controls.Add(this.btnImprimir);
            this.gpbConsulta.Controls.Add(this.cmbVendedores);
            this.gpbConsulta.Controls.Add(this.chbTodos);
            this.gpbConsulta.Controls.Add(this.lblFecha);
            this.gpbConsulta.Controls.Add(this.dtpFechaInicio);
            this.gpbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsulta.Location = new System.Drawing.Point(0, 0);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(1082, 82);
            this.gpbConsulta.TabIndex = 0;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Parámetros de Consulta";
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(173, 48);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(26, 16);
            this.lblAl.TabIndex = 27;
            this.lblAl.Text = "Al:";
            // 
            // lblDel
            // 
            this.lblDel.AutoSize = true;
            this.lblDel.Location = new System.Drawing.Point(6, 48);
            this.lblDel.Name = "lblDel";
            this.lblDel.Size = new System.Drawing.Size(36, 16);
            this.lblDel.TabIndex = 26;
            this.lblDel.Text = "Del:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(201, 45);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaFin.TabIndex = 25;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.LightGray;
            this.btnImprimir.BackgroundImage = global::SistemaFarmacia.Resource.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1026, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(378, 45);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(238, 24);
            this.cmbVendedores.TabIndex = 11;
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Checked = true;
            this.chbTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTodos.Location = new System.Drawing.Point(381, 17);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(186, 20);
            this.chbTodos.TabIndex = 10;
            this.chbTodos.Text = "Todos los Vendedores";
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(47, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(219, 16);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Seleccione el rango de fechas";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(42, 45);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(125, 22);
            this.dtpFechaInicio.TabIndex = 5;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // frmRepCortesCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 596);
            this.Controls.Add(this.crvReporte);
            this.Controls.Add(this.gpbConsulta);
            this.Name = "frmRepCortesCaja";
            this.Text = "Reporte de Ventas por Cortes de Caja";
            this.Load += new System.EventHandler(this.frmRepCortesCaja_Load);
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.CheckBox chbTodos;
        private ControlesPersonalizados.BotonPersonalizado btnImprimir;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblDel;
    }
}
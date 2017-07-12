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
            this.btnImprimir = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
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
            this.crvReporte.Size = new System.Drawing.Size(999, 508);
            this.crvReporte.TabIndex = 1;
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbConsulta.Controls.Add(this.btnImprimir);
            this.gpbConsulta.Controls.Add(this.cmbVendedores);
            this.gpbConsulta.Controls.Add(this.chbTodos);
            this.gpbConsulta.Controls.Add(this.lblFecha);
            this.gpbConsulta.Controls.Add(this.dtpFecha);
            this.gpbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsulta.Location = new System.Drawing.Point(0, 0);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(999, 82);
            this.gpbConsulta.TabIndex = 0;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Parámetros de Consulta";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.LightGray;
            this.btnImprimir.BackgroundImage = global::SistemaFarmacia.Resource.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(943, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(270, 45);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(238, 24);
            this.cmbVendedores.TabIndex = 11;
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Checked = true;
            this.chbTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTodos.Location = new System.Drawing.Point(273, 17);
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
            this.lblFecha.Location = new System.Drawing.Point(80, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(129, 16);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Seleccione el día";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(83, 45);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(125, 22);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // frmRepCortesCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 593);
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
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.CheckBox chbTodos;
        private ControlesPersonalizados.BotonPersonalizado btnImprimir;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporte;
    }
}
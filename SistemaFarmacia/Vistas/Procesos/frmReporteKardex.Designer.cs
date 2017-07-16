namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmReporteKardex
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
            this.crvKardex = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnImprimir = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.chbTipoMov = new System.Windows.Forms.CheckBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblAl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpAl = new System.Windows.Forms.DateTimePicker();
            this.dtpDel = new System.Windows.Forms.DateTimePicker();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.gpbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvKardex
            // 
            this.crvKardex.ActiveViewIndex = -1;
            this.crvKardex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvKardex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvKardex.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvKardex.Location = new System.Drawing.Point(0, 84);
            this.crvKardex.Name = "crvKardex";
            this.crvKardex.ShowCloseButton = false;
            this.crvKardex.ShowCopyButton = false;
            this.crvKardex.ShowParameterPanelButton = false;
            this.crvKardex.ShowRefreshButton = false;
            this.crvKardex.Size = new System.Drawing.Size(1084, 511);
            this.crvKardex.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.LightGray;
            this.btnImprimir.BackgroundImage = global::SistemaFarmacia.Resource.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1030, 7);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.Controls.Add(this.chbTipoMov);
            this.gpbConsulta.Controls.Add(this.chbTodos);
            this.gpbConsulta.Controls.Add(this.txtBusqueda);
            this.gpbConsulta.Controls.Add(this.lblAl);
            this.gpbConsulta.Controls.Add(this.label1);
            this.gpbConsulta.Controls.Add(this.lblFecha);
            this.gpbConsulta.Controls.Add(this.dtpAl);
            this.gpbConsulta.Controls.Add(this.dtpDel);
            this.gpbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsulta.Location = new System.Drawing.Point(3, 0);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Size = new System.Drawing.Size(1021, 78);
            this.gpbConsulta.TabIndex = 24;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Parámetros de consulta";
            // 
            // chbTipoMov
            // 
            this.chbTipoMov.AutoSize = true;
            this.chbTipoMov.Location = new System.Drawing.Point(771, 24);
            this.chbTipoMov.Name = "chbTipoMov";
            this.chbTipoMov.Size = new System.Drawing.Size(244, 20);
            this.chbTipoMov.TabIndex = 28;
            this.chbTipoMov.Text = "Agrupar por tipo de movimiento";
            this.chbTipoMov.UseVisualStyleBackColor = true;
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Checked = true;
            this.chbTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTodos.Location = new System.Drawing.Point(348, 24);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(192, 20);
            this.chbTodos.TabIndex = 27;
            this.chbTodos.Text = "Ver todos los productos";
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(333, 50);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(682, 22);
            this.txtBusqueda.TabIndex = 25;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtBusqueda_PreviewKeyDown);
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(173, 49);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(26, 16);
            this.lblAl.TabIndex = 4;
            this.lblAl.Text = "Al:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Del:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(106, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(207, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Seleccionar rango de fechas";
            // 
            // dtpAl
            // 
            this.dtpAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAl.Location = new System.Drawing.Point(199, 49);
            this.dtpAl.Name = "dtpAl";
            this.dtpAl.Size = new System.Drawing.Size(125, 22);
            this.dtpAl.TabIndex = 1;
            // 
            // dtpDel
            // 
            this.dtpDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDel.Location = new System.Drawing.Point(38, 49);
            this.dtpDel.Name = "dtpDel";
            this.dtpDel.Size = new System.Drawing.Size(125, 22);
            this.dtpDel.TabIndex = 0;
            // 
            // ltbResultados
            // 
            this.ltbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.ItemHeight = 16;
            this.ltbResultados.Location = new System.Drawing.Point(336, 73);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(682, 100);
            this.ltbResultados.TabIndex = 26;
            this.ltbResultados.Visible = false;
            this.ltbResultados.Click += new System.EventHandler(this.ltbResultados_Click);
            this.ltbResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ltbResultados_KeyPress);
            // 
            // frmReporteKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 596);
            this.Controls.Add(this.ltbResultados);
            this.Controls.Add(this.gpbConsulta);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.crvKardex);
            this.Name = "frmReporteKardex";
            this.Text = "Kárdex";
            this.Load += new System.EventHandler(this.frmReporteKardex_Load);
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvKardex;
        private ControlesPersonalizados.BotonPersonalizado btnImprimir;
        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.DateTimePicker dtpAl;
        private System.Windows.Forms.DateTimePicker dtpDel;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ListBox ltbResultados;
        private System.Windows.Forms.CheckBox chbTodos;
        private System.Windows.Forms.CheckBox chbTipoMov;
    }
}
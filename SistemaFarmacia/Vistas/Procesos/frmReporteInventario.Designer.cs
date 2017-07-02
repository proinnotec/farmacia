namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmReporteInventario
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
            this.crvInventario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gpbParametros = new System.Windows.Forms.GroupBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnImprimir = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.ltbResultados = new System.Windows.Forms.ListBox();
            this.gpbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvInventario
            // 
            this.crvInventario.ActiveViewIndex = -1;
            this.crvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInventario.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInventario.Location = new System.Drawing.Point(0, 89);
            this.crvInventario.Name = "crvInventario";
            this.crvInventario.ShowCloseButton = false;
            this.crvInventario.ShowCopyButton = false;
            this.crvInventario.ShowParameterPanelButton = false;
            this.crvInventario.ShowRefreshButton = false;
            this.crvInventario.Size = new System.Drawing.Size(1084, 507);
            this.crvInventario.TabIndex = 0;
            // 
            // gpbParametros
            // 
            this.gpbParametros.Controls.Add(this.chbTodos);
            this.gpbParametros.Controls.Add(this.txtBusqueda);
            this.gpbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbParametros.Location = new System.Drawing.Point(4, 5);
            this.gpbParametros.Name = "gpbParametros";
            this.gpbParametros.Size = new System.Drawing.Size(1021, 78);
            this.gpbParametros.TabIndex = 1;
            this.gpbParametros.TabStop = false;
            this.gpbParametros.Text = "Parámetros de Consulta";
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Checked = true;
            this.chbTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTodos.Location = new System.Drawing.Point(259, 20);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(192, 20);
            this.chbTodos.TabIndex = 30;
            this.chbTodos.Text = "Ver todos los productos";
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(6, 47);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(682, 22);
            this.txtBusqueda.TabIndex = 28;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
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
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ltbResultados
            // 
            this.ltbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbResultados.FormattingEnabled = true;
            this.ltbResultados.ItemHeight = 16;
            this.ltbResultados.Location = new System.Drawing.Point(10, 76);
            this.ltbResultados.Name = "ltbResultados";
            this.ltbResultados.Size = new System.Drawing.Size(682, 100);
            this.ltbResultados.TabIndex = 29;
            this.ltbResultados.Visible = false;
            this.ltbResultados.SelectedIndexChanged += new System.EventHandler(this.ltbResultados_SelectedIndexChanged);
            // 
            // frmReporteInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 596);
            this.Controls.Add(this.ltbResultados);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gpbParametros);
            this.Controls.Add(this.crvInventario);
            this.Name = "frmReporteInventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.frmReporteInventario_Load);
            this.gpbParametros.ResumeLayout(false);
            this.gpbParametros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInventario;
        private System.Windows.Forms.GroupBox gpbParametros;
        private ControlesPersonalizados.BotonPersonalizado btnImprimir;
        private System.Windows.Forms.ListBox ltbResultados;
        private System.Windows.Forms.CheckBox chbTodos;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}
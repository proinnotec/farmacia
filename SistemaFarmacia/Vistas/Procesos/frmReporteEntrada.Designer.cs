namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmReporteEntrada
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
            this.rptEntradas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptEntradas
            // 
            this.rptEntradas.ActiveViewIndex = -1;
            this.rptEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptEntradas.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptEntradas.Location = new System.Drawing.Point(0, 0);
            this.rptEntradas.Name = "rptEntradas";
            this.rptEntradas.ShowCloseButton = false;
            this.rptEntradas.ShowGotoPageButton = false;
            this.rptEntradas.ShowGroupTreeButton = false;
            this.rptEntradas.Size = new System.Drawing.Size(940, 577);
            this.rptEntradas.TabIndex = 0;
            this.rptEntradas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporteEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 577);
            this.Controls.Add(this.rptEntradas);
            this.Name = "frmReporteEntrada";
            this.Text = "Reporte Entradas";
            this.Load += new System.EventHandler(this.frmReporteEntrada_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptEntradas;
    }
}
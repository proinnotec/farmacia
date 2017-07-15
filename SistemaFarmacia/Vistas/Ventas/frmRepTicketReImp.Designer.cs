namespace SistemaFarmacia.Vistas.Ventas
{
    partial class frmRepTicketReImp
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
            this.crvTicket = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnImprimir = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.gpbParametros = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblTicket = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // crvTicket
            // 
            this.crvTicket.ActiveViewIndex = -1;
            this.crvTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTicket.Location = new System.Drawing.Point(2, 104);
            this.crvTicket.Name = "crvTicket";
            this.crvTicket.ShowCloseButton = false;
            this.crvTicket.ShowCopyButton = false;
            this.crvTicket.ShowParameterPanelButton = false;
            this.crvTicket.ShowRefreshButton = false;
            this.crvTicket.Size = new System.Drawing.Size(420, 598);
            this.crvTicket.TabIndex = 0;
            this.crvTicket.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.LightGray;
            this.btnImprimir.BackgroundImage = global::SistemaFarmacia.Resource.print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(372, 3);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(50, 50);
            this.btnImprimir.TabIndex = 25;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gpbParametros
            // 
            this.gpbParametros.Controls.Add(this.label1);
            this.gpbParametros.Controls.Add(this.lblFecha);
            this.gpbParametros.Controls.Add(this.dateTimePicker1);
            this.gpbParametros.Controls.Add(this.lblTicket);
            this.gpbParametros.Controls.Add(this.numericUpDown1);
            this.gpbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbParametros.Location = new System.Drawing.Point(0, 0);
            this.gpbParametros.Name = "gpbParametros";
            this.gpbParametros.Size = new System.Drawing.Size(366, 98);
            this.gpbParametros.TabIndex = 26;
            this.gpbParametros.TabStop = false;
            this.gpbParametros.Text = "Parámetros de Consulta";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(91, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(6, 24);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(79, 16);
            this.lblTicket.TabIndex = 1;
            this.lblTicket.Text = "No. Ticket";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(9, 71);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ó";
            // 
            // frmRepTicketReImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 703);
            this.Controls.Add(this.gpbParametros);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.crvTicket);
            this.Name = "frmRepTicketReImp";
            this.Text = "Reimpresión de Tickets";
            this.Load += new System.EventHandler(this.frmRepTicketReImp_Load);
            this.gpbParametros.ResumeLayout(false);
            this.gpbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTicket;
        private ControlesPersonalizados.BotonPersonalizado btnImprimir;
        private System.Windows.Forms.GroupBox gpbParametros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
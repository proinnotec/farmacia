namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmAjustes
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
            this.cmbTiposAjustes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbTiposAjustes
            // 
            this.cmbTiposAjustes.FormattingEnabled = true;
            this.cmbTiposAjustes.Location = new System.Drawing.Point(248, 59);
            this.cmbTiposAjustes.Name = "cmbTiposAjustes";
            this.cmbTiposAjustes.Size = new System.Drawing.Size(121, 21);
            this.cmbTiposAjustes.TabIndex = 0;
            // 
            // frmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 610);
            this.Controls.Add(this.cmbTiposAjustes);
            this.Name = "frmAjustes";
            this.Text = "frmAjustes";
            this.Load += new System.EventHandler(this.frmAjustes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTiposAjustes;
    }
}
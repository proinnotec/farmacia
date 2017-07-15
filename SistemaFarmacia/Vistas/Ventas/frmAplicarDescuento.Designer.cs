namespace SistemaFarmacia.Vistas.Ventas
{
    partial class frmAplicarDescuento
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
            this.cmbDescuentos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDescuentos
            // 
            this.cmbDescuentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescuentos.FormattingEnabled = true;
            this.cmbDescuentos.Location = new System.Drawing.Point(12, 34);
            this.cmbDescuentos.Name = "cmbDescuentos";
            this.cmbDescuentos.Size = new System.Drawing.Size(253, 21);
            this.cmbDescuentos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Descuentos:";
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackgroundImage = global::SistemaFarmacia.Resource.Correcto;
            this.btnAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplicar.Location = new System.Drawing.Point(215, 61);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(50, 50);
            this.btnAplicar.TabIndex = 40;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // frmAplicarDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 116);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDescuentos);
            this.Name = "frmAplicarDescuento";
            this.Text = "Aplicar descuento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAplicar;
        public System.Windows.Forms.ComboBox cmbDescuentos;
    }
}
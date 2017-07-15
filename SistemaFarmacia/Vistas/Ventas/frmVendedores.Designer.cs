namespace SistemaFarmacia.Vistas.Ventas
{
    partial class frmVendedores
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
            this.btnAplicar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackgroundImage = global::SistemaFarmacia.Resource.Correcto;
            this.btnAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplicar.Location = new System.Drawing.Point(215, 60);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(50, 50);
            this.btnAplicar.TabIndex = 43;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Vendedor:";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(12, 28);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(253, 21);
            this.cmbVendedores.TabIndex = 41;
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbVendedores);
            this.Name = "frmVendedores";
            this.Text = "Seleccione un vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbVendedores;
    }
}
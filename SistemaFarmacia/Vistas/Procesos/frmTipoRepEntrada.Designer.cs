namespace SistemaFarmacia.Vistas.Procesos
{
    partial class frmTipoRepEntrada
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbDetallado = new System.Windows.Forms.RadioButton();
            this.rdbBasico = new System.Windows.Forms.RadioButton();
            this.gpbTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::SistemaFarmacia.Resource.Correcto;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Location = new System.Drawing.Point(292, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(50, 50);
            this.btnAgregar.TabIndex = 43;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbDetallado);
            this.gpbTipo.Controls.Add(this.rdbBasico);
            this.gpbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipo.Location = new System.Drawing.Point(12, 12);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(333, 100);
            this.gpbTipo.TabIndex = 0;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Seleccione el tipo de reporte que quiere ver";
            // 
            // rdbDetallado
            // 
            this.rdbDetallado.AutoSize = true;
            this.rdbDetallado.Location = new System.Drawing.Point(179, 45);
            this.rdbDetallado.Name = "rdbDetallado";
            this.rdbDetallado.Size = new System.Drawing.Size(94, 20);
            this.rdbDetallado.TabIndex = 1;
            this.rdbDetallado.TabStop = true;
            this.rdbDetallado.Text = "Detallado";
            this.rdbDetallado.UseVisualStyleBackColor = true;
            // 
            // rdbBasico
            // 
            this.rdbBasico.AutoSize = true;
            this.rdbBasico.Checked = true;
            this.rdbBasico.Location = new System.Drawing.Point(58, 45);
            this.rdbBasico.Name = "rdbBasico";
            this.rdbBasico.Size = new System.Drawing.Size(74, 20);
            this.rdbBasico.TabIndex = 0;
            this.rdbBasico.TabStop = true;
            this.rdbBasico.Text = "Básico";
            this.rdbBasico.UseVisualStyleBackColor = true;
            // 
            // frmTipoRepEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 179);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gpbTipo);
            this.Name = "frmTipoRepEntrada";
            this.Text = "Tipo de Reporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTipoRepEntrada_FormClosing);
            this.Load += new System.EventHandler(this.frmTipoRepEntrada_Load);
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbDetallado;
        private System.Windows.Forms.RadioButton rdbBasico;
        private System.Windows.Forms.Button btnAgregar;
    }
}
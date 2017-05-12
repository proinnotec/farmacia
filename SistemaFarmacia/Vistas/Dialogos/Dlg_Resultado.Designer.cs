using SistemaFarmacia.ControlesPersonalizados;

namespace SistemaFarmacia.Vistas.Dialogos
{
    partial class Dlg_Resultado
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
            this.tabDlgResultado = new System.Windows.Forms.TabControl();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.tabExcepcion = new System.Windows.Forms.TabPage();
            this.txtExcepcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new BotonPersonalizado();
            this.tabDlgResultado.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.tabExcepcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDlgResultado
            // 
            this.tabDlgResultado.Controls.Add(this.tabUsuario);
            this.tabDlgResultado.Controls.Add(this.tabExcepcion);
            this.tabDlgResultado.Location = new System.Drawing.Point(-4, 0);
            this.tabDlgResultado.Name = "tabDlgResultado";
            this.tabDlgResultado.SelectedIndex = 0;
            this.tabDlgResultado.Size = new System.Drawing.Size(447, 201);
            this.tabDlgResultado.TabIndex = 3;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.lblMensaje);
            this.tabUsuario.Controls.Add(this.picImagen);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(439, 175);
            this.tabUsuario.TabIndex = 0;
            this.tabUsuario.Text = "Mensaje";
            this.tabUsuario.UseVisualStyleBackColor = true;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(117, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(319, 175);
            this.lblMensaje.TabIndex = 3;
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(6, 6);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(105, 90);
            this.picImagen.TabIndex = 2;
            this.picImagen.TabStop = false;
            // 
            // tabExcepcion
            // 
            this.tabExcepcion.Controls.Add(this.txtExcepcion);
            this.tabExcepcion.Location = new System.Drawing.Point(4, 22);
            this.tabExcepcion.Name = "tabExcepcion";
            this.tabExcepcion.Padding = new System.Windows.Forms.Padding(3);
            this.tabExcepcion.Size = new System.Drawing.Size(439, 175);
            this.tabExcepcion.TabIndex = 1;
            this.tabExcepcion.Text = "Detalles";
            this.tabExcepcion.UseVisualStyleBackColor = true;
            // 
            // txtExcepcion
            // 
            this.txtExcepcion.Location = new System.Drawing.Point(6, 3);
            this.txtExcepcion.Multiline = true;
            this.txtExcepcion.Name = "txtExcepcion";
            this.txtExcepcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExcepcion.Size = new System.Drawing.Size(430, 166);
            this.txtExcepcion.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(339, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 34);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Dlg_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 263);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tabDlgResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dlg_Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Dlg_Resultado_Load);
            this.tabDlgResultado.ResumeLayout(false);
            this.tabUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.tabExcepcion.ResumeLayout(false);
            this.tabExcepcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDlgResultado;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.TabPage tabExcepcion;
        private System.Windows.Forms.TextBox txtExcepcion;
        private BotonPersonalizado btnAceptar;

    }
}
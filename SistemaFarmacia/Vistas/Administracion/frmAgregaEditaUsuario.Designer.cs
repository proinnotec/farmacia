namespace SistemaFarmacia.Vistas.Administracion
{
    partial class frmAgregaEditaUsuario
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
            this.txtPass = new System.Windows.Forms.MaskedTextBox();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApaterno = new System.Windows.Forms.Label();
            this.lblAMaterno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.txtAMaterno = new System.Windows.Forms.MaskedTextBox();
            this.txtAPaterno = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPerfil);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.txtPass);
            this.groupBox2.Controls.Add(this.cmbPerfiles);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Controls.Add(this.lblContrasena);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 84);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Login";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(308, 30);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(44, 16);
            this.lblPerfil.TabIndex = 20;
            this.lblPerfil.Text = "Perfil";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(9, 49);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(145, 22);
            this.txtUsuario.TabIndex = 17;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(156, 49);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(145, 22);
            this.txtPass.TabIndex = 18;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(307, 49);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(145, 24);
            this.cmbPerfiles.TabIndex = 19;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(6, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 16);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(153, 31);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(87, 16);
            this.lblContrasena.TabIndex = 13;
            this.lblContrasena.Text = "Contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblApaterno);
            this.groupBox1.Controls.Add(this.lblAMaterno);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtAMaterno);
            this.groupBox1.Controls.Add(this.txtAPaterno);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 69);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApaterno
            // 
            this.lblApaterno.AutoSize = true;
            this.lblApaterno.Location = new System.Drawing.Point(155, 20);
            this.lblApaterno.Name = "lblApaterno";
            this.lblApaterno.Size = new System.Drawing.Size(124, 16);
            this.lblApaterno.TabIndex = 10;
            this.lblApaterno.Text = "Apellido Paterno";
            // 
            // lblAMaterno
            // 
            this.lblAMaterno.AutoSize = true;
            this.lblAMaterno.Location = new System.Drawing.Point(304, 20);
            this.lblAMaterno.Name = "lblAMaterno";
            this.lblAMaterno.Size = new System.Drawing.Size(126, 16);
            this.lblAMaterno.TabIndex = 11;
            this.lblAMaterno.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // txtAMaterno
            // 
            this.txtAMaterno.Location = new System.Drawing.Point(306, 37);
            this.txtAMaterno.Name = "txtAMaterno";
            this.txtAMaterno.Size = new System.Drawing.Size(145, 22);
            this.txtAMaterno.TabIndex = 16;
            // 
            // txtAPaterno
            // 
            this.txtAPaterno.Location = new System.Drawing.Point(156, 37);
            this.txtAPaterno.Name = "txtAPaterno";
            this.txtAPaterno.Size = new System.Drawing.Size(145, 22);
            this.txtAPaterno.TabIndex = 15;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightGray;
            this.btnGuardar.BackgroundImage = global::SistemaFarmacia.Resource.save;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(483, 18);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 50);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAgregaEditaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 180);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmAgregaEditaUsuario";
            this.Text = "7";
            this.Load += new System.EventHandler(this.frmAgregaEditaUsuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.BotonPersonalizado btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApaterno;
        private System.Windows.Forms.Label lblAMaterno;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtAPaterno;
        private System.Windows.Forms.MaskedTextBox txtAMaterno;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtPass;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPerfil;
    }
}
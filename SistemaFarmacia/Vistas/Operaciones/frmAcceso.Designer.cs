namespace SistemaFarmacia.Vistas.Operaciones
{
    partial class frmAcceso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridPersonalizado1 = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonalizado1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonalizado1
            // 
            this.gridPersonalizado1.AllowUserToAddRows = false;
            this.gridPersonalizado1.AllowUserToDeleteRows = false;
            this.gridPersonalizado1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridPersonalizado1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridPersonalizado1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPersonalizado1.BackgroundColor = System.Drawing.Color.White;
            this.gridPersonalizado1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPersonalizado1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonalizado1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridPersonalizado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersonalizado1.EnableHeadersVisualStyles = false;
            this.gridPersonalizado1.Location = new System.Drawing.Point(55, 47);
            this.gridPersonalizado1.MultiSelect = false;
            this.gridPersonalizado1.Name = "gridPersonalizado1";
            this.gridPersonalizado1.ReadOnly = true;
            this.gridPersonalizado1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonalizado1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gridPersonalizado1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridPersonalizado1.RowTemplate.Height = 20;
            this.gridPersonalizado1.RowTemplate.ReadOnly = true;
            this.gridPersonalizado1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPersonalizado1.Size = new System.Drawing.Size(240, 150);
            this.gridPersonalizado1.TabIndex = 0;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 345);
            this.Controls.Add(this.gridPersonalizado1);
            this.Name = "frmAcceso";
            this.Text = "frmAcceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonalizado1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlesPersonalizados.GridPersonalizado gridPersonalizado1;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.crvTicket = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnBuscar = new SistemaFarmacia.ControlesPersonalizados.BotonPersonalizado();
            this.gpbParametros = new System.Windows.Forms.GroupBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblTicket = new System.Windows.Forms.Label();
            this.nudTicket = new System.Windows.Forms.NumericUpDown();
            this.gridTickets = new SistemaFarmacia.ControlesPersonalizados.GridPersonalizado();
            this.NoTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendedorTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorteCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTicketsTexto = new System.Windows.Forms.Label();
            this.lblTicketsNumero = new System.Windows.Forms.Label();
            this.cmbVendedores = new System.Windows.Forms.ComboBox();
            this.chbTodos = new System.Windows.Forms.CheckBox();
            this.gpbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).BeginInit();
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
            this.crvTicket.Location = new System.Drawing.Point(500, 104);
            this.crvTicket.Name = "crvTicket";
            this.crvTicket.ShowCloseButton = false;
            this.crvTicket.ShowCopyButton = false;
            this.crvTicket.ShowParameterPanelButton = false;
            this.crvTicket.ShowRefreshButton = false;
            this.crvTicket.Size = new System.Drawing.Size(660, 598);
            this.crvTicket.TabIndex = 0;
            this.crvTicket.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.LightGray;
            this.btnBuscar.BackgroundImage = global::SistemaFarmacia.Resource.search2;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1110, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gpbParametros
            // 
            this.gpbParametros.Controls.Add(this.cmbVendedores);
            this.gpbParametros.Controls.Add(this.chbTodos);
            this.gpbParametros.Controls.Add(this.lblFechaFin);
            this.gpbParametros.Controls.Add(this.dtpFechaFin);
            this.gpbParametros.Controls.Add(this.lblFechaInicio);
            this.gpbParametros.Controls.Add(this.dtpInicio);
            this.gpbParametros.Controls.Add(this.lblTicket);
            this.gpbParametros.Controls.Add(this.nudTicket);
            this.gpbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbParametros.Location = new System.Drawing.Point(0, 0);
            this.gpbParametros.Name = "gpbParametros";
            this.gpbParametros.Size = new System.Drawing.Size(484, 98);
            this.gpbParametros.TabIndex = 26;
            this.gpbParametros.TabStop = false;
            this.gpbParametros.Text = "Parámetros de Consulta";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(249, 71);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(80, 16);
            this.lblFechaFin.TabIndex = 6;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(335, 70);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(120, 22);
            this.dtpFechaFin.TabIndex = 5;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(9, 71);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(96, 16);
            this.lblFechaInicio.TabIndex = 3;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(107, 70);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(120, 22);
            this.dtpInicio.TabIndex = 2;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(6, 20);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(79, 16);
            this.lblTicket.TabIndex = 1;
            this.lblTicket.Text = "No. Ticket";
            // 
            // nudTicket
            // 
            this.nudTicket.Location = new System.Drawing.Point(91, 21);
            this.nudTicket.Name = "nudTicket";
            this.nudTicket.Size = new System.Drawing.Size(120, 22);
            this.nudTicket.TabIndex = 0;
            // 
            // gridTickets
            // 
            this.gridTickets.AllowUserToAddRows = false;
            this.gridTickets.AllowUserToDeleteRows = false;
            this.gridTickets.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.gridTickets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTickets.BackgroundColor = System.Drawing.Color.White;
            this.gridTickets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTickets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.gridTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoTicket,
            this.Fecha,
            this.Total,
            this.VendedorTicket,
            this.CorteCaja});
            this.gridTickets.EnableHeadersVisualStyles = false;
            this.gridTickets.Location = new System.Drawing.Point(6, 104);
            this.gridTickets.MultiSelect = false;
            this.gridTickets.Name = "gridTickets";
            this.gridTickets.ReadOnly = true;
            this.gridTickets.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTickets.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.gridTickets.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTickets.RowTemplate.Height = 20;
            this.gridTickets.RowTemplate.ReadOnly = true;
            this.gridTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTickets.Size = new System.Drawing.Size(488, 598);
            this.gridTickets.TabIndex = 27;
            this.gridTickets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTickets_CellClick);
            this.gridTickets.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridTickets_KeyUp);
            // 
            // NoTicket
            // 
            this.NoTicket.DataPropertyName = "NoTicket";
            this.NoTicket.FillWeight = 59.53475F;
            this.NoTicket.HeaderText = "Ticket";
            this.NoTicket.Name = "NoTicket";
            this.NoTicket.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.FillWeight = 134.6909F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.FillWeight = 101.5229F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // VendedorTicket
            // 
            this.VendedorTicket.DataPropertyName = "VendedorTicket";
            this.VendedorTicket.FillWeight = 160.4934F;
            this.VendedorTicket.HeaderText = "Vendedor";
            this.VendedorTicket.Name = "VendedorTicket";
            this.VendedorTicket.ReadOnly = true;
            // 
            // CorteCaja
            // 
            this.CorteCaja.DataPropertyName = "CorteCaja";
            this.CorteCaja.FillWeight = 43.75804F;
            this.CorteCaja.HeaderText = "Corte";
            this.CorteCaja.Name = "CorteCaja";
            this.CorteCaja.ReadOnly = true;
            // 
            // lblTicketsTexto
            // 
            this.lblTicketsTexto.AutoSize = true;
            this.lblTicketsTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsTexto.Location = new System.Drawing.Point(551, 29);
            this.lblTicketsTexto.Name = "lblTicketsTexto";
            this.lblTicketsTexto.Size = new System.Drawing.Size(200, 24);
            this.lblTicketsTexto.TabIndex = 7;
            this.lblTicketsTexto.Text = "Tickets Encontrados";
            // 
            // lblTicketsNumero
            // 
            this.lblTicketsNumero.AutoSize = true;
            this.lblTicketsNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsNumero.Location = new System.Drawing.Point(771, 29);
            this.lblTicketsNumero.Name = "lblTicketsNumero";
            this.lblTicketsNumero.Size = new System.Drawing.Size(21, 24);
            this.lblTicketsNumero.TabIndex = 28;
            this.lblTicketsNumero.Text = "0";
            // 
            // cmbVendedores
            // 
            this.cmbVendedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendedores.FormattingEnabled = true;
            this.cmbVendedores.Location = new System.Drawing.Point(235, 33);
            this.cmbVendedores.Name = "cmbVendedores";
            this.cmbVendedores.Size = new System.Drawing.Size(238, 24);
            this.cmbVendedores.TabIndex = 8;
            // 
            // chbTodos
            // 
            this.chbTodos.AutoSize = true;
            this.chbTodos.Checked = true;
            this.chbTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTodos.Location = new System.Drawing.Point(238, 13);
            this.chbTodos.Name = "chbTodos";
            this.chbTodos.Size = new System.Drawing.Size(186, 20);
            this.chbTodos.TabIndex = 7;
            this.chbTodos.Text = "Todos los Vendedores";
            this.chbTodos.UseVisualStyleBackColor = true;
            this.chbTodos.CheckedChanged += new System.EventHandler(this.chbTodos_CheckedChanged);
            // 
            // frmRepTicketReImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 703);
            this.Controls.Add(this.lblTicketsNumero);
            this.Controls.Add(this.lblTicketsTexto);
            this.Controls.Add(this.gridTickets);
            this.Controls.Add(this.gpbParametros);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.crvTicket);
            this.Name = "frmRepTicketReImp";
            this.Text = "Reimpresión de Tickets";
            this.Load += new System.EventHandler(this.frmRepTicketReImp_Load);
            this.gpbParametros.ResumeLayout(false);
            this.gpbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTicket;
        private ControlesPersonalizados.BotonPersonalizado btnBuscar;
        private System.Windows.Forms.GroupBox gpbParametros;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.NumericUpDown nudTicket;
        private ControlesPersonalizados.GridPersonalizado gridTickets;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendedorTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorteCaja;
        private System.Windows.Forms.Label lblTicketsTexto;
        private System.Windows.Forms.Label lblTicketsNumero;
        private System.Windows.Forms.ComboBox cmbVendedores;
        private System.Windows.Forms.CheckBox chbTodos;
    }
}
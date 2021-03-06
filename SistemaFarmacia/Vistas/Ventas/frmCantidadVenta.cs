﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFarmacia.Vistas.Base;

namespace SistemaFarmacia.Vistas.Ventas
{
    public partial class frmCantidadVenta : frmBase
    {
        public frmCantidadVenta(decimal cantidad)
        {
            InitializeComponent();
            nupCantidad.Value = cantidad;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void nupCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ValidarDatos();
            }
        }

        private void ValidarDatos()
        {
            if (nupCantidad.Value.Equals(0))
            {
                MostrarDialogoResultado(this.Text, "Capture la cantidad del producto.", string.Empty, false);
                return;
            }

            this.DialogResult = DialogResult.Yes;
        }

        private void frmCantidadVenta_Load(object sender, EventArgs e)
        {
            nupCantidad.Select(0, 1);
        }
    }
}

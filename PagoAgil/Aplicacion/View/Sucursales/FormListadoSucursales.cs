﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Sucursales
{
    public partial class FormListadoSucursales : Form
    {
        public FormListadoSucursales(String accion)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            String nombreSucursal = textBoxNombre.Text.Trim();
            String direccionSucursal = textBoxDireccion.Text.Trim();
            String CPSucursal = textBoxCP.Text.Trim();



        }

    }
}

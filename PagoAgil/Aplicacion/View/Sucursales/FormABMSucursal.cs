using System;
using System.Windows.Forms;
using PagoAgil.Aplicacion.View.Sucursales;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormABMSucursal : Form
    {
        public FormABMSucursal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAltaSucursal altaSucursal = new FormAltaSucursal();
            this.Hide();
            altaSucursal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListadoSucursales listado = new FormListadoSucursales("modificacion");
            this.Hide();
            listado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormListadoSucursales listado = new FormListadoSucursales("baja");
            this.Hide();
            listado.Show();
        }

    }
}

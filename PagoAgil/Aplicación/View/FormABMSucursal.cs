using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicación.View
{
    public partial class FormABMSucursal : Form
    {
        public FormABMSucursal()
        {
            InitializeComponent();
        }

        private void FormABMSucursal_Load(object sender, EventArgs e)
        {
            FormAltaSucursal altaSucursal = new FormAltaSucursal();
            this.Hide();
            altaSucursal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormModificacionSucursal modificacionSucursal = new FormModificacionSucursal();
            this.Hide();
            modificacionSucursal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBajaSucursal bajaSucursal = new FormBajaSucursal();
            this.Hide();
            bajaSucursal.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormABMRol : Form
    {
        public FormABMRol()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAltaRol altaRol = new FormAltaRol();
            this.Hide();
            altaRol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListadoRoles listado = new FormListadoRoles("modificacion");
            this.Hide();
            listado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormListadoRoles listado = new FormListadoRoles("baja");
            this.Hide();
            listado.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.ViewModel;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormABMRol : Form
    {
        HomeVM VMHome;

        public FormABMRol(HomeVM vm)
        {
            InitializeComponent();
            this.CenterToScreen();

            VMHome = vm;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAltaRol altaRol = new FormAltaRol();
            this.Hide();
            altaRol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormListadoRoles listado = new FormListadoRoles("modificacion",VMHome);
            this.Hide();
            listado.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormListadoRoles listado = new FormListadoRoles("baja", VMHome);
            this.Hide();
            listado.Show();
        }
    }
}

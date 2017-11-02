using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Empresas
{
    public partial class EmpresasSeleccionABM : Form
    {
        private FormHome formHome;

        public EmpresasSeleccionABM(FormHome formHome)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.formHome = formHome;
        }


        private void ingresarButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            new EmpresasAlta(this).Show();
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            new EmpresasBuscador(this).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            this.formHome.Show();

            this.formHome.Activate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = textUsername.Text.Trim();

            String pass = textPassword.Text.Trim();

            if (ServicioSQL.Instance.esUsuarioValido(usuario, pass))
            {
                FormMain miMain = new FormMain();
                this.Hide();
                miMain.Show();
            }
            else
            {
                MessageBox.Show("Acceso invalido, tanto como vos");
            }

        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil
{
    public partial class FormLogin : Form
    {

        Orquestador miOrquestador = new Orquestador();

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

            Boolean esUsuarioValido = false;

            try
            {
                esUsuarioValido = miOrquestador.esUsuarioValido(usuario, pass);
            }
            catch(LogingDemasiadosIntentosException)
            {
                MessageBox.Show("Usuario inhabilitado");
                miOrquestador.inhabilitar(usuario);
                return;
            }

            if (esUsuarioValido)
            {
                FormSeleccionarRol miSeleccionadorDeRol = new FormSeleccionarRol();
                this.Hide();
                miSeleccionadorDeRol.Show();
            }
            else
            {
                MessageBox.Show("Acceso invalido, tanto como vos");
            }

        }

    }

}

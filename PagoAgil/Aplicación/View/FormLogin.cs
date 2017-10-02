using PagoAgil.Aplicación.Modelo;
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

        LoginVM loginVM = new LoginVM();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombreUsuario = textUsername.Text.Trim();

            String pass = textPassword.Text.Trim();

            UsuarioDB usuario = null;

            try
            {
                usuario = loginVM.obtener(nombreUsuario, pass);
            }
            catch(DemasiadosIntentosException)
            {
                MessageBox.Show("Usuario inhabilitado");
                loginVM.inhabilitar(nombreUsuario);
                return;
            }

            if (usuario != null)
            {
                FormSeleccionarRol miSeleccionadorDeRol = new FormSeleccionarRol(usuario);
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

using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Excepciones;
using System;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormLogin : Form
    {

        LoginVM loginVM = new LoginVM();

        public FormLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
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
            catch(UsuarioInhabilitadoException)
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
                MessageBox.Show("Acceso invalido");
            }

        }

    }

}

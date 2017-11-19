using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.View.Roles.Excepciones;
using PagoAgil.Aplicacion.ViewModel;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormBajaRol : Form
    {
        Rol rol;
        BajaRolVM VM;

        public FormBajaRol(Rol rolElegido)
        {
            InitializeComponent();
            this.CenterToScreen();

            rol = rolElegido;
            VM = new BajaRolVM();

            textBoxNombre.Text = rol.nombre;

            //Agregar funcionalidades al checked list box
            foreach (Funcionalidad f in rol.funcionalidades)
            {
                checkedListBoxFuncionalidades.Items.Add(f);
            }
        }

        private void buttonDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                VM.darDeBaja(rol);
            }
            catch (RolYaDeshabilitadoException)
            {
                MessageBox.Show("El rol seleccionado ya se encuentra deshabilitado");
                return;
            }
            catch (DeshabilitarRolActualException)
            {
                MessageBox.Show("No puede deshabilitar el rol porque lo está usando en esta sesión");
                return;
            }

            this.Hide();
        }
    }
}

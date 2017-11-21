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
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.View.Roles.Excepciones;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormListadoRoles : Form
    {
        ListadoRolesVM VM;
        HomeVM VMHome;
        string accion;

        public FormListadoRoles(string miAccion, HomeVM vm)
        {
            InitializeComponent();
            this.CenterToScreen();
            VM = new ListadoRolesVM();
            accion = miAccion;
            VMHome = vm;

        }

        private void FormListadoRoles_Load(object sender, EventArgs e)
        {
            Rol[] roles = VM.obtenerRoles();

            comboBoxRoles.Items.AddRange(roles);

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            Rol rolElegido = comboBoxRoles.SelectedItem as Rol;

            try
            {
                if (rolElegido == null) throw new NoSeleccionoElRolException();
            }
            catch(NoSeleccionoElRolException)
            {
                MessageBox.Show("Debe seleccionar un rol para continuar");
                return;
            }

            rolElegido.funcionalidades = VM.obtenerFuncionalidadesDe(rolElegido.id);

            this.Hide();

            if (accion.Equals("modificacion"))
            {
                new FormModificacionRol(rolElegido,VMHome).Show();
            }
            else 
            {
                new FormBajaRol(rolElegido).Show();
            }
        }
    }
}

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

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormListadoRoles : Form
    {
        ListadoRolesVM VM;
        string accion;

        public FormListadoRoles(string miAccion)
        {
            InitializeComponent();
            this.CenterToScreen();
            VM = new ListadoRolesVM();
            accion = miAccion;

        }

        private void FormListadoRoles_Load(object sender, EventArgs e)
        {
            Rol[] roles = VM.obtenerRoles();

            comboBoxRoles.Items.AddRange(roles);

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            Rol rolElegido = comboBoxRoles.SelectedItem as Rol;

            rolElegido.funcionalidades = VM.obtenerFuncionalidadesDe(rolElegido.id);

            this.Hide();

            if (accion.Equals("modificacion"))
            {
                new FormModificacionRol(rolElegido).Show();
            }
            else 
            {
                new FormBajaRol(rolElegido).Show();
            }
        }
    }
}

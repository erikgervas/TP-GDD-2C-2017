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
using PagoAgil.Aplicacion.BD.Utils;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormAltaRol : Form
    {
        RolesBuilder rolBuilder = new RolesBuilder();

        public FormAltaRol()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            rolBuilder.nombre = textBoxNombre.Text;
        }

        private void checkedListBoxFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            rolBuilder = new RolesBuilder();

            textBoxNombre.Clear();

            for (int i = 0; i < checkedListBoxFuncionalidades.Items.Count; i++) 
            {
                checkedListBoxFuncionalidades.SetItemCheckState(i, CheckState.Unchecked);
            }

        }

        private void buttonCrearRol_Click(object sender, EventArgs e)
        {
            Rol nuevoRol = rolBuilder.crearRol();

            Insertador.getInstance().insertarRol(nuevoRol);

            FormAltaRolOk formAlta = new FormAltaRolOk();

            formAlta.Show();
        }
    }
}

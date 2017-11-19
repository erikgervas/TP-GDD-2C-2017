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
using PagoAgil.Aplicacion.ViewModel;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormAltaRol : Form
    {
        RolesBuilder rolBuilder = new RolesBuilder();
        AltaRolVM VM = new AltaRolVM();

        public FormAltaRol()
        {
            InitializeComponent();
            this.CenterToScreen();

            List<Funcionalidad> funcionalidades = VM.obtenerFuncionalidades();

            //Agregar funcionalidades al checked list box
            foreach (Funcionalidad f in funcionalidades) 
            {
                checkedListBoxFuncionalidades.Items.Add(f);
            }

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            rolBuilder.nombre = textBoxNombre.Text;
        }

        private void checkedListBoxFuncionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Funcionalidad> funcionalidadesElegidas = new List<Funcionalidad>();

            for (int i = 0; i < checkedListBoxFuncionalidades.Items.Count; i++)
            {
                if (checkedListBoxFuncionalidades.GetItemChecked(i))
                {
                    Funcionalidad f = (Funcionalidad)checkedListBoxFuncionalidades.Items[i];
                    funcionalidadesElegidas.Add(f);
                }
            }

            rolBuilder.funcionalidades = funcionalidadesElegidas;
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

            VM.crearRol(nuevoRol);

            FormAltaRolOk formAlta = new FormAltaRolOk();

            formAlta.Show();
        }
    }
}

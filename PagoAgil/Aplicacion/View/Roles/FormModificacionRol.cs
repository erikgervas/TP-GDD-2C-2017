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
using PagoAgil.Aplicacion.View.Roles;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormModificacionRol : Form
    {
        Rol rol;
        RolesBuilder builder;

        public FormModificacionRol(Rol rolElegido)
        {
            InitializeComponent();
            this.CenterToScreen();

            rol = rolElegido;
            builder = new RolesBuilder();

            this.cargarCampos();
        }

        private void cargarCampos() 
        {
            textBoxNombre.Text = rol.nombre;

            //Agregar funcionalidades al checked list box
            foreach (Funcionalidad f in rol.funcionalidades)
            {
                checkedListBoxFuncionalidades.Items.Add(f);
            }

            if (rol.habilitado == false)
            {
                checkBoxEstado.Checked = false;
                checkBoxEstado.Enabled = true;
            }
            else
            {
                checkBoxEstado.Checked = true;
                checkBoxEstado.Enabled = false;
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            builder.nombre = textBoxNombre.Text;
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

            builder.funcionalidades = funcionalidadesElegidas;
        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
            builder.habilitado = checkBoxEstado.Checked;
        }

        private void buttonConfirmarCambios_Click(object sender, EventArgs e)
        {

            Rol rolModificado = builder.crearRolModificado();

            RepositorioRoles.getInstancia().getAlmacenamiento().modificar(rolModificado);

            this.Hide();
        }
    }
}

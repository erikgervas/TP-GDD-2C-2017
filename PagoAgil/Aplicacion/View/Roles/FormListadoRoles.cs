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
    }
}

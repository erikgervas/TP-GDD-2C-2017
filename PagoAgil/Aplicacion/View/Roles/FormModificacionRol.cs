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

namespace PagoAgil.Aplicacion.View.Roles
{
    public partial class FormModificacionRol : Form
    {
        Rol rol;

        public FormModificacionRol(Rol rolElegido)
        {
            InitializeComponent();
            this.CenterToScreen();

            rol = rolElegido;
        }
    }
}

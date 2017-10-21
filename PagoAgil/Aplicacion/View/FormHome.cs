using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormHome : Form
    {
        HomeVM homeVM;

        public FormHome(Usuario usuario)
        {
            InitializeComponent();
            homeVM = new HomeVM(usuario);
        }
    }
}

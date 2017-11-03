using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Empresas
{
    public partial class EmpresasBuscador : Form
    {
        public EmpresasBuscador()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void volverAInicioButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new EmpresasSeleccionABM().Show();
        }
    }
}

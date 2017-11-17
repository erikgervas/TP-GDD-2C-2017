using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Facturas
{
    public partial class FacturaOk : Form
    {
        public FacturaOk()
        {
            InitializeComponent();
            this.iniciarTitulos();
            this.CenterToScreen();
        }

        private void iniciarTitulos()
        {
            this.Text = FacturaABM.instanciar().titulosOk()[0];
            this.confirmacionText.Text = FacturaABM.instanciar().titulosOk()[1];
        }

        private void volverAInicioButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new FormHome().Show();
        }

        private void volverAEmpresasButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new FacturaSeleccionadorABM().Show();
        }
    }
}

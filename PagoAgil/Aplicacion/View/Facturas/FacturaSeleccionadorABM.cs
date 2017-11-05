using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
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
    public partial class FacturaSeleccionadorABM : Form
    {
        public FacturaSeleccionadorABM()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void ingresarButton_Click(object sender, EventArgs e)
        {
            this.Close();

            FacturaABM.instanciar().abm = new Alta<Factura>();

            new FacturaCompletado().Show();
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new FacturaBuscador().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

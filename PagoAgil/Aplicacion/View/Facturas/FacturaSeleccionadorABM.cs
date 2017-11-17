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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarButton_Click_1(object sender, EventArgs e)
        {
            FacturaABM.instanciar().abm = new Alta<Factura>();

            ItemABM.instanciar().abm = new Alta<Item>();

            new FacturaCompletado().Show();

            this.Close();
        }

        private void consultarButton_Click_1(object sender, EventArgs e)
        {
            new FacturaBuscador().Show();

            this.Close();
        }
    }
}

using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Facturas
{
    public partial class FacturasOk : Form
    {
        public FacturasOk()
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
    }
}

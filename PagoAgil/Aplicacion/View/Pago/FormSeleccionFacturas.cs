using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Pago
{
    public partial class FormSeleccionFacturas : Form
    {
        private PagoBuilder miPagoBuilder;

        public FormSeleccionFacturas(PagoBuilder pagoBuilder)
        {
            InitializeComponent();
            this.CenterToScreen();

            miPagoBuilder = pagoBuilder;
        }
    }
}

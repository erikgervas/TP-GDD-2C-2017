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
    public partial class FacturaConfirmado : Form
    {
        public FacturaConfirmado()
        {
            InitializeComponent();
        }

        private void FacturaConfirmado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQL_BOYS_Data_Set.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.sQL_BOYS_Data_Set.Item);

        }
    }
}

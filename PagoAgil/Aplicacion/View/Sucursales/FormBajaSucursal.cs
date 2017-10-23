using PagoAgil.Aplicacion.View;
using System;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormBajaSucursal : Form
    {
        BajaSucursalVM bajaSucursalVM;

        public FormBajaSucursal()
        {
            InitializeComponent();

            bajaSucursalVM = new BajaSucursalVM();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

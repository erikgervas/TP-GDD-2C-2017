using PagoAgil.Aplicacion.ViewModel;
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

            String[] criterios = {"Codigo Postal", "Nombre", "Direccion"};

            comboCriterios.Items.AddRange(criterios);
        }

        private void comboCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

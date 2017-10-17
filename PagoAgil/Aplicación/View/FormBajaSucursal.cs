using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicación.ViewModel;

namespace PagoAgil.Aplicación.View
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

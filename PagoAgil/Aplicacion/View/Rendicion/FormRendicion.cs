using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Rendicion
{
    public partial class FormRendicion : Form
    {

        RendicionVM rendicionVM;

        public FormRendicion()
        {
            InitializeComponent();

            rendicionVM = new RendicionVM();
        }

        private void FormRendicion_Load(object sender, EventArgs e)
        {

            DataTable dt = this.rendicionVM.obtenerEmpresasARendir();

            dataGridRendicion.AutoGenerateColumns = true;

            this.dataGridRendicion.DataSource = dt;

            dataGridRendicion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridRendicion.Columns[dataGridRendicion.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void buttonRendir_Click(object sender, EventArgs e)
        {

            try
            {

                string filasAfectadasPorEmpresa = rendicionVM.rendir(dataGridRendicion.SelectedRows);

                MessageBox.Show(filasAfectadasPorEmpresa);

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No elegiste ninguna empresa");
            }

        }      

    }
}

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

namespace PagoAgil.Aplicacion.View.Empresas
{
    public partial class EmpresasBuscador : Form
    {
        private EmpresasBuscadorVM viewModel = new EmpresasBuscadorVM();

        public EmpresasBuscador()
        {
            InitializeComponent();
            this.CenterToScreen();

            foreach (String rubro in this.viewModel.rubros) this.rubroComboBox.Items.Add(rubro);
        }

        private void volverAInicioButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new EmpresasSeleccionABM().Show();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.nombreText.Text = null;
            this.cuitText.Text = null;
            this.rubroComboBox.Text = null;
            this.empresasDataGrid.DataSource = null;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            String cuit = cuitText.Text;

            if (cuit.Count() > 2) cuit = cuit.ElementAt(0) + "-" + cuit.Substring(1, cuit.Count() - 2) + "-" + cuit.Reverse().ElementAt(0);

            this.empresasDataGrid.DataSource = this.viewModel.buscar(this.nombreText.Text, cuit, this.rubroComboBox.Text);
        }

        private void cuitText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8) return;

            else e.Handled = e.KeyChar != (char)Keys.Back;
        }
    }
}

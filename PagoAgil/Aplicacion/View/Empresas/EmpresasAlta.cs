using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Builders.Excepciones;
using PagoAgil.Aplicacion.View.Excepciones;
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
    public partial class EmpresasAlta : Form
    {
        private EmpresasSeleccionABM empresasSeleccionABM;
        private EmpresasAltaVM viewModel;

        public EmpresasAlta(EmpresasSeleccionABM empresasSeleccionABM)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.empresasSeleccionABM = empresasSeleccionABM;
            this.viewModel = new EmpresasAltaVM();
            foreach (String rubro in this.viewModel.rubros) this.rubroComboBox.Items.Add(rubro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            this.empresasSeleccionABM.Show();

            this.empresasSeleccionABM.Activate();
        }

        private void nombreText_TextChanged(object sender, EventArgs e)
        {
            this.viewModel.empresa.nombre = nombreText.Text;
        }

        private void cuitText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8) return;

            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void cuitText_TextChanged(object sender, EventArgs e)
        {
            this.viewModel.empresa.cuit = cuitText.Text;
        }

        private void direccionText_TextChanged_1(object sender, EventArgs e)
        {
            this.viewModel.empresa.direccion = direccionText.Text;
        }

        private void rubroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.viewModel.empresa.rubro = rubroComboBox.Text;
        }

        private void diaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.viewModel.empresa.diaRendicion = (ushort) diaNumericUpDown.Value;
        }

        private void habilitadaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.viewModel.empresa.estado = habilitadaCheckBox.Checked;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.nombreText.Text = null;
            this.cuitText.Text = null;
            this.direccionText.Text = null;
            this.diaNumericUpDown.Value = 1;
            this.rubroComboBox.Text = null;
            this.habilitadaCheckBox.Checked = false;

            this.viewModel.empresa = new EmpresaBuilder();
        }

        private void altaButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new EmpresasAltaConfirmacion(this, this.viewModel.empresa.crear()).Show();
            }
            catch (NoSePuedeCrearException excepcion)
            {
                new EmpresasAdvertenciaFaltanCampos(this, excepcion).Show();
            }
            catch (YaExisteObjetoConEsaClave excepcion)
            {
                new EmpresasAdvertenciaMismoCuit(this, excepcion).Show();
            }
        }
    }
}

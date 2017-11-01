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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            this.empresasSeleccionABM.Show();

            this.empresasSeleccionABM.Activate();
        }

        private void nombreText_TextChanged(object sender, EventArgs e)
        {
            this.viewModel.cambiarNombre(nombreText.Text);
        }

        private void cuitText_TextChanged(object sender, EventArgs e)
        {
            this.viewModel.cambiarCuit(cuitText.Text);
        }

        private void direccionText_TextChanged(object sender, EventArgs e)
        {
            this.viewModel.cambiarDireccion(direccionText.Text);
        }

        private void rubroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.viewModel.cambiarRubro(rubroComboBox.Text);
        }

        private void diaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.viewModel.cambiarDiaRendicion((ushort) diaNumericUpDown.Value);
        }

        private void habilitadaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.viewModel.cambiarEstado(habilitadaCheckBox.Checked);
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.viewModel.limpiar();
        }

        private void altaButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new EmpresasAltaConfirmacion(this, this.viewModel.darDeAlta()).Show();
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

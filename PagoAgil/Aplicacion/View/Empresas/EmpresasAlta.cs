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
        private EmpresasAltaVM viewModel = new EmpresasAltaVM();

        public EmpresasAlta()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.iniciarCampos();
        }

        public EmpresasAlta(EmpresaBuilder empresaBuilder) : this()
        {
            this.viewModel.empresa = empresaBuilder;
            this.rellenarConLoAnterior();
        }

        private void rellenarConLoAnterior()
        {
            this.nombreText.Text = this.viewModel.empresa.nombre;
            this.cuitText.Text = this.viewModel.empresa.cuit;
            this.direccionText.Text = this.viewModel.empresa.direccion;
            this.diaNumericUpDown.Value = this.viewModel.empresa.diaRendicion;
            this.porcentajeNumericUpDown.Value = this.viewModel.empresa.porcentajeComision;
            this.rubroComboBox.Text = this.viewModel.empresa.rubro;
            this.habilitadaCheckBox.Checked = this.viewModel.empresa.estado;
        }

        private void iniciarCampos()
        {
            this.viewModel.empresa.diaRendicion = 1;
            this.viewModel.empresa.porcentajeComision = 1;
            foreach (String rubro in this.viewModel.rubros) this.rubroComboBox.Items.Add(rubro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            new EmpresasSeleccionABM().Show();
        }

        private void cuitText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8) return;

            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void rellenarCampos()
        {
            this.viewModel.empresa.nombre = nombreText.Text;
            this.viewModel.empresa.cuit = cuitText.Text;
            this.viewModel.empresa.direccion = direccionText.Text;
            this.viewModel.empresa.rubro = rubroComboBox.Text;
            this.viewModel.empresa.diaRendicion = (ushort) diaNumericUpDown.Value;
            this.viewModel.empresa.porcentajeComision = (ushort) porcentajeNumericUpDown.Value;
            this.viewModel.empresa.estado = habilitadaCheckBox.Checked;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.nombreText.Text = null;
            this.cuitText.Text = null;
            this.direccionText.Text = null;
            this.rubroComboBox.Text = null;
            this.diaNumericUpDown.Value = 1;
            this.porcentajeNumericUpDown.Value = 1;
            this.habilitadaCheckBox.Checked = false;

            this.viewModel.empresa = new EmpresaBuilder();
        }

        private void altaButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rellenarCampos();

                this.viewModel.empresa.validar();

                this.Close();

                new EmpresasAltaConfirmacion(this.viewModel.empresa).Show();
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

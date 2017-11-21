using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Builders.Excepciones;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
using PagoAgil.Aplicacion.View.Excepciones;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Empresas
{
    public partial class EmpresasCompletado : Form, FormABMAdapter
    {
        public EmpresasCompletadoVM viewModel = new EmpresasCompletadoVM();

        public EmpresasCompletado()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.iniciarTitulos();
            this.iniciarCampos();
            EmpresaABM.instanciar().mostrar(this);
        }

        public EmpresasCompletado(EmpresaBuilder empresaBuilder) : this()
        {
            this.viewModel.empresa = empresaBuilder;
            this.rellenarConLoAnterior();
            EmpresaABM.instanciar().mostrar(this);
        }

        private void iniciarTitulos()
        {
            this.Text = EmpresaABM.instanciar().titulosCompletado()[0];
            this.tituloLabel.Text = EmpresaABM.instanciar().titulosCompletado()[1];
            this.altaGroup.Text = EmpresaABM.instanciar().titulosCompletado()[2];
            this.altaButton.Text = EmpresaABM.instanciar().titulosCompletado()[3];
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
            this.rubroComboBox.SelectedIndex = 0;
        }

        private void cuitText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || e.KeyChar != 8 || e.KeyChar != 32) e.Handled = true;
        }

        private void rellenarCampos()
        {
            this.viewModel.empresa.nombre = nombreText.Text;
            this.viewModel.empresa.cuit = Regex.Replace(cuitText.Text, @"\s+", "");
            this.viewModel.empresa.direccion = direccionText.Text;
            this.viewModel.empresa.rubro = rubroComboBox.Text;
            this.viewModel.empresa.diaRendicion = (ushort) diaNumericUpDown.Value;
            this.viewModel.empresa.porcentajeComision = (ushort) porcentajeNumericUpDown.Value;
            this.viewModel.empresa.estado = habilitadaCheckBox.Checked;
        }

        private void limpiarAlta()
        {
            this.cuitText.Text = null;
            this.habilitadaCheckBox.Checked = true;
        }

        private void limpiarBaja()
        {
            this.nombreText.Text = null;
            this.direccionText.Text = null;
            this.rubroComboBox.SelectedIndex = 0;
            this.diaNumericUpDown.Value = 1;
            this.porcentajeNumericUpDown.Value = 1;
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            if (this.cuitText.Enabled) limpiarAlta();

            limpiarBaja();
        }

        private void altaButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rellenarCampos();

                this.viewModel.empresa.validar();

                this.Close();

                new EmpresasConfirmacion(this.viewModel.empresa).Show();
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

        public void alta()
        {
            this.viewModel.empresa.cuitActual = "No";
        }

        public void baja() { }

        public void modificacion()
        {
            if (EmpresaABM.instanciar().estado) this.habilitadaCheckBox.Enabled = false;
            this.viewModel.empresa.cuitActual = this.viewModel.empresa.cuit;
        }
    }
}

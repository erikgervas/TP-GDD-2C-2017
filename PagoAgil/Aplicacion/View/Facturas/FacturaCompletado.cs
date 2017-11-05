using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
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

namespace PagoAgil.Aplicacion.View.Facturas
{
    public partial class FacturaCompletado : Form
    {
        public FacturaCompletadoVM viewModel = new FacturaCompletadoVM();

        public FacturaCompletado()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.iniciarTitulos();
            this.iniciarCampos();
        }

        public FacturaCompletado(FacturaBuilder unaFactura): this()
        {
            this.viewModel.factura = unaFactura;
            this.rellenarConLoAnterior();
        }

        private void iniciarTitulos()
        {
            this.Text = FacturaABM.instanciar().titulosCompletado()[0];
            this.tituloLabel.Text = FacturaABM.instanciar().titulosCompletado()[1];
            this.altaGroup.Text = FacturaABM.instanciar().titulosCompletado()[2];
            this.completarButton.Text = FacturaABM.instanciar().titulosCompletado()[3];
        }

        private void rellenarConLoAnterior()
        {
            /*this.nombreText.Text = this.viewModel.factura.nombre;
            this.cuitText.Text = this.viewModel.factura.cuit;
            this.direccionText.Text = this.viewModel.factura.direccion;
            this.diaNumericUpDown.Value = this.viewModel.factura.diaRendicion;
            this.porcentajeNumericUpDown.Value = this.viewModel.factura.porcentajeComision;
            this.rubroComboBox.Text = this.viewModel.factura.rubro;
            this.habilitadaCheckBox.Checked = this.viewModel.factura.estado;*/
        }

        private void iniciarCampos()
        {
            /*this.viewModel.factura.diaRendicion = 1;
            this.viewModel.factura.porcentajeComision = 1;
            foreach (String rubro in this.viewModel.rubros) this.rubroComboBox.Items.Add(rubro);*/
        }

        private void FacturaCompletado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQL_BOYS_Data_Set.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.sQL_BOYS_Data_Set.Item);

        }
    }
}

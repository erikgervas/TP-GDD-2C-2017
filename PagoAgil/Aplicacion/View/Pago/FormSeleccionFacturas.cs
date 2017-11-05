using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.ViewModel;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.View.Pago
{
    public partial class FormSeleccionFacturas : Form
    {
        private PagoBuilder miPagoBuilder;
        private SeleccionFacturaVM VM;

        public FormSeleccionFacturas(PagoBuilder pagoBuilder)
        {
            InitializeComponent();
            this.CenterToScreen();

            miPagoBuilder = pagoBuilder;

            numericUpDownNroF.Text = "";
        }

        private void buttonBuscarFactura_Click(object sender, EventArgs e)
        {
            int numeroFactura = (int)numericUpDownNroF.Value;
            Empresa empresaSeleccionada = comboBoxEmpresa.SelectedItem as Empresa;
            DateTime fechaVencimiento = dateTimePickerFechaV.Value;

            DataTable factura = VM.buscarFactura(numeroFactura,empresaSeleccionada.id,fechaVencimiento);

            dataGridView1.DataSource = sucursalesFiltradas;

            dataGridView1.Columns[0].HeaderText = "Codigo Postal";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Direccion";
            dataGridView1.Columns[3].HeaderText = "Habilitado";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[dataGridView1.ColumnCount - 2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[dataGridView1.ColumnCount - 3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

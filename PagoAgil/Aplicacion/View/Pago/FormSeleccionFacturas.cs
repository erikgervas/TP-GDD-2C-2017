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

            VM = new SeleccionFacturaVM();
            miPagoBuilder = pagoBuilder;

            numericUpDownNroF.Text = "";

            VM.obtenerEmpresas();
           //Empresa[] empresas = VM.obtenerEmpresas();

            foreach (String nombre in this.VM.empresas) this.comboBoxEmpresa.Items.Add(nombre);
            //comboBoxEmpresa.Items.AddRange(empresas);
        }

        private void buttonBuscarFactura_Click(object sender, EventArgs e)
        {
            int numeroFactura = (int)numericUpDownNroF.Value;
            Empresa empresaSeleccionada = comboBoxEmpresa.SelectedItem as Empresa;
            DateTime fechaVencimiento = dateTimePickerFechaV.Value;

            //DataTable factura = VM.buscarFactura(numeroFactura,empresaSeleccionada.id,fechaVencimiento);

            //dataGridViewFacturas.DataSource = factura;

            dataGridViewFacturas.Columns[0].HeaderText = "Numero Factura";
            dataGridViewFacturas.Columns[1].HeaderText = "Monto Total";
            dataGridViewFacturas.Columns[2].HeaderText = "Fecha de Alta";
            dataGridViewFacturas.Columns[3].HeaderText = "Fecha de Vencimiento";
            dataGridViewFacturas.Columns[4].HeaderText = "Dni del Cliente";
            dataGridViewFacturas.Columns[5].HeaderText = "Id de Empresa";
            dataGridViewFacturas.Columns[6].HeaderText = "Numero de Rendicion";

            dataGridViewFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFacturas.Columns[dataGridViewFacturas.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}

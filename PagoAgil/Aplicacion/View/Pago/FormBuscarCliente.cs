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

namespace PagoAgil.Aplicacion.View.Pago
{
    public partial class FormBuscarCliente : Form
    {
        BuscarClientesVM VM;

        public FormBuscarCliente(FormPago form)
        {
            InitializeComponent();
            this.CenterToScreen();

            VM = new BuscarClientesVM(form);

            this.cargarGrid();

        }

        private void cargarGrid()
        {
            DataTable clientes = VM.traerClientes();

            dataGridViewClientes.DataSource = clientes;

            dataGridViewClientes.Columns[0].HeaderText = "DNI";
            dataGridViewClientes.Columns[1].HeaderText = "Nombre";
            dataGridViewClientes.Columns[2].HeaderText = "Apellido";
            dataGridViewClientes.Columns[3].HeaderText = "Fecha De Nacimiento";
            dataGridViewClientes.Columns[4].HeaderText = "Mail";
            dataGridViewClientes.Columns[5].HeaderText = "Domicilio";
            dataGridViewClientes.Columns[6].HeaderText = "Codigo Postal";
            dataGridViewClientes.Columns[7].HeaderText = "Teléfono";
            dataGridViewClientes.Columns[8].HeaderText = "Habilitado";

            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewClientes.Columns[dataGridViewClientes.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewClientes.Columns[dataGridViewClientes.ColumnCount - 5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewClientes.Columns[dataGridViewClientes.ColumnCount - 8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            int currentRow = dataGridViewClientes.CurrentCell.RowIndex;
            int DNI = int.Parse(dataGridViewClientes.Rows[currentRow].Cells[0].Value.ToString());
            VM.notificarCambio(DNI);

            this.Hide();
        }
    }
}

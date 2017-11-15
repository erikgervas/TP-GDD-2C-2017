using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Builders.Excepciones;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion.View.Excepciones;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            this.numeroTextBox.Text = this.viewModel.factura.numero.ToString();
            this.altaTimePicker.Value = this.viewModel.factura.fecha_alta;
            this.vencimientoTimePicker.Value = this.viewModel.factura.fecha_vencimiento;
            this.dniClienteTextBox.Text = this.viewModel.factura.dni_cliente.ToString();
            this.empresasNombreComboBox.Text = this.viewModel.factura.nombre_empresa;
            this.habilitadaCheckBox.Checked = this.viewModel.factura.estado;
            // Items!!

            this.viewModel.factura = new FacturaBuilder();
        }

        private void iniciarCampos()
        {
            this.altaTimePicker.Value = DateTime.Now;
            this.viewModel.factura.fecha_alta = this.altaTimePicker.Value;
            this.vencimientoTimePicker.Value = DateTime.Now.AddDays(1);
            this.viewModel.factura.fecha_vencimiento = this.vencimientoTimePicker.Value;
            foreach (Empresa unaEmpresa in this.viewModel.empresas) this.empresasNombreComboBox.Items.Add(unaEmpresa);
            this.empresasNombreComboBox.DisplayMember = "nombre";
            this.empresasNombreComboBox.SelectedIndex = 0;
            this.montoValor.Text = "0";
        }

        private void FacturaCompletado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sQL_BOYS_Data_Set.Item' table. You can move, or remove it, as needed.
            // this.itemTableAdapter.Fill(this.sQL_BOYS_Data_Set.Item);

        }

        private void limpiarBase()
        {
            this.numeroTextBox.Text = null;
            this.altaTimePicker.Value = DateTime.Now;
            this.vencimientoTimePicker.Value = DateTime.Now.AddDays(1);
            this.dniClienteTextBox.Text = null;
            this.empresasNombreComboBox.Text = null;
            this.habilitadaCheckBox.Checked = false;

            this.viewModel.factura = new FacturaBuilder();
        }

        private void limpiarItems()
        {
            this.viewModel.factura.items = new List<Item>();

            this.itemDataGrid.Rows.Clear();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.limpiarBase();
        }

        private void limpiarItemsButton_Click(object sender, EventArgs e)
        {
            this.limpiarItems();
        }

        private void limpiarTodoButton_Click(object sender, EventArgs e)
        {
            this.limpiarBase();
            this.limpiarItems();
        }

        private void rellenarCampos()
        {
            this.viewModel.factura.numero = long.Parse(this.numeroTextBox.Text);
            this.viewModel.factura.fecha_alta = this.altaTimePicker.Value;
            this.viewModel.factura.fecha_vencimiento = this.vencimientoTimePicker.Value;
            this.viewModel.factura.dni_cliente = long.Parse(this.dniClienteTextBox.Text);
            this.viewModel.factura.nombre_empresa = this.empresasNombreComboBox.Text;

            for (int i = 0; i < itemDataGrid.Rows.Count - 1; i++)
            {
                rellenarItem(itemDataGrid.Rows[i]);
            }
        }

        private void rellenarItem(DataGridViewRow dataGridViewRow)
        {
            ItemBuilder builder = new ItemBuilder();

            builder.nombre = dataGridViewRow.Cells[0].Value.ToString();
            builder.cantidad = int.Parse(dataGridViewRow.Cells[1].Value.ToString());
            builder.monto = float.Parse(dataGridViewRow.Cells[2].Value.ToString(), CultureInfo.InvariantCulture.NumberFormat);

            builder.validar();

            this.viewModel.factura.items.Add(builder.crear());
        }

        private void completarButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rellenarCampos();

                this.viewModel.factura.validar();

                this.Close();

                new FacturaConfirmado(this.viewModel.factura).Show();
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

        private void itemDataGrid_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            float montoActual = 0;

            for (int i = 0; i < itemDataGrid.Rows.Count - 1; i++)
            {
                if (itemDataGrid.Rows[i].Cells[1].Value != null && itemDataGrid.Rows[i].Cells[2].Value != null)
                {
                    int cantidad = int.Parse(itemDataGrid.Rows[i].Cells[1].Value.ToString());
                    float monto = float.Parse(itemDataGrid.Rows[i].Cells[2].Value.ToString());

                    montoActual += cantidad * monto;
                }
            }

            this.montoValor.Text = montoActual.ToString();
        }

        private void buscadorCliente_Click(object sender, EventArgs e)
        {
            this.Close();

            new FacturaBuscarDNI(this.viewModel.factura).Show();
        }
    }
}

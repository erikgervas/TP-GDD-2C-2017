using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Builders.Excepciones;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
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
    public partial class FacturaCompletado : Form, FormABMAdapter
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

        private void iniciarCampos()
        {
            this.limpiarBase();

            this.viewModel.factura.fecha_alta = this.altaTimePicker.Value;
            this.viewModel.factura.fecha_vencimiento = this.vencimientoTimePicker.Value;
            foreach (Empresa unaEmpresa in this.viewModel.empresas) this.empresasNombreComboBox.Items.Add(unaEmpresa);
            this.empresasNombreComboBox.DisplayMember = "cuit";
            this.habilitadaCheckBox.CheckState = CheckState.Checked;
        }

        private void rellenarConLoAnterior()
        {
            if(this.viewModel.factura.numero != null) this.numeroTextBox.Text = this.viewModel.factura.numero.ToString();
            this.altaTimePicker.Value = this.viewModel.factura.fecha_alta;
            this.vencimientoTimePicker.Value = this.viewModel.factura.fecha_vencimiento;
            this.dniClienteTextBox.Value = this.viewModel.factura.dni_cliente;
            this.empresasNombreComboBox.Text = this.viewModel.factura.cuit_empresa;
            this.habilitadaCheckBox.Checked = this.viewModel.factura.estado;
            foreach (Item i in this.viewModel.factura.items) this.itemDataGrid.Rows.Add(i.nombre, i.cantidad.ToString(), i.monto.ToString());
            this.montoValor.Text = this.viewModel.factura.items.Sum(i => i.montoTotal()).ToString();
            this.viewModel.factura.items = new List<Item>();
        }

        private void limpiarBase()
        {
            this.numeroTextBox.Value = 1;
            this.altaTimePicker.Value = Configuracion.fecha();
            this.vencimientoTimePicker.Value = Configuracion.fecha().AddDays(1);
            this.dniClienteTextBox.Value = 1;
            this.empresasNombreComboBox.Text = null;
            this.habilitadaCheckBox.Checked = false;

            this.viewModel.factura = new FacturaBuilder();
        }

        private void limpiarItems()
        {
            this.viewModel.factura.items = new List<Item>();

            this.itemDataGrid.Rows.Clear();
            this.montoValor.Text = "0";
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
            this.viewModel.factura.numero = (long) this.numeroTextBox.Value;
            this.viewModel.factura.fecha_alta = this.altaTimePicker.Value;
            this.viewModel.factura.fecha_vencimiento = this.vencimientoTimePicker.Value;
            this.viewModel.factura.dni_cliente = (long) this.dniClienteTextBox.Value;
            this.viewModel.factura.cuit_empresa = this.empresasNombreComboBox.Text;
            this.viewModel.factura.estado = this.habilitadaCheckBox.Checked;

            for (int i = 0; i < itemDataGrid.Rows.Count - 1; i++)
            {
                rellenarItem(itemDataGrid.Rows[i]);
            }
        }

        private void rellenarItem(DataGridViewRow dataGridViewRow)
        {
            try
            {
                ItemBuilder builder = new ItemBuilder();
                
                builder.nombre = dataGridViewRow.Cells[0].Value.ToString();
                builder.cantidad = int.Parse(dataGridViewRow.Cells[1].Value.ToString());
                builder.monto = float.Parse(dataGridViewRow.Cells[2].Value.ToString());
                builder.numero_factura = (long) numeroTextBox.Value;

                builder.validar();

                this.viewModel.factura.items.Add(builder.crear());
            }
            catch (Exception)
            {
                this.viewModel.factura.items = new List<Item>();
            }
        }

        private void itemDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(itemDataGrid_KeyPress);
        }


        private void itemDataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && itemDataGrid.CurrentCell.ColumnIndex == 1) e.Handled = true;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && itemDataGrid.CurrentCell.ColumnIndex == 2) e.Handled = true;
        }

        private void itemDataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad = 0;
            float monto = 0;
            float montoActual = 0;

            for (int i = 0; i < itemDataGrid.Rows.Count - 1; i++)
            {
                if (itemDataGrid.Rows[i].Cells[1].Value != null && itemDataGrid.Rows[i].Cells[2].Value != null)
                {
                    try
                    {
                        cantidad = int.Parse(itemDataGrid.Rows[i].Cells[1].Value.ToString());
                        if (cantidad <= 0)
                        {
                            cantidad = 1;
                            itemDataGrid.Rows[i].Cells[1].Value = null;
                            System.Media.SystemSounds.Beep.Play();
                        }
                    }
                    catch (OverflowException)
                    {
                        cantidad = 1;
                        itemDataGrid.Rows[i].Cells[1].Value = null;
                        System.Media.SystemSounds.Beep.Play();
                    }
                    try
                    {
                        monto = float.Parse(itemDataGrid.Rows[i].Cells[2].Value.ToString());
                        if (monto <= 0)
                        {
                            monto = 1;
                            itemDataGrid.Rows[i].Cells[2].Value = null;
                            System.Media.SystemSounds.Beep.Play();
                        }
                    }
                    catch (OverflowException)
                    {
                        monto = 1;
                        itemDataGrid.Rows[i].Cells[2].Value = null;
                        System.Media.SystemSounds.Beep.Play();
                    }

                    montoActual += cantidad * monto;
                }
            }

            this.montoValor.Text = montoActual.ToString();
        }

        private void buscadorCliente_Click(object sender, EventArgs e)
        {
            this.rellenarCampos();

            this.Close();

            new FacturaBuscarDNI(this.viewModel.factura).Show();
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
            catch (ValorException excepcion)
            {
                this.viewModel.factura.items = new List<Item>();

                new EmpresasAdvertenciaRendicionesPendientes(excepcion.mensaje).Show();
            }
            catch (NoSePuedeCrearException excepcion)
            {
                this.viewModel.factura.items = new List<Item>();

                new EmpresasAdvertenciaFaltanCampos(this, excepcion).Show();
            }
            catch (YaExisteObjetoConEsaClave excepcion)
            {
                this.viewModel.factura.items = new List<Item>();

                new EmpresasAdvertenciaRendicionesPendientes(excepcion.mensaje).Show();
            }
            catch (NoExisteObjetoConEsaClave excepcion)
            {
                this.viewModel.factura.items = new List<Item>();

                new EmpresasAdvertenciaRendicionesPendientes(excepcion.mensaje).Show();
            }
        }

        private void FacturaCompletado_Load(object sender, EventArgs e)
        {

        }

        public void alta()
        {
            throw new NotImplementedException();
        }

        public void baja()
        {
            throw new NotImplementedException();
        }

        public void modificacion()
        {
            throw new NotImplementedException();
        }
    }
}

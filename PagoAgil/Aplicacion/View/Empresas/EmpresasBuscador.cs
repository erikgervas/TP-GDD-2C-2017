using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
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

namespace PagoAgil.Aplicacion.View.Empresas
{
    public partial class EmpresasBuscador : Form
    {
        public EmpresasBuscadorVM viewModel = new EmpresasBuscadorVM();
        public DataGridViewRow filaElegida = null;

        public EmpresasBuscador()
        {
            InitializeComponent();
            this.CenterToScreen();
            foreach (String rubro in this.viewModel.rubros) this.rubroComboBox.Items.Add(rubro);
            this.viewModel.empresa = new EmpresaBuilder();
            this.empresasDataGrid.DataSource = null;
        }

        private void volverAInicioButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new EmpresasSeleccionABM().Show();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.nombreText.Text = null;
            this.cuitText.Text = null;
            this.rubroComboBox.Text = null;
            this.empresasDataGrid.DataSource = null;
            this.empresaElegidaText.Value = 1;

            this.viewModel.empresa = new EmpresaBuilder();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            
            this.empresasDataGrid.DataSource = this.viewModel.buscar(this.nombreText.Text, this.cuitText.Text, this.rubroComboBox.Text, (long) this.empresaElegidaText.Value);
        }

        private void cuitText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == 8) return;

            else e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private void empresasDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow[] filas = empresasDataGrid.Rows.Cast<DataGridViewRow>().ToArray();

                filaElegida = filas[e.RowIndex];

                this.generarEmpresa();

                this.modificarButton.Enabled = true;
                this.bajaButton.Enabled = true;

                if (this.viewModel.empresa.estado == false) this.bajaButton.Enabled = false;
            }
            catch (NullReferenceException)
            {

            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void EmpresasBuscador_Load(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.sQL_BOYS_Data_Set.Empresa);
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            new EmpresasBuscadorSeleccionar(this).Show();
        }

        private void generarEmpresa()
        {
            this.viewModel.empresa.id = long.Parse(valorCelda(0));
            this.viewModel.empresa.nombre = valorCelda(1);
            this.viewModel.empresa.cuit = valorCelda(2);
            this.viewModel.empresa.direccion = valorCelda(3);
            this.viewModel.empresa.porcentajeComision = ushort.Parse(this.valorCelda(4));
            this.viewModel.empresa.diaRendicion = ushort.Parse(this.valorCelda(5));
            this.viewModel.empresa.rubro = valorCelda(7);
            this.viewModel.empresa.estado = bool.Parse(valorCelda(8));
        }

        private string valorCelda(int celda)
        {
            return filaElegida.Cells[celda].Value.ToString();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            this.Close();

            EmpresaABM.instanciar().abm = new Modificacion<Empresa>();

            new EmpresasCompletado(this.viewModel.empresa).Show();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            this.Close();

            EmpresaABM.instanciar().abm = new Baja<Empresa>();

            new EmpresasConfirmacion(this.viewModel.empresa).Show();
        }
    }
}

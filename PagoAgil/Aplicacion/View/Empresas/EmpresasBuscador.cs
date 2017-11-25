using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.Excepciones;
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
using System.Text.RegularExpressions;
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
            this.empresaElegidaText.Text = "";
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
            this.empresaElegidaText.Value = 0;
            this.empresaElegidaText.Text = "";

            this.viewModel.empresa = new EmpresaBuilder();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            this.empresasDataGrid.DataSource = this.viewModel.buscar(this.nombreText.Text, Regex.Replace(this.cuitText.Text, @"\s+", ""), this.rubroComboBox.Text, (long) this.empresaElegidaText.Value);
        }

        private void cuitText_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) || e.KeyChar != 8 || e.KeyChar != 32) e.Handled = true;
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
            try
            {
                this.viewModel.empresa.id = long.Parse(valorCelda(0));
                this.viewModel.empresa.nombre = valorCelda(1);
                this.viewModel.empresa.cuit = Regex.Replace(valorCelda(2), @"\s+", "");
                this.viewModel.empresa.direccion = valorCelda(3);
                this.viewModel.empresa.porcentajeComision = ushort.Parse(this.valorCelda(4));
                this.viewModel.empresa.diaRendicion = ushort.Parse(this.valorCelda(5));
                this.viewModel.empresa.rubro = valorCelda(7);
                bool estado = (bool) filaElegida.Cells[8].Value;
                this.viewModel.empresa.estado = estado;
                EmpresaABM.instanciar().estado = estado;
            }
            catch (FormatException)
            {

            }
        }

        private string valorCelda(int celda)
        {
            return filaElegida.Cells[celda].Value.ToString();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            EmpresaABM.instanciar().abm = new Modificacion<Empresa>();

            new EmpresasCompletado(this.viewModel.empresa).Show();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            try
            {

                int facturasPendientesDePago = (int)EjecutadorDeFunciones.instanciar().ejecutarFuncion("cantidadDeFacturasPorPagarDeEmpresa", this.viewModel.empresa.id, SqlDbType.Int);

                int facturasPendientesDeRendicion = (int) EjecutadorDeFunciones.instanciar().ejecutarFuncion("cantidadDeFacturasPorRendirDeEmpresa", this.viewModel.empresa.id, SqlDbType.Int);

                if ((facturasPendientesDePago + facturasPendientesDeRendicion) > 0) throw new FacturasPendientesDeRendicionException(this.viewModel.empresa, facturasPendientesDeRendicion, facturasPendientesDePago);

                EmpresaABM.instanciar().abm = new Baja<Empresa>();

                new EmpresasConfirmacion(this.viewModel.empresa).Show();
            }
            catch (FacturasPendientesDeRendicionException excepcion)
            {
                new EmpresasAdvertenciaRendicionesPendientes(excepcion).Show();
            }
        }
    }
}

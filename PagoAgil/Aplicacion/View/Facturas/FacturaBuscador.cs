using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
using PagoAgil.Aplicacion.View.Empresas;
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
    public partial class FacturaBuscador : Form
    {
        FacturaBuilder viewModel = new FacturaBuilder();
        public DataGridViewRow filaElegida = null;

        public FacturaBuscador()
        {
            InitializeComponent();
            this.CenterToScreen();
            foreach (Empresa unaEmpresa in RepositorioEmpresas.instanciar().listarElementos()) this.empresaComboBox.Items.Add(unaEmpresa);
            empresaComboBox.DisplayMember = "cuit";
        }

        private void buscadorCliente_Click(object sender, EventArgs e)
        {
            this.Hide();

            new FacturaFiltrarDNI(this).Show();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            this.Close();

            FacturaABM.instanciar().abm = new Modificacion<Factura>();

            ItemABM.instanciar().abm = new Modificacion<Item>();

            new FacturaCompletado(this.viewModel).Show();
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            this.Close();

            FacturaABM.instanciar().abm = new Baja<Factura>();

            ItemABM.instanciar().abm = new Baja<Item>();

            new FacturaConfirmado(this.viewModel).Show();
        }

        private void empresasDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow[] filas = empresasDataGrid.Rows.Cast<DataGridViewRow>().ToArray();

            filaElegida = filas[e.RowIndex];

            this.generarFactura();
        }

        private void generarFactura()
        {
            this.viewModel.numero = long.Parse(valorCelda(0));
            this.viewModel.fecha_alta = DateTime.Parse(valorCelda(2));
            this.viewModel.fecha_vencimiento = DateTime.Parse(valorCelda(3));
            this.viewModel.dni_cliente = long.Parse(valorCelda(4));
            this.viewModel.cuit_empresa = RepositorioEmpresas.instanciar().listarElementos().Find(e => e.id == long.Parse(valorCelda(5))).cuit;

            DataGridViewCheckBoxCell coso = filaElegida.Cells[7].Value as DataGridViewCheckBoxCell;

            this.viewModel.estado = Convert.ToBoolean(coso);
        }

        private string valorCelda(int celda)
        {
            return filaElegida.Cells[celda].Value.ToString();
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.numeroNumericUpDown.Text = "";
            this.empresaComboBox.SelectedValue = 0;
            this.dniNumericUpDown.Text = "";
            this.pagadaCheckbox.Checked = false;
            this.rendidaCheckbox.Checked = false;
            this.habilitadaCheckbox.Checked = false;
            this.empresasDataGrid.Rows.Clear();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            this.empresasDataGrid.DataSource = RepositorioFacturas.instanciar().obtenerTablaFiltrados(this.parametrosFiltro());
        }

        private List<Parametro> parametrosFiltro()
        {
            List<Parametro> parametros = new List<Parametro>(6);

            parametros.Add(ParametroFactory.crear("numero_factura", SqlDbType.Int, darLong(numeroNumericUpDown)));
            parametros.Add(ParametroFactory.crear("cuit_empresa", SqlDbType.NVarChar, darString(empresaComboBox)));
            parametros.Add(ParametroFactory.crear("dni_cliente", SqlDbType.Int, darLong(dniNumericUpDown)));
            parametros.Add(ParametroFactory.crear("pagada", SqlDbType.Bit, this.pagadaCheckbox.Checked));
            parametros.Add(ParametroFactory.crear("rendida", SqlDbType.Bit, this.rendidaCheckbox.Checked));
            parametros.Add(ParametroFactory.crear("habilitadx", SqlDbType.Bit, this.habilitadaCheckbox.Checked));

            return parametros;
        }

        private bool estaVacio(String campo)
        {
            return campo == null || campo.Count() == 0;
        }

        private string darString(ComboBox campo)
        {
            return (!estaVacio(campo.Text)) ? campo.Text : "";
        }

        private long darLong(TextBox campo)
        {
            return (!estaVacio(campo.Text)) ? long.Parse(campo.Text) : 0;
        }

        private void FacturaBuscador_Load(object sender, EventArgs e)
        {

        }
    }
}

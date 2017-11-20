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
        public bool rendida_pagada { get; set; }
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

            this.adjuntarItems();

            new FacturaConfirmado(this.viewModel).Show();
        }

        private void empresasDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow[] filas = empresasDataGrid.Rows.Cast<DataGridViewRow>().ToArray();

            filaElegida = filas[e.RowIndex];

            this.generarFactura();

            this.modificarButton.Enabled = !rendida_pagada;

            if (this.viewModel.estado)
            {
                this.modificarButton.Text = "Deshabilitar";

                FacturaABM.instanciar().abm = new Baja<Factura>();

                ItemABM.instanciar().abm = new Baja<Item>();
            }
            else
            {
                this.modificarButton.Text = "Habilitar";

                FacturaABM.instanciar().abm = new Modificacion<Factura>();

                ItemABM.instanciar().abm = new Modificacion<Item>();
            }
        }

        private void generarFactura()
        {
            this.viewModel.numero = long.Parse(valorCelda(0));
            this.viewModel.fecha_alta = DateTime.Parse(valorCelda(2));
            this.viewModel.fecha_vencimiento = DateTime.Parse(valorCelda(3));
            this.viewModel.dni_cliente = long.Parse(valorCelda(4));
            this.viewModel.cuit_empresa = valorCelda(6);
            if (valorCelda(7).Count() == 0 && valorCelda(8).Count() == 0) this.rendida_pagada = false; else this.rendida_pagada = true;
            this.viewModel.estado = (bool) filaElegida.Cells[9].Value;
        }

        private void adjuntarItems()
        {
            DataTable tabla = ProveedorDeTablas.instanciar().obtenerTabla("darItems", this.viewModel.numero, SqlDbType.Int);

            List<Item> nuevosItems = new List<Item>();

            List<DataRow> filas = new List<DataRow>(tabla.Select());

            foreach(DataRow fila in filas)
            {
                long id = long.Parse(fila[0].ToString());
                string nombre = fila[1].ToString();
                float monto = float.Parse(fila[2].ToString());
                int cantidad = int.Parse(fila[3].ToString());

                nuevosItems.Add(new Item(id, nombre, monto, cantidad, this.viewModel.numero));
            }

            this.viewModel.items = nuevosItems;
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
            this.empresasDataGrid.DataSource = null;
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            this.empresasDataGrid.DataSource = RepositorioFacturas.instanciar().obtenerTablaFiltrados(this.parametrosFiltro());
        }

        private List<Parametro> parametrosFiltro()
        {
            List<Parametro> parametros = new List<Parametro>(3);

            parametros.Add(ParametroFactory.crear("numero_factura", SqlDbType.Int, darLong(numeroNumericUpDown)));
            parametros.Add(ParametroFactory.crear("cuit_empresa", SqlDbType.NVarChar, darString(empresaComboBox)));
            parametros.Add(ParametroFactory.crear("dni_cliente", SqlDbType.Int, darLong(dniNumericUpDown)));

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

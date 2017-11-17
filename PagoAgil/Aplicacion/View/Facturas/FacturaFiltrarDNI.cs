using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Builders;
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
    public partial class FacturaFiltrarDNI : Form
    {
        private FacturaBuscador facturaBuscador;

        public FacturaFiltrarDNI()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.clientesDataGrid.DataSource = RepositorioClientes.getInstance().obtenerTabla();
        }

        public FacturaFiltrarDNI(FacturaBuscador facturaBuscador) : this()
        {
            this.facturaBuscador = facturaBuscador;
        }

        private void FacturaBuscarDNI_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.sQL_BOYS_Data_Set.Cliente);
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            this.facturaBuscador.dniNumericUpDown.Text = this.clientesDataGrid.CurrentRow.Cells[0].Value.ToString();

            this.Close();

            this.facturaBuscador.Show();
        }
    }
}

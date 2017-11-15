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
    public partial class FacturaBuscarDNI : Form
    {
        private FacturaBuilder facturaBuilder;

        public FacturaBuscarDNI()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.clientesDataGrid.DataSource = RepositorioClientes.getInstance().obtenerTabla();
        }

        public FacturaBuscarDNI(FacturaBuilder unaFacturaBuilder) : this()
        {
            this.facturaBuilder = unaFacturaBuilder;
        }

        private void FacturaBuscarDNI_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.sQL_BOYS_Data_Set.Cliente);
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            long dni = long.Parse(this.clientesDataGrid.CurrentRow.Cells[0].Value.ToString());

            this.facturaBuilder.dni_cliente = dni;

            this.Close();

            new FacturaCompletado(this.facturaBuilder).Show();
        }
    }
}

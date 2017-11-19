using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;
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
    public partial class EmpresasBuscadorSeleccionar : Form
    {
        private EmpresasBuscador empresasBuscador;

        public EmpresasBuscadorSeleccionar(EmpresasBuscador empresasBuscador)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.empresasDataGrid.DataSource = RepositorioEmpresas.instanciar().obtenerTabla();
            this.empresasBuscador = empresasBuscador;
        }

        private void EmpresasBuscadorSeleccionar_Load(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.sQL_BOYS_Data_Set.Empresa);
        }

        private void bajaButton_Click(object sender, EventArgs e)
        {
            this.empresasBuscador.empresaElegidaText.Value = long.Parse(this.empresasDataGrid.CurrentRow.Cells[0].Value.ToString());

            this.Close();

            this.empresasBuscador.Show();
        }
    }
}

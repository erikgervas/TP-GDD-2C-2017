using PagoAgil.Aplicacion.View;
using System;
using System.Windows.Forms;
using System.Data;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormBajaSucursal : Form
    {
        BajaSucursalVM bajaSucursalVM;
        int cp;

        public FormBajaSucursal(int codigoPostalElegido)
        {
            InitializeComponent();
            this.CenterToScreen();
            cp = codigoPostalElegido;

            bajaSucursalVM = new BajaSucursalVM();
            cargarSucursalElegida();
        }

        public void cargarSucursalElegida()
        {

            DataTable sucursalesFiltradas = bajaSucursalVM.traerSucursalElegida(cp);

            dataGridView1.DataSource = sucursalesFiltradas;

            dataGridView1.Columns[0].HeaderText = "Codigo Postal";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Direccion";
            dataGridView1.Columns[3].HeaderText = "Habilitado";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[dataGridView1.ColumnCount - 2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[dataGridView1.ColumnCount - 3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bajaSucursalVM.darDeBaja(cp);
            this.Hide();
        }

    }
}

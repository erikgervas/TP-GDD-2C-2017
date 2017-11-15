using PagoAgil.Aplicacion.View;
using System;
using System.Windows.Forms;
using System.Data;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.View.Sucursales.Excepciones;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormBajaSucursal : Form
    {
        BajaSucursalVM bajaSucursalVM;
        SucursalDB sucursal;

        public FormBajaSucursal(SucursalDB sucursalElegida)
        {
            InitializeComponent();
            this.CenterToScreen();
            sucursal = sucursalElegida;

            bajaSucursalVM = new BajaSucursalVM();
            cargarSucursalElegida();
        }

        public void cargarSucursalElegida()
        {

            DataTable sucursalesFiltradas = bajaSucursalVM.traerSucursalElegida(sucursal.codigoPostal);

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
            try
            {
                bajaSucursalVM.darDeBaja(sucursal);
            }
            catch (SucursalYaDeshabilitadaException)
            {
                MessageBox.Show("La sucursal seleccionada ya se encuentra deshabilitada");
                return;
            }
            catch (DeshabilitarSucursalActualException)
            {
                MessageBox.Show("No puede deshabilitar la sucursal en la que se encuentre loggeado en este momento");
                return;
            }

            this.Hide();
        }

    }
}

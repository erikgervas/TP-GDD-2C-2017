using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.ViewModel;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.View.Sucursales
{
    public partial class FormListadoSucursales : Form
    {
        ListadoSucursalesVM VM = new ListadoSucursalesVM();

        public FormListadoSucursales(String accion)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            string nombreSucursal = textBoxNombre.Text.Trim();
            string direccionSucursal = textBoxDireccion.Text.Trim();
            int codigoPostal = (int) numericUpDownCP.Value;

            //DataTable sucursalesFiltradas = VM.filtrarSucursales(nombreSucursal, direccionSucursal, codigoPostal);

            DataTable sucursalesFiltradas = RepositorioSucursales.getInstancia().getAlmacenamiento().darTodosEnTabla();

            dataGridView1.DataSource = sucursalesFiltradas;

            dataGridView1.Columns[0].HeaderText = "Codigo Postal";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Direccion";
            dataGridView1.Columns[3].HeaderText = "Habilitado";
        }

        private void FormListadoSucursales_Load(object sender, EventArgs e)
        {
            numericUpDownCP.Text = "";
        }

    }
}

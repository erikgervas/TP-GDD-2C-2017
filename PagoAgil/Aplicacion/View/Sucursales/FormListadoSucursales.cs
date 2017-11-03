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

            /*List<SucursalDB> sucursalesFiltradas = new List<SucursalDB>();

            //sucursalesFiltradas = VM.filtrarSucursales(nombreSucursal,direccionSucursal,codigoPostal);

            List<Sucursal> sucursalesFiltradas2 = new List<Sucursal>();
            Sucursal sucu = new Sucursal(1, "Sucu", true, "Meh", 1111);
            sucursalesFiltradas2.Add(sucu);
            
            sucursalesFiltradas.Add(RepositorioSucursales.getInstancia().getAlmacenamiento().darTodos().ElementAt(0));
            dataGridView1.DataSource = sucursalesFiltradas;

            //dataGridView1.Columns[1].HeaderText = "Codigo Postal";*/

        }

    }
}

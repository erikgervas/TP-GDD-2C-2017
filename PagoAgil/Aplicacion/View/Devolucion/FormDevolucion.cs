using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Devolucion
{
    public partial class FormDevolucion : Form
    {

        FormDevolucionVM formDevolucionVM;

        public FormDevolucion()
        {
            InitializeComponent();
            formDevolucionVM = new FormDevolucionVM();
        }

        private void buttonDevolverFactura_Click(object sender, EventArgs e)
        {


            try
            {
                formDevolucionVM.devolver(this.textNumeroFactura.Text, this.textMotivo.Text);
                MessageBox.Show("Se ha devuelto correctamente");
            }
            catch (SqlException)
            {
                MessageBox.Show("La factura ingresada es incorrecta");
            }

        }


    }
}

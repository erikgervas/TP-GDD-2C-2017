using System;
using System.Windows.Forms;
using PagoAgil.Aplicacion.View.Sucursales;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.View.Sucursales.Excepciones;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormAltaSucursal : Form
    {
        SucursalesBuilder sucursalBuilder = new SucursalesBuilder();

        public FormAltaSucursal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sucursalBuilder.nombre = textBoxNombre.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sucursalBuilder.nombre = textBoxNombre.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sucursalBuilder.nombre = textBoxNombre.Text;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            sucursalBuilder.nombre = textBoxNombre.Text;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            sucursalBuilder.domicilio = textBoxDireccion.Text;
        }

        private void numericUpDownCP_ValueChanged(object sender, System.EventArgs e)
        {
            sucursalBuilder.codigoPostal = (int) numericUpDownCP.Value;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            sucursalBuilder = new SucursalesBuilder();

            textBoxNombre.Clear();
            textBoxDireccion.Clear();
            numericUpDownCP.Value = 0;
            numericUpDownCP.Text = "";

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                SucursalDB sucursalNueva = sucursalBuilder.crearSucursal();
                RepositorioSucursales.getInstancia().getAlmacenamiento().aniadir(sucursalNueva);
                FormAltaSucursalOk formAlta = new FormAltaSucursalOk();

                formAlta.Show();
            }
            catch(System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("No se puede insertar la sucursal porque el código postal ingresado ya existe");
            }
            catch(camposVaciosException)
            {
                MessageBox.Show("No completó alguno o ninguno de los campos");
            }

        }

    }
}

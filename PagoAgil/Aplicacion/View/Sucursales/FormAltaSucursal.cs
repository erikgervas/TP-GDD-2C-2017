using System;
using System.Windows.Forms;
using PagoAgil.Aplicacion.View.Sucursales;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.BD.Utils;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormAltaSucursal : Form
    {
        SucursalesBuilder sucursalBuilder = new SucursalesBuilder();

        public FormAltaSucursal()
        {
            InitializeComponent();
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
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
           Sucursal sucursalNueva = sucursalBuilder.crearSucursal();

            RepositorioSucursales.getInstancia().alta(sucursalNueva);

            FormAltaSucursalOk formAlta = new FormAltaSucursalOk(sucursalNueva);

            formAlta.Show();

        }

    }
}

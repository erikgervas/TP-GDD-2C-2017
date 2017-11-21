using System;
using System.Windows.Forms;
using System.Data;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.View.Sucursales.Excepciones;
using PagoAgil.Aplicacion.View.Sucursales;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormModificacionSucursal : Form
    {
        SucursalDB sucursal;
        SucursalesBuilder sucursalBuilder = new SucursalesBuilder();


        public FormModificacionSucursal(SucursalDB sucursalElegida)
        {
            InitializeComponent();
            this.CenterToScreen();
            sucursal = sucursalElegida;
            sucursalBuilder.codigoPostal = sucursal.codigoPostal;

            this.cargarCampos();
        }

        public void cargarCampos() 
        {
            textBoxNombre.Text = sucursal.nombre;
            textBoxDireccion.Text = sucursal.domicilio;
            numericUpDownCP.Value = sucursal.codigoPostal;

            if (sucursal.habilitado == false)
            {
                checkBoxEstado.Checked = false;
                checkBoxEstado.Enabled = true;
            }
            else 
            {
                checkBoxEstado.Checked = true;
                checkBoxEstado.Enabled = false;
            }

        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {
           sucursalBuilder.habilitado = checkBoxEstado.Checked;
        }

        private void buttonConfirmarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                SucursalDB sucursalModificada = sucursalBuilder.crearSucursalModificada();
                RepositorioSucursales.getInstancia().getAlmacenamiento().modificar(sucursalModificada);

                this.Hide();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("No se puede insertar la sucursal porque el código postal ingresado ya existe");
            }
            catch (camposVaciosException)
            {
                MessageBox.Show("No completó alguno o ninguno de los campos");
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            sucursalBuilder.nombre = textBoxNombre.Text;
        }

        private void textBoxDireccion_TextChanged(object sender, EventArgs e)
        {
            sucursalBuilder.domicilio = textBoxDireccion.Text;
        }
    }
}

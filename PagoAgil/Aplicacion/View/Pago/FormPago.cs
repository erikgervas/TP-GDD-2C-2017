using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.View.Pago;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.ViewModel;
using PagoAgil.Aplicacion.View.Pago.Excepciones;

namespace PagoAgil.Aplicacion.View.Pago
{
    public partial class FormPago : Form
    {
        private PagoVM pagoVM;
        PagoBuilder pagoBuilder;

        public FormPago()
        {
            InitializeComponent();
            this.CenterToScreen();

            pagoVM = new PagoVM();

            MedioDePago[] medios = pagoVM.obtenerMediosDePago();

            comboBox1.Items.AddRange(medios);

            numericUpDown1.Text = "";

            textBox1.Text = Sesion.sucursal.nombre;

            dateTimePicker1.Value = Configuracion.fecha();

            pagoBuilder = new PagoBuilder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DNI = (int) numericUpDown1.Value;
            MedioDePago medioElegido = comboBox1.SelectedItem as MedioDePago;

            try
            {
                pagoVM.revisarCliente(DNI);
                if(medioElegido == null) throw new MedioDePagoNoIngresadoException("Falta el medio de pago");
            }
            catch (NoExisteClienteException)
            {
                MessageBox.Show("El DNI ingresado no se corresponde con ningún cliente o no completó el campo solicitado. Seleccione un cliente válido");
                return;
            }
            catch (ClienteDeshabilitadoException)
            {
                MessageBox.Show("El cliente elegido está deshabilitado por lo que no puede tener pagos a su nombre. Seleccione otro cliente");
                return;
            }
            catch (MedioDePagoNoIngresadoException)
            {
                MessageBox.Show("Debe ingresar el medio de pago para poder continuar");
                return;
            }

            pagoBuilder.dniCliente = DNI;
            pagoBuilder.idMedioPago = medioElegido.idMedioDePago;
            pagoBuilder.cpSucursal = Sesion.sucursal.codigoPostal;

            this.Hide();
            new FormSeleccionFacturas(pagoBuilder).Show();
        }
    }
}

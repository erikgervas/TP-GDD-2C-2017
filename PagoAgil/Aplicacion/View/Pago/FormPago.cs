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

namespace PagoAgil.Aplicacion.View.Pago
{
    public partial class FormPago : Form
    {
        private PagoVM pagoVM;

        public FormPago()
        {
            InitializeComponent();
            this.CenterToScreen();

            pagoVM = new PagoVM();

            MedioDePago[] medios = pagoVM.obtenerMediosDePago();

            comboBox1.Items.AddRange(medios);

            numericUpDown1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DNI = (int) numericUpDown1.Value;
            MedioDePago medioElegido = comboBox1.SelectedItem as MedioDePago;

            string query = "SELECT * FROM SQL_BOYS.existeCliente(" + DNI + ")";
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);
            if (tabla.cantidadDeFilas() == 0)
            {
                //TODO MENSAJE DE QUE NO EXISTE EL DNI DEL CLIENTE O ESTÁ DESHABILITADO
            }

            this.Hide();
            new FormSeleccionFacturas().Show();
        }
    }
}

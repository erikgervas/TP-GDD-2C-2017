using PagoAgil.Aplicacion.Modelo.Estadistica;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Estadisticas
{
    public partial class FormEstadisticas : Form
    {

        private EstadisticasVM estadisticasVM;

        public FormEstadisticas()
        {
            InitializeComponent();

            estadisticasVM = new EstadisticasVM();
        }

        private void FormEstadisticas_Load(object sender, EventArgs e)
        {
            Estadistica[] estadisticas = estadisticasVM.obtenerEstadisticas();

            comboEstadistica.Items.AddRange(estadisticas);

        }

        private void comboEstadistica_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.groupColumnas.Controls.Clear();

            Estadistica estadisticaElegida = this.comboEstadistica.SelectedItem as Estadistica;

            List<CheckBox> checkboxes = estadisticasVM.obtenerCheckboxes(estadisticaElegida);

            foreach (CheckBox checkbox in checkboxes)
            {

                checkbox.CheckedChanged += new EventHandler(checkbox_CheckedChanged);
                this.groupColumnas.Controls.Add(checkbox);

            }

        }

        void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (sender as CheckBox);

            if (checkBox.Checked)
            {
                estadisticasVM.agregarColumna(checkBox.Text);
            }
            else
            {
                estadisticasVM.quitarColumna(checkBox.Text);
            }

        }

        private void textAnio_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) // Permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    // El resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }

        }

        private void primerTrimestre_CheckedChanged(object sender, EventArgs e)
        {

            estadisticasVM.trimestre(1);

        }

        private void segundoTrimestre_CheckedChanged(object sender, EventArgs e)
        {

            estadisticasVM.trimestre(2);

        }

        private void tercerTrimestre_CheckedChanged(object sender, EventArgs e)
        {

            estadisticasVM.trimestre(3);

        }

        private void cuartoTrimestre_CheckedChanged(object sender, EventArgs e)
        {

            estadisticasVM.trimestre(4);

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            try
            {

                DataTable dt = estadisticasVM.calcularEstadistica(this.textAnio.Text);

                dataGridView1.AutoGenerateColumns = true;

                dataGridView1.DataSource = dt;

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (ArgumentException)
            {

                MessageBox.Show("Argumentos invalidos");

            }

        }

    }
}

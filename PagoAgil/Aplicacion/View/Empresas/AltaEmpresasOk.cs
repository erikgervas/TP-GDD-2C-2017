using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View.Empresas
{
    public partial class AltaEmpresasOk : Form
    {
        private AltaEmpresas formAnterior { get; set; }
        private Empresa empresa { get; set; }

        public AltaEmpresasOk(Empresa empresa, AltaEmpresas formAnterior)
        {
            this.empresa = empresa;
            this.formAnterior = formAnterior;

            InitializeComponent();

            textBox1.Text = this.empresa.nombre;
            textBox2.Text = this.empresa.cuit;
            textBox3.Text = this.empresa.direccion;
            textBox4.Text = this.empresa.rubro;
            textBox5.Text = ((int)this.empresa.diaRendicion).ToString();
        }

        private void darAlta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAnterior.Show();

            this.Close();
        }

    }
}

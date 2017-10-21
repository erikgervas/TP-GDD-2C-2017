using PagoAgil.Aplicacion.BD.Repositorios;
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
    public partial class AltaEmpresas : Form
    {
        List<String> empresas = new List<String>();
        EmpresaBuilder empresaBuilder = new EmpresaBuilder();

        public AltaEmpresas()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            empresaBuilder.rubro = listaRubros.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            empresaBuilder.nombre = textNombre.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            empresaBuilder.cuit = textCuit.Text;
        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {
            empresaBuilder.direccion = textDireccion.Text;
        }

        private void diaRendicion_ValueChanged(object sender, EventArgs e)
        {
            empresaBuilder.diaRendicion = (ushort) diaRendicion.Value;
        }

        private void limiparCampos_Click(object sender, EventArgs e)
        {
            empresaBuilder = new EmpresaBuilder();
        }

        private void darAlta_Click(object sender, EventArgs e)
        {
            Empresa empresaNueva = empresaBuilder.crearEmpresa();

            RepositorioEmpresas.instanciar().alta(empresaNueva);

            AltaEmpresasOk formAlta = new AltaEmpresasOk(empresaNueva);

            formAlta.Show();

            this.Hide();
        }
    }
}

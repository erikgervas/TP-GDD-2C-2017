using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Builders;
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
    public partial class EmpresasAltaConfirmacion : Form
    {
        private EmpresaBuilder empresa;

        public EmpresasAltaConfirmacion(EmpresaBuilder empresaBuilder)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.empresa = empresaBuilder;

            this.completarCampos();
        }

        private void completarCampos()
        {
            this.nombreAsignadoLabel.Text = this.empresa.nombre;
            this.cuitAsignadoLabel.Text = this.empresa.generarCuit();
            this.direccionAsignadaLabel.Text = this.empresa.direccion;
            this.rubroAsignadoLabel.Text = this.empresa.rubro;
            this.diaAsignadoLabel.Text = Convert.ToString(this.empresa.diaRendicion, 10);
            this.habilitadaCheckBox.CheckState = (this.empresa.estado) ? CheckState.Checked : CheckState.Unchecked;
        }

        private void seguirModificandoButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new EmpresasAlta(this.empresa).Show();
        }

        private void altaButton_Click(object sender, EventArgs e)
        {
            RepositorioEmpresas.instanciar().alta(this.empresa.crear());

            this.Close();

            new EmpresasAltaOk().Show();
        }
    }
}

using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs;
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
    public partial class EmpresasConfirmacion : Form
    {
        private EmpresaBuilder empresa;

        public EmpresasConfirmacion(EmpresaBuilder empresaBuilder)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.empresa = empresaBuilder;
            this.iniciarTitulos();
            this.completarCampos();
            EmpresaABM.instanciar().determinarBotones(this);
        }

        private void iniciarTitulos()
        {
            this.Text = EmpresaABM.instanciar().titulosConfirmado()[0];
            this.tituloLabel.Text = EmpresaABM.instanciar().titulosConfirmado()[1];
            this.altaGroup.Text = EmpresaABM.instanciar().titulosConfirmado()[2];
            this.altaButton.Text = EmpresaABM.instanciar().titulosConfirmado()[3];
        }

        private void completarCampos()
        {
            this.nombreAsignadoLabel.Text = this.empresa.nombre;
            this.cuitAsignadoLabel.Text = this.empresa.cuit;
            this.direccionAsignadaLabel.Text = this.empresa.direccion;
            this.rubroAsignadoLabel.Text = this.empresa.rubro;
            this.diaAsignadoLabel.Text = Convert.ToString(this.empresa.diaRendicion, 10);
            this.porcentajeAsignadoText.Text = Convert.ToString(this.empresa.porcentajeComision, 10);
            this.habilitadaCheckBox.CheckState = (this.empresa.estado) ? CheckState.Checked : CheckState.Unchecked;
        }

        private void seguirModificandoButton_Click(object sender, EventArgs e)
        {
            this.Close();

            new EmpresasCompletado(this.empresa).Show();
        }

        private void altaButton_Click(object sender, EventArgs e)
        {
            EmpresaABM.instanciar().realizarABM(RepositorioEmpresas.instanciar(), this.empresa.crear());

            this.Close();

            new EmpresasOk().Show();
        }
    }
}

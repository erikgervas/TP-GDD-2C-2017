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
    public partial class EmpresasSeleccionABM : Form
    {
        public EmpresasSeleccionABM()
        {
            InitializeComponent();
            this.CenterToScreen();
        }


        private void ingresarButton_Click(object sender, EventArgs e)
        {
            EmpresaABM.instanciar().abm = new Alta<Empresa>();

            new EmpresasCompletado().Show();
        }

        private void consultarButton_Click(object sender, EventArgs e)
        {
            new EmpresasBuscador().Show();
        }
    }
}

using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormHome : Form
    {
        HomeVM homeVM;

        public FormHome(Usuario usuario)
        {
            InitializeComponent();
            homeVM = new HomeVM(usuario);
        }

        private void button_abm_cliente_Click(object sender, EventArgs e)
        {

            new FormABMCliente().Show();

        }

        private void button_abm_empresas_Click(object sender, EventArgs e)
        {
            
            // new FormABMEmpresa().Show();
        
        }

        private void button_abm_sucursales_Click(object sender, EventArgs e)
        {

            new FormABMSucursal().Show();

        }

        private void button_abm_facturas_Click(object sender, EventArgs e)
        {

            // new FormABMFactura().Show();

        }

        private void button_rendicion_Click(object sender, EventArgs e)
        {

            // new FormRendicion().Show();

        }

        private void button_devolucion_Click(object sender, EventArgs e)
        {
            // new FormDevolucion().Show();
        }

        private void button_registro_pago_Click(object sender, EventArgs e)
        {
            // new FormRegistroPago().Show();
        }

        private void button_estadisticas_Click(object sender, EventArgs e)
        {

            // new FormEstadisticas().Show();

        }

    }
}

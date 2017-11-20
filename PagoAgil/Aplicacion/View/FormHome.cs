using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.View;
using PagoAgil.Aplicacion.View.Devolucion;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion.View.Estadisticas;
using PagoAgil.Aplicacion.View.Rendicion;
using PagoAgil.Aplicacion.View.Pago;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.View.Facturas;
using PagoAgil.Aplicacion.View.Roles;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormHome : Form
    {

        HomeVM homeVM;

        public FormHome()
        {
            InitializeComponent();
            this.CenterToScreen();
            homeVM = new HomeVM();
            /*
            button_abm_cliente.Enabled = Sesion.usuario.poseesFuncionalidad("Gestionar clientes");
            button_abm_empresas.Enabled = Sesion.usuario.poseesFuncionalidad("Gestionar empresas");
            button_abm_sucursales.Enabled = Sesion.usuario.poseesFuncionalidad("Gestionar sucursales");
            button_abm_facturas.Enabled = Sesion.usuario.poseesFuncionalidad("Gestionar facturas");
            button_abm_roles.Enabled = Sesion.usuario.poseesFuncionalidad("Gestionar roles");
            button_registro_pago.Enabled = Sesion.usuario.poseesFuncionalidad("Cobrar facturas");
            button_rendicion.Enabled = Sesion.usuario.poseesFuncionalidad("Rendir facturas");
            button_devolucion.Enabled = Sesion.usuario.poseesFuncionalidad("Devolver facturas");
            */
        }

        private void button_abm_cliente_Click(object sender, EventArgs e)
        {

            new FormABMCliente().Show();

        }

        private void button_abm_empresas_Click(object sender, EventArgs e)
        {
            new EmpresasSeleccionABM().Show();
        }

        private void button_abm_sucursales_Click(object sender, EventArgs e)
        {

            new FormABMSucursal().Show();

        }

        private void button_abm_facturas_Click(object sender, EventArgs e)
        {

            new FacturaSeleccionadorABM().Show();

        }

        private void button_rendicion_Click(object sender, EventArgs e)
        {

            new FormRendicion().Show();

        }

        private void button_devolucion_Click(object sender, EventArgs e)
        {
            new FormDevolucion().Show();
        }

        private void button_registro_pago_Click(object sender, EventArgs e)
        {
            new FormPago().Show();
        }

        private void button_estadisticas_Click(object sender, EventArgs e)
        {

            new FormEstadisticas().Show();

        }

        private void button_abm_roles_Click(object sender, EventArgs e)
        {

            new FormABMRol().Show();

        }

    }
}

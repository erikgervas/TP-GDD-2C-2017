using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.View;
using System;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormSeleccionarRol : Form
    {

        private SeleccionadorDeRolVM seleccionadorDeRolVM;

        public FormSeleccionarRol(UsuarioDB usuario)
        {
            InitializeComponent();

            seleccionadorDeRolVM = new SeleccionadorDeRolVM(usuario);
        }

        private void FormSeleccionarRol_Load(object sender, EventArgs e)
        {
            SucursalDB[] sucursales = seleccionadorDeRolVM.obtenerSucursales();

            comboSucursal.Items.AddRange(sucursales);
        }

        private void comboSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;

            comboRol.Enabled = false;

            SucursalDB sucursalSeleccionada = comboSucursal.SelectedItem as SucursalDB;

            RolDB[] roles = seleccionadorDeRolVM.obtenerRoles(sucursalSeleccionada);

            Sesion.sucursal = sucursalSeleccionada;

            comboRol.Items.AddRange(roles);

            comboRol.Enabled = true;
        }

        private void comboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

            button1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            RolDB rolSeleccionado = comboRol.SelectedItem as RolDB;

            Usuario usuario = seleccionadorDeRolVM.armarUsuario(rolSeleccionado);

            Sesion.usuario = usuario;

            this.Hide();

            new FormHome().Show();

        }

    }
}

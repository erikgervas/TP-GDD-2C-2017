using PagoAgil.Aplicación.Modelo;
using PagoAgil.Aplicación.Modelo.Cliente;
using PagoAgil.Aplicación.Modelo.Orquestador;
using PagoAgil.Aplicación.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil
{
    public partial class FormSeleccionarRol : Form
    {

        SeleccionadorDeRolVM seleccionadorDeRolVM;

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

            // Pasar a la siguiente ventana con este usuario

        }

    }
}

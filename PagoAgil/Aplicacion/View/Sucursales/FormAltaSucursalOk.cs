using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;

namespace PagoAgil.Aplicacion.View.Sucursales
{
    public partial class FormAltaSucursalOk : Form
    {
        SucursalDB sucursal;

        public FormAltaSucursalOk(SucursalDB sucursalNueva)
        {
            sucursal = sucursalNueva;

            InitializeComponent();
            this.CenterToScreen();
        }

    }
}

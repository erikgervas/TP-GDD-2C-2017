using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.View.Sucursales
{
    public partial class FormAltaSucursalOk : Form
    {
        Sucursal sucursal;

        public FormAltaSucursalOk(Sucursal sucursalNueva)
        {
            sucursal = sucursalNueva;

            InitializeComponent();
        }

    }
}

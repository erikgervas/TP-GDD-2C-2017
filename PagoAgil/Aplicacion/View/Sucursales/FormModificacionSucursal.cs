using System;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.View
{
    public partial class FormModificacionSucursal : Form
    {
        ModificacionSucursalVM modificacionSucursalVM;
        int cp;

        public FormModificacionSucursal(int codigoPostalElegido)
        {
            InitializeComponent();
            this.CenterToScreen();
            cp = codigoPostalElegido;

            modificacionSucursalVM = new ModificacionSucursalVM();
        }
    }
}

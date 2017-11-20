using PagoAgil.Aplicacion.Modelo.Excepciones;
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
    public partial class EmpresasAdvertenciaRendicionesPendientes : Form
    {
        private string p;

        public EmpresasAdvertenciaRendicionesPendientes()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public EmpresasAdvertenciaRendicionesPendientes(FacturasPendientesDeRendicionException excepcion) : this()
        {
            this.advertenciaText.Text = excepcion.mensaje();
        }

        public EmpresasAdvertenciaRendicionesPendientes(string mensaje) : this()
        {
            this.advertenciaText.Text = mensaje;
        }
    }
}

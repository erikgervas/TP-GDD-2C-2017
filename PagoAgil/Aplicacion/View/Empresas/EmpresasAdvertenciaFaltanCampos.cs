using PagoAgil.Aplicacion.Builders.Excepciones;
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
    public partial class EmpresasAdvertenciaFaltanCampos : Form
    {
        private EmpresasAlta empresasAlta;
        private NoSePuedeCrearException excepcion;

        public EmpresasAdvertenciaFaltanCampos(EmpresasAlta empresasAlta, NoSePuedeCrearException excepcion)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.empresasAlta = empresasAlta;
            this.excepcion = excepcion;
        }
    }
}

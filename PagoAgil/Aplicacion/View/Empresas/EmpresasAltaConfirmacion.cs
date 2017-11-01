using PagoAgil.Aplicacion.Modelo;
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
    public partial class EmpresasAltaConfirmacion : Form
    {
        private EmpresasAlta empresasAlta;
        private Empresa empresa;

        public EmpresasAltaConfirmacion()
        {
            InitializeComponent();
        }

        public EmpresasAltaConfirmacion(EmpresasAlta empresasAlta, Empresa empresa)
        {
            InitializeComponent();
            this.empresasAlta = empresasAlta;
            this.empresa = empresa;
        }
    }
}

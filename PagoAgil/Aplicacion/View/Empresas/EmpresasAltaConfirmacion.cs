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

            this.nombreAsignadoLabel.Text = this.empresa.nombre;
            this.cuitAsignadoLabel.Text = this.empresa.cuit;
            this.direccionAsignadaLabel.Text = this.empresa.direccion;
            this.rubroAsignadoLabel.Text = this.empresa.rubro;
            this.diaAsignadoLabel.Text = this.empresa.diaRendicion.ToString();
            this.habilitadaCheckBox.Checked = this.empresa.habilitado;
        }

        public EmpresasAltaConfirmacion(EmpresasAlta empresasAlta, Empresa empresa)
        {
            InitializeComponent();
            this.empresasAlta = empresasAlta;
            this.empresa = empresa;
        }
    }
}

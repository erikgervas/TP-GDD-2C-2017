using PagoAgil.Aplicacion.View.Excepciones;
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
    public partial class EmpresasAdvertenciaMismoCuit : Form
    {
        private EmpresasAlta empresasAlta;
        private YaExisteObjetoConEsaClave excepcion;

        public EmpresasAdvertenciaMismoCuit(EmpresasAlta empresasAlta, YaExisteObjetoConEsaClave excepcion)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.empresasAlta = empresasAlta;
            this.excepcion = excepcion;
        }
    }
}

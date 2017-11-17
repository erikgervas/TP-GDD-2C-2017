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
        private Form formulario;
        private YaExisteObjetoConEsaClave excepcion;

        public EmpresasAdvertenciaMismoCuit(Form unForm, YaExisteObjetoConEsaClave excepcion)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.formulario = unForm;
            this.excepcion = excepcion;
        }

        private void volverButton_Click(object sender, EventArgs e)
        {
            formulario.Show();
            
            this.Close();
        }
    }
}

using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.Orquestradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
    public class FormDevolucionVM
    {

        public FormDevolucionVM()
        {

        }

        public void devolver(string numeroFacturaRaw, string motivo)
        {

            GestorDeDevoluciones.getInstance().devolver(numeroFacturaRaw, motivo);

        }
    }
}

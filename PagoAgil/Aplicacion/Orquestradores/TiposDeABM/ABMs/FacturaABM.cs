using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs
{
    public class FacturaABM : GestorABM<Factura>
    {
        private static FacturaABM instancia = null;

        private FacturaABM() { }

        public static FacturaABM instanciar()
        {
            if (instancia == null) instancia = new FacturaABM();

            return instancia;
        }

        protected override string nombreAbm()
        {
            return "factura";
        }
    }
}

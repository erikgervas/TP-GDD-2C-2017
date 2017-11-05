using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs
{
    public class EmpresaABM : GestorABM<Empresa>
    {
        private static EmpresaABM instancia = null;

        private EmpresaABM() { }

        public static EmpresaABM instanciar()
        {
            if (instancia == null) instancia = new EmpresaABM();

            return instancia;
        }

        protected override string nombreAbm()
        {
            return "empresa";
        }
    }
}

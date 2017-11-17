using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM.ABMs
{
    public class ItemABM : GestorABM<Item>
    {
        private static ItemABM instancia = null;

        private ItemABM() { }

        public static ItemABM instanciar()
        {
            if (instancia == null) instancia = new ItemABM();

            return instancia;
        }

        protected override string nombreAbm()
        {
            return "item";
        }
    }
}

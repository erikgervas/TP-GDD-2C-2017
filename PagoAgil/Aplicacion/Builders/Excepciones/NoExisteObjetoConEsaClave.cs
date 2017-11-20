using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Builders.Excepciones
{
    public class NoExisteObjetoConEsaClave : Exception
    {
        public string mensaje { get; set; }
    }
}

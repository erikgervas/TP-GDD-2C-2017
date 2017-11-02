using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Builders.Excepciones
{
    public class NoSePuedeCrearException : Exception
    {
        public List<string> errores { get ; set; }

        public NoSePuedeCrearException(List<string> errores)
        {
            this.errores = errores;
        }
    }
}

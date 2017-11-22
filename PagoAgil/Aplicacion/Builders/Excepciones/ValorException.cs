using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Builders.Excepciones
{
    public class ValorException : Exception
    {
        public string mensaje;

        public ValorException(string mensaje)
        {
            this.mensaje = mensaje;
        }

    }
}

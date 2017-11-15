using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.View.Pago.Excepciones
{
    class FacturaInvalidaException : Exception
    {
        public FacturaInvalidaException(string message) : base(message) { }
    }
}

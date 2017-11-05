using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.View.Pago.Excepciones
{
    class MedioDePagoNoIngresadoException : Exception
    {
        public MedioDePagoNoIngresadoException(string message) : base(message) { }
    }
}

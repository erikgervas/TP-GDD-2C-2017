using System;

namespace PagoAgil.Aplicacion.Modelo.Excepciones
{

    public class DemasiadosIntentosException : Exception
    {
        public DemasiadosIntentosException()
        {
        }

        public DemasiadosIntentosException(string message)
            : base(message)
        {
        }

        public DemasiadosIntentosException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}
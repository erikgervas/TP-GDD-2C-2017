using System;

namespace PagoAgil.Aplicacion.Modelo.Excepciones
{

    public class UsuarioInhabilitadoException : Exception
    {
        public UsuarioInhabilitadoException()
        {
        }

        public UsuarioInhabilitadoException(string message)
            : base(message)
        {
        }

        public UsuarioInhabilitadoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}
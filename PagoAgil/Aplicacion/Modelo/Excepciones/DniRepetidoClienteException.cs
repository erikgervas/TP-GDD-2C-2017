using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo.Excepciones
{
    class DniRepetidoClienteException : Exception
    {
        public DniRepetidoClienteException()
        {
        }

        public DniRepetidoClienteException(string message)
        : base(message)
        {
        }

        public DniRepetidoClienteException(string message, Exception inner)
        : base(message, inner)
        {
           
        }
    }
}

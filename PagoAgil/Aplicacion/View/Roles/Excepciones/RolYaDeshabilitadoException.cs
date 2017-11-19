using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.View.Roles.Excepciones
{
    class RolYaDeshabilitadoException : Exception
    {
        public RolYaDeshabilitadoException(string message) : base(message) { }
    }
}

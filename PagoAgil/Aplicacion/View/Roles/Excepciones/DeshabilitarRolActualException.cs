using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.View.Roles.Excepciones
{
    class DeshabilitarRolActualException : Exception
    {
        public DeshabilitarRolActualException(string message) : base(message) { }
    }
}

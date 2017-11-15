using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.View.Sucursales.Excepciones
{
    class DeshabilitarSucursalActualException : Exception
    {
        public DeshabilitarSucursalActualException(string message) : base(message) { }
    }
}

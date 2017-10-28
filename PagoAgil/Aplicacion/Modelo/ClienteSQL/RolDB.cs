using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class RolDB : Entidad
    {

        string nombre;

        public override string ToString()
        {
            return this.nombre;
        }

    }
}

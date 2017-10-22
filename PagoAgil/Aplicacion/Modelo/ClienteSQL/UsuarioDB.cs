using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class UsuarioDB : Entidad
    {

        string nombre;
        string contrasenia;

        public UsuarioDB(long id, string nombre) : base(id)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getContrasenia()
        {
            return this.contrasenia;
        }

    }
}

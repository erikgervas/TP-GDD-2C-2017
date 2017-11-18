using PagoAgil.Aplicacion.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.Usuario
{
    public class Rol
    {

        string nombre;

        List<Funcionalidad> funcionalides;

        public Rol(string nuevoNombre, List<Funcionalidad> nuevasFuncionalidades) {

            this.nombre = nuevoNombre;
            this.funcionalides = nuevasFuncionalidades;

        }

        public Boolean posees(string funcionalidad)
        {
            return funcionalides.Any(f => f.es(funcionalidad));
        }

    }
}

using System;
using PagoAgil.Aplicacion.BD;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

namespace PagoAgil.Aplicacion.Modelo.Usuario
{
    public class Funcionalidad
    {

        public int id { get; set; }
        public string nombre { get; set;}

        public Funcionalidad(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        public Boolean es(string funcionalidad)
        {
            return nombre.Equals(funcionalidad);
        }

        public Funcionalidad(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();

            this.id = int.Parse(elementos.ElementAt(0));
            this.nombre = elementos.ElementAt(1);

        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}

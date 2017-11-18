using System;
namespace PagoAgil.Aplicacion.Modelo.Usuario
{
    public class Funcionalidad
    {

        string nombre;

        public Funcionalidad(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }

        public Boolean es(string funcionalidad)
        {
            return nombre.Equals(funcionalidad);
        }

    }
}

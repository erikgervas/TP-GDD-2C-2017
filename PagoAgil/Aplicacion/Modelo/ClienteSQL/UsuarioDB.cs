using PagoAgil.Aplicacion.BD;
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
        Boolean habilitado;

        public UsuarioDB(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();

            this.id = long.Parse(elementos.ElementAt(0));
            this.nombre = elementos.ElementAt(1);
            this.contrasenia = elementos.ElementAt(2);
            this.habilitado = elementos.ElementAt(3).Equals("True") ? true : false; 

        }

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

        public Boolean getHabilitado()
        {
            return this.habilitado;
        }

    }
}

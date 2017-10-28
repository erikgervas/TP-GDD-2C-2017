using PagoAgil.Aplicacion.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class SucursalDB : Entidad
    {

        string nombre;
        Boolean habilitado;

        public SucursalDB(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();

            this.id = long.Parse(elementos.ElementAt(0));
            this.nombre = elementos.ElementAt(1);
            this.habilitado = elementos.ElementAt(4).Equals("True") ? true : false;

        }

        internal long getID()
        {
            return this.id;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public Boolean getHabilitado()
        {
            return this.habilitado;
        }

    }
}

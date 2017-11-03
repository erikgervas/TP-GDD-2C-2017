using PagoAgil.Aplicacion.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class SucursalDB
    {
        public int codigoPostal { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public bool habilitado { get; set; }

        public SucursalDB(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();
            this.codigoPostal = int.Parse(elementos.ElementAt(0));
            this.nombre = elementos.ElementAt(1);
            this.domicilio = elementos.ElementAt(2);
            this.habilitado = elementos.ElementAt(3).Equals("True") ? true : false;

        }

        public SucursalDB(int unCodigoPostal, string unNombre, string unDomicilio, bool unEstado)
        {
            this.codigoPostal = unCodigoPostal;
            this.nombre = unNombre;
            this.domicilio = unDomicilio;
            this.habilitado = unEstado;
        }

        internal int getId()
        {
            return this.codigoPostal;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public bool getHabilitado()
        {
            return this.habilitado;
        }

    }
}

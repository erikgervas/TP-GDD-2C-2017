using PagoAgil.Aplicacion.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class SucursalDB
    {
        int codigoPostal { get; set; }
        string nombre { get; set; }
        string domicilio { get; set; }
        bool habilitado { get; set; }

        public SucursalDB(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();
            /*this.codigoPostal = int.Parse(elementos.ElementAt(0));
            this.nombre = elementos.ElementAt(1);
            this.domicilio = elementos.ElementAt(2);
            this.habilitado = elementos.ElementAt(3).Equals("True") ? true : false;*/

            this.codigoPostal = 2222;
            this.nombre = "JAJ";
            this.domicilio = "CHAU";
            this.habilitado = true;
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

using PagoAgil.Aplicacion.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    class ClienteDB : Entidad
    {
        string nombre { get; set; }
        string apellido { get; set; }
        DateTime nacimiento { get; set; }
        string mail { get; set; }
        string domicilio { get; set; }
        string codigoPostal { get; set; }
        int telefono { get; set; }
        Boolean habilitado { get; set; }


        public ClienteDB(FilaDTO fila)
        {

            List<string> elementos = fila.obtener();

            this.id = long.Parse(elementos.ElementAt(0)); //DNI
            this.nombre = elementos.ElementAt(1);
            this.apellido = elementos.ElementAt(2);
            this.nacimiento = DateTime.Parse(elementos.ElementAt(3));
            this.mail = elementos.ElementAt(4);
            this.domicilio = elementos.ElementAt(5);
            this.codigoPostal = elementos.ElementAt(6);
            this.telefono = int.Parse(elementos.ElementAt(7));
            this.habilitado = elementos.ElementAt(8).Equals("True") ? true : false;

        }

        public Boolean getHabilitado()
        {
            return this.habilitado;
        }
    }
}

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
        string nombre;
        string apellido;
        DateTime nacimiento;
        string mail;
        string domicilio;
        string codigoPostal;
        int telefono;
        Boolean habilitado;

        public ClienteDB()
        {
            
        }

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

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }

        public Boolean getHabilitado()
        {
            return this.habilitado;
        }
    }
}

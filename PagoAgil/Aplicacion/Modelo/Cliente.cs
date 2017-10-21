using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Cliente : Identificable
    {
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public int codigoPostal { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public Cliente(long id, string nombre, string apellido, int dni, string mail, int telefono, string direccion, int codigoPostal, DateTime fechaNacimiento) : base (id, nombre)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.mail = mail;
            this.telefono = telefono;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.fechaNacimiento = fechaNacimiento;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion
{
    class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string mail;
        private int telefono;
        private string direccion;
        private int codigoPostal;
        private DateTime fechaNacimiento;

        Cliente(string nombre,string apellido,int dni,string mail,int telefono,string direccion, int codigoPostal, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.mail = mail;
            this.telefono = telefono;
            this.direccion = direccion;
            this.codigoPostal = codigoPostal;
            this.fechaNacimiento = fechaNacimiento;
        }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Mail { get => mail; set => mail = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int CodigoPostal { get => codigoPostal; set => codigoPostal = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    }
}


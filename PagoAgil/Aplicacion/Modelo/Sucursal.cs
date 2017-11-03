using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Sucursal
    {
        public int codigoPostal { get; set; }
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public bool estado { get; set; }

        public Sucursal( int unCodigoPostal, string unNombre, string unDomicilio, bool unEstado)
        {
            this.codigoPostal = unCodigoPostal;
            this.nombre = unNombre;
            this.domicilio = unDomicilio;
            this.estado= unEstado;
        }

    }
}

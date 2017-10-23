using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.Modelo
{
    class Sucursal : Habilitable
    {

        public string domicilio { get; set; }
        public int codigoPostal { get; set; }

        public Sucursal(long unId, string unNombre, bool unEstado, string unDomicilio, int unCodigoPostal) : base (unId, unNombre, unEstado)
        {
            this.domicilio = unDomicilio;
            this.codigoPostal = unCodigoPostal;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo
{
    abstract public class Entidad
    {
        public long id { get; set; }

        public Entidad()
        {

        }

        public Entidad (long unId)
        {
            this.id = unId;
        }

        public long getId() 
        {
            return this.id;
        }

    }
}

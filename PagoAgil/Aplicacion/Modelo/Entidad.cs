using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Entidad
    {
        public long id { get; set /* Hacer que sólo el repositorio lo pueda setear */ ; }

        public Entidad (long unId)
        {
            this.id = unId;
        }
    }
}

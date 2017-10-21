using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo
{
    public abstract class Habilitable : Identificable
    {
        private bool habilitado { get; set; }

        public Habilitable(long unId, string unNombre, bool unEstado) : base(unId, unNombre)
        {
            this.habilitado = unEstado;
        }

        public virtual void habilitar()
        {
            this.habilitado = true;
        }

        public virtual void deshabilitar()
        {
            this.habilitado = false;
        }
    }
}

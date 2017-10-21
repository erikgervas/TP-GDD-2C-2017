using PagoAgil.Aplicacion.BD.MediosPersistentes;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public abstract static class Repositorio<E> where E : Entidad
    {
        private Medio<E> almacenamiento { get; set; }

        public virtual void alta(E unaEntidad)
        {
            this.almacenamiento.aniadir(unaEntidad);
        }

        public virtual void baja(E unaEntidad)
        {
            this.almacenamiento.eliminar(unaEntidad);
        }

        public void modificacion(E unaEntidad)
        {
            this.almacenamiento.modificar(unaEntidad);
        }
    }
}

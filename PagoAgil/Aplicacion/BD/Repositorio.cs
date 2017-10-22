using PagoAgil.Aplicacion.BD.MediosPersistentes;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public abstract class Repositorio<E> where E : Entidad
    {
        public Medio<E> almacenamiento { get; set; }
        public long proximoId { get { return this.almacenamiento.asignarId(); } }

        public List<E> listarElementos()
        {
           return this.almacenamiento.darTodos();
        }

        public E obtener(string nombre)
        {
            return this.almacenamiento.dar(nombre);
        }

        public void alta(E unaEntidad)
        {
            this.almacenamiento.aniadir(unaEntidad);
        }

        public void baja(E unaEntidad)
        {
            this.almacenamiento.eliminar(unaEntidad);
        }

        public void modificacion(E unaEntidad)
        {
            this.almacenamiento.modificar(unaEntidad);
        }
    }
}

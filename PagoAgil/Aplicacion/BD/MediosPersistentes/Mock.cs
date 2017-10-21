using PagoAgil.Aplicacion.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes
{
    public class Mock<E> : Medio<E> where E : Entidad
    {
        List<E> lista { get; set; }

        public List<E> darTodos()
        {
            return this.lista;
        }

        public void aniadir(E unaEntidad)
        {
            this.lista.Add(unaEntidad);
        }

        public void eliminar(E unaEntidad)
        {
            this.lista.Remove(unaEntidad);
        }

        public void modificar(E unaEntidad)
        {
            E entidadDesactualizada = this.lista.First(e => e.id == unaEntidad.id);
            
            entidadDesactualizada = unaEntidad;
        }


        public void aniadir(object unaEntidad)
        {
            throw new System.NotImplementedException();
        }

        public void eliminar(object unaEntidad)
        {
            throw new System.NotImplementedException();
        }

        public void modificar(object unaEntidad)
        {
            throw new System.NotImplementedException();
        }
    }
}

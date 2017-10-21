using PagoAgil.Aplicacion.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes
{
    public class Mock<E> : Medio<E> where E : Entidad
    {
        public List<E> lista { get; set; }

        public Mock(List<E> unaLista)
        {
            this.lista = unaLista;
        }

        public List<E> darTodos()
        {
            return this.lista;
        }

        public void aniadir(E unaEntidad)
        {
            this.lista.Add(unaEntidad);
        }

        public long asignarId()
        {
            return this.lista.Count + 1;
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
    }
}

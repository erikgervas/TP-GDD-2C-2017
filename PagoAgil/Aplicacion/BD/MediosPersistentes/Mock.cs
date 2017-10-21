using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

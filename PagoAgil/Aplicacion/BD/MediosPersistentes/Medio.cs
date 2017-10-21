using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes
{
    public interface Medio<E> where E : Entidad
    {
        List<E> darTodos();

        void aniadir(E unaEntidad);

        void eliminar(E unaEntidad);

        void modificar(E unaEntidad);
    }
}

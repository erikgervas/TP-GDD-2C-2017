using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes
{
    interface Medio<E> where E : Entidad
    {
        void aniadir(object unaEntidad);

        void eliminar(object unaEntidad);

        void modificar(object unaEntidad);
    }
}

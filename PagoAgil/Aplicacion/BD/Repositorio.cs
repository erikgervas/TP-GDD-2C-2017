using PagoAgil.Aplicacion.BD.MediosPersistentes;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public abstract class Repositorio<E>
    {
        public Medio<E> almacenamiento { get; set; }
        public long proximoId { get { return this.almacenamiento.asignarId(); } }

        public List<E> listarElementos()
        {
           return this.almacenamiento.darTodos();
        }

        public DataTable obtenerTabla()
        {
            return this.almacenamiento.darTabla();
        }

        public DataTable obtenerTablaFiltrados(List<Parametro> parametros)
        {
            return this.almacenamiento.darTablaFiltrados(parametros);
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

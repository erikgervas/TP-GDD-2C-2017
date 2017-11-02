using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    public abstract class MedioBD<DTO> : Medio<DTO>
    {
        public List<DTO> darTodos()
        {
            String consulta = this.prefijoConsulta() + this.nombreTabla();

            return realizarConsulta(consulta);
        }

        public long asignarId()
        {
            throw new NotImplementedException();
        }

        public void aniadir(DTO unaEntidad)
        {
            throw new NotImplementedException();
        }

        public void eliminar(DTO unaEntidad)
        {
            throw new NotImplementedException();
        }

        public void modificar(DTO unaEntidad)
        {
            throw new NotImplementedException();
        }

        protected abstract string nombreTabla();

        protected String prefijoConsulta()
        {
            return "SELECT * FROM SQL_BOYS.";
        }

        protected List<DTO> realizarConsulta(String consulta)
        {
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(consulta);

            FilaDTO fila;

            List<DTO> objetos = new List<DTO>();

            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                objetos.Add(this.generarFila(fila));
            }

            return objetos;

        }

        protected DTO generarFila(FilaDTO fila)
        {
            List<String> elementos = fila.obtener();

            return this.rellenarFila(elementos);
        }

        protected abstract DTO rellenarFila(List<String> elementos);

    }
}

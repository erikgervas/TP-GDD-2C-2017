using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public class TablaDTO
    {

        List<FilaDTO> filas = new List<FilaDTO>();

        public void agregarFila(FilaDTO fila)
        {
            filas.Add(fila);
        }

        public FilaDTO obtener(int posicion)
        {

            try
            {
                return filas.ElementAt(posicion);
            }
            catch (ArgumentOutOfRangeException)
            {
                return null;
            }

        }

        public int cantidadDeFilas()
        {
            return this.filas.Count();
        }

        public List<FilaDTO> getFilas()
        {
            return this.filas;
        }
 

    }
}

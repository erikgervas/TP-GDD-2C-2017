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

            return filas.ElementAt(posicion);

        }

    }
}

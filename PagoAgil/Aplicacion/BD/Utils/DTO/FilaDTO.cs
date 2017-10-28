using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public class FilaDTO
    {

        List<string> elementos = new List<string>();
        
        public void agregarElemento(string nuevoElemento)
        {

            elementos.Add(nuevoElemento);

        }

        public List<string> obtener()
        {

            return elementos;
        
        }
        
    }
}

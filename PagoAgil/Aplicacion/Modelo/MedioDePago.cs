using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.BD;

namespace PagoAgil.Aplicacion.Modelo
{
    class MedioDePago
    {
        public int idMedioDePago { get; set; }
        public string descripcion { get; set; }

        public MedioDePago(int unId, string unNombre) 
        {
            idMedioDePago = unId;
            descripcion = unNombre;
        
        }

        public MedioDePago(FilaDTO fila) 
        {
            List <string> elementos = fila.obtener();

            idMedioDePago = int.Parse(elementos.ElementAt(0));
            descripcion = elementos.ElementAt(1);
        }

        public override string ToString()
        {
            return descripcion;
        }

    }
}

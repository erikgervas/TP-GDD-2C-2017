using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.BD;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    class EmpresaDB
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string domicilio { get; set; }
        public ushort diaRendicion { get; set; }
        public ushort porcentaje_comision { get; set; }
        public bool estado { get; set; }
        public string rubro { get; set; }


        public EmpresaDB(FilaDTO fila) 
        {
            List<string> elementos = fila.obtener();

            id = long.Parse(elementos.ElementAt(0));
            nombre = elementos.ElementAt(1);
            cuit = elementos.ElementAt(2);
            domicilio = elementos.ElementAt(3);
            diaRendicion = ushort.Parse(elementos.ElementAt(4));
            porcentaje_comision = ushort.Parse(elementos.ElementAt(5));
            estado = bool.Parse(elementos.ElementAt(6));
            rubro = elementos.ElementAt(7);
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

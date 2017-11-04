using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Utils
{
    public class ParametroFactory
    {
        public static Parametro crear(string unNombre, SqlDbType unTipo, object unValor)
        {
            return new Parametro(unNombre, unTipo, unValor);
        }

        public static string generarTextoParametros(List<Parametro> parametros)
        {
            String listaParametros = "(";

            int i = 0;

            foreach (Parametro parametro in parametros)
            {
                listaParametros += parametro.nombre + ((i < parametros.Count() - 1) ? ", " : ")");

                i++;
            }

            return listaParametros;
        }
    }
}

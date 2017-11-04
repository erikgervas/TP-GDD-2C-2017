using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    public class MedioRubro : MedioBD<String>
    {
        protected override string nombreTabla()
        {
            return "obtenerRubros()";
        }

        protected override List<Parametro> listaDeParametros(String unaEntidad)
        {
            List<Parametro> parametros = new List<Parametro>(1);

            parametros.Add(ParametroFactory.crear("nombre", SqlDbType.NVarChar, unaEntidad));

            return parametros;
        }

        protected override String rellenarFila(List<String> elementos)
        {
            return elementos.ElementAt(1);
        }
    }
}

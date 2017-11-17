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
    public class MedioItem : MedioBD<Item>
    {
        protected override string nombreTabla()
        {
            return "Item";
        }

        protected override List<Parametro> listaDeParametros(Item unaEntidad)
        {
            List<Parametro> parametros = new List<Parametro>(4);

            parametros.Add(ParametroFactory.crear("nombre", SqlDbType.NVarChar, unaEntidad.nombre));
            parametros.Add(ParametroFactory.crear("monto", SqlDbType.Float, unaEntidad.monto));
            parametros.Add(ParametroFactory.crear("cantidad", SqlDbType.Int, unaEntidad.cantidad));
            parametros.Add(ParametroFactory.crear("numero_factura", SqlDbType.Int, unaEntidad.numero_factura));

            return parametros;
        }

        protected override Item rellenarFila(List<string> elementos)
        {
            throw new NotImplementedException();
        }
    }
}

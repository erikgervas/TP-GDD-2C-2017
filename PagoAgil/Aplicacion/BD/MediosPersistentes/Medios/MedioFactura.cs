using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    public class MedioFactura : MedioBD<Factura>
    {
        protected override string nombreTabla()
        {
            return "Factura";
        }

        protected override List<Parametro> listaDeParametros(Factura unaEntidad)
        {
            List<Parametro> parametros = new List<Parametro>(8);

            parametros.Add(ParametroFactory.crear("numero_factura", SqlDbType.Int, unaEntidad.id));
            parametros.Add(ParametroFactory.crear("factura_monto_total", SqlDbType.Decimal, unaEntidad.monto_total));
            parametros.Add(ParametroFactory.crear("factura_fecha_alta", SqlDbType.DateTime, unaEntidad.fecha_alta));
            parametros.Add(ParametroFactory.crear("factura_fecha_vencimiento", SqlDbType.DateTime, unaEntidad.fecha_alta));
            parametros.Add(ParametroFactory.crear("habilitadx", SqlDbType.Bit, unaEntidad.habilitado));
            parametros.Add(ParametroFactory.crear("dni_cliente", SqlDbType.Int, unaEntidad.dni_cliente));
            parametros.Add(ParametroFactory.crear("cuit_empresa", SqlDbType.NVarChar, unaEntidad.cuit_empresa));

            return parametros;
        }

        protected override Factura rellenarFila(List<string> elementos)
        {
            throw new NotImplementedException();
        }
    }
}


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
    public class MedioEmpresa : MedioBD<Empresa>
    {
        protected override string nombreTabla()
        {
            return "Empresa";
        }

        protected override List<Parametro> listaDeParametros(Empresa unaEntidad)
        {
            List<Parametro> parametros = new List<Parametro>(9);

            parametros.Add(ParametroFactory.crear("id_empresa", SqlDbType.Int, unaEntidad.id));
            parametros.Add(ParametroFactory.crear("nombre", SqlDbType.NVarChar, unaEntidad.nombre));
            parametros.Add(ParametroFactory.crear("cuit", SqlDbType.NVarChar, unaEntidad.cuit));
            parametros.Add(ParametroFactory.crear("domicilio", SqlDbType.NVarChar, unaEntidad.direccion));
            parametros.Add(ParametroFactory.crear("dia_rendicion", SqlDbType.Int, unaEntidad.diaRendicion));
            parametros.Add(ParametroFactory.crear("porcentaje_comision", SqlDbType.Int, unaEntidad.diaRendicion));
            parametros.Add(ParametroFactory.crear("habilitadx", SqlDbType.Bit, unaEntidad.habilitado));
            parametros.Add(ParametroFactory.crear("nombre_rubro", SqlDbType.NVarChar, unaEntidad.rubro));

            return parametros;
        }

        protected override Empresa rellenarFila(List<string> elementos)
        {
            throw new NotImplementedException();
        }
    }
}

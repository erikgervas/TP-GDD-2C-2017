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
            parametros.Add(ParametroFactory.crear("porcentaje_comision", SqlDbType.Int, unaEntidad.porcentajeComision));
            parametros.Add(ParametroFactory.crear("habilitadx", SqlDbType.Bit, unaEntidad.habilitado));
            parametros.Add(ParametroFactory.crear("nombre_rubro", SqlDbType.NVarChar, unaEntidad.rubro));

            return parametros;
        }

        protected override Empresa rellenarFila(List<string> elementos)
        {
            long id = long.Parse(elementos.ElementAt(0));
            string nombre = elementos.ElementAt(1);
            string cuit = elementos.ElementAt(2);
            string domicilio = elementos.ElementAt(3);
            ushort diaRendicion = ushort.Parse(elementos.ElementAt(4));
            ushort porcentaje_comision = ushort.Parse(elementos.ElementAt(5));
            bool estado = bool.Parse(elementos.ElementAt(6));
            string rubro = elementos.ElementAt(7);

            return new Empresa(id, nombre, estado, cuit, domicilio, rubro, diaRendicion, porcentaje_comision);
        }
    }
}

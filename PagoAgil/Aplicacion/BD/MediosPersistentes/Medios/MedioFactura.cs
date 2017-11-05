using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        protected override Factura rellenarFila(List<string> elementos)
        {
            throw new NotImplementedException();
        }
    }
}

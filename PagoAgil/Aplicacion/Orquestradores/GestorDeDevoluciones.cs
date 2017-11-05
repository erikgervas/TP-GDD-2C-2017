using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores
{
    public class GestorDeDevoluciones
    {

        private static GestorDeDevoluciones instance = new GestorDeDevoluciones();

        public static GestorDeDevoluciones getInstance()
        {
            return instance;
        }

        private GestorDeDevoluciones()
        {

        }


        public void devolver(string numeroFacturaRaw, string motivo)
        {

            int numeroFactura = Int32.Parse(numeroFacturaRaw);

            if(motivo.Equals(""))
                throw new ArgumentException("El motivo no tiene motivo");

            DataTable dt = LectorDeTablas.getInstance().obtenerMejorado("facturasDevolvibles()");

            string query = "devolverFacturaPaga " + numeroFactura + ", '" + motivo + "', '" + Configuracion.fechaCruda() + "'";

            EjecutadorDeProcedures.getInstance().ejecutar(query);

        }
    }
}

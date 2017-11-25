using PagoAgil.Aplicacion.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.Excepciones
{
    public class FacturasPendientesDeRendicionException : Exception
    {
        private int facturasPendientesDePago;
        private int facturasPendientesDeRendicion;
        private EmpresaBuilder empresaBuilder;

        public FacturasPendientesDeRendicionException(EmpresaBuilder empresaBuilder, int facturasPendientesDeRendicion, int facturasPendientesDePago)
        {
            this.empresaBuilder = empresaBuilder;
            this.facturasPendientesDeRendicion = facturasPendientesDeRendicion;
            this.facturasPendientesDePago = facturasPendientesDePago;
        }

        public string mensaje()
        {
            return construirMensaje() + "\nPor lo que no puede ser dada de baja aún.";
        }

        private string construirMensaje()
        {
            string cadena = empresaBuilder.nombre;

            if (facturasPendientesDePago > 0 && facturasPendientesDeRendicion == 0) return cadena + mensajePagos();
            else if (facturasPendientesDePago == 0 && facturasPendientesDeRendicion > 0) return cadena + mensajeRendicion();
            else return cadena + mensajePagos() + "\nTambién" + mensajeRendicion();
            
        }

        private string mensajePagos()
        {
            return " tiene " + facturasPendientesDePago.ToString() + " facturas por pagar.";
        }

        private string mensajeRendicion()
        {
            return " tiene " + facturasPendientesDeRendicion.ToString() + " facturas por rendir.";
        }

    }
}

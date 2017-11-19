using PagoAgil.Aplicacion.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PagoAgil.Aplicacion.Modelo.Excepciones
{
    public class FacturasPendientesDeRendicionException : Exception
    {
        private int facturasPendientesDeRendicion;
        private EmpresaBuilder empresaBuilder;

        public FacturasPendientesDeRendicionException(EmpresaBuilder empresaBuilder, int facturasPendientesDeRendicion)
        {
            this.empresaBuilder = empresaBuilder;
            this.facturasPendientesDeRendicion = facturasPendientesDeRendicion;
        }

        public string mensaje()
        {
            return empresaBuilder.nombre + " tiene " + facturasPendientesDeRendicion.ToString() + " facturas para rendir.\nPor lo que no puede ser dada de baja aún.";
        }

    }
}

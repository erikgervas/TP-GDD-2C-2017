using PagoAgil.Aplicacion.Builders.Excepciones;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.View.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Builders
{
    public class EmpresaBuilder
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }
        public string cuit { get; set; }
        public string direccion { get; set; }
        public string rubro { get; set; }
        public ushort diaRendicion { get; set; }

        public EmpresaBuilder() { }

        public Empresa crear()
        {
            this.validar();

            return new Empresa(id, nombre, estado, this.generarCuit(), direccion, rubro, diaRendicion);
        }

        private string generarCuit()
        {
            return cuit.ElementAt(0) + "-" + cuit.Substring(1, cuit.Count() - 1) + "-" + cuit.Reverse().ElementAt(0);
        }

        private List<String> revisarLlenado()
        {
            List<String> errores = new List<String>();

            if (this.nombre == null) errores.Add("Nombre");
            if (this.cuit == null) { errores.Add("Cuit"); } else if (this.cuit.Count() > 0 && this.cuit.Count() < 10) errores.Add("Cuit incompleto");
            if (this.direccion == null) errores.Add("Dirección");
            if (this.rubro == null) errores.Add("Rubro");
            if (this.diaRendicion < 1 && diaRendicion > 31) errores.Add("Día imposible");

            return errores;
        }

        private bool existeOtroIgual()
        {
            return false; // Implementar
        }

        private void validar()
        {
            if (existeOtroIgual()) throw new YaExisteObjetoConEsaClave();

            List<String> errores = revisarLlenado();

            if (errores.Count != 0) throw new NoSePuedeCrearException(errores);
        }
    }
}

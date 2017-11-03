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
            return new Empresa(id, nombre, estado, this.generarCuit(), direccion, rubro, diaRendicion);
        }

        public void validar()
        {
            revisarLlenado();
            existeOtroIgual();
        }

        public string generarCuit()
        {
            return cuit.ElementAt(0) + "-" + cuit.Substring(1, cuit.Count() - 2) + "-" + cuit.Reverse().ElementAt(0);
        }

        private bool estaVacio(String campo)
        {
            return campo == null || campo.Count() == 0;
        }

        private void revisarLlenado()
        {
            List<String> errores = new List<String>();

            if (this.estaVacio(this.nombre)) errores.Add("Nombre");
            if (this.estaVacio(this.cuit)) { errores.Add("Cuit"); } else if (this.cuit.Count() > 0 && this.cuit.Count() < 10) errores.Add("Cuit incompleto");
            if (this.estaVacio(this.direccion)) errores.Add("Dirección");
            if (this.estaVacio(this.rubro)) errores.Add("Rubro");
            if (this.diaRendicion < 1 && diaRendicion > 31) errores.Add("Día imposible");

            if (errores.Count != 0) throw new NoSePuedeCrearException(errores);
        }

        private void existeOtroIgual()
        {
            // if (Existe otra empresa igual) throw new YaExisteObjetoConEsaClave();
        }
    }
}

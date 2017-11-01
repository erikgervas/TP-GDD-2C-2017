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

            return new Empresa(id, nombre, estado, cuit, direccion, rubro, diaRendicion);
        }

        public List<String> revisarCampos()
        {
            List<String> errores = new List<String>();

            if (nombre == null) errores.Add("Nombre");
            if (cuit == null) errores.Add("Cuit");
            if (direccion == null) errores.Add("Dirección");
            if (rubro == null) errores.Add("Rubro");
            if (diaRendicion < 1 && diaRendicion > 31) errores.Add("Día imposible");

            return errores;
        }

        private bool existeOtroIgual()
        {
            return false; // Implementar
        }

        public void validar()
        {
            if (existeOtroIgual()) throw new YaExisteObjetoConEsaClave();

            List<String> errores = revisarCampos();

            if (errores.Count != 0) throw new NoSePuedeCrearException(errores);
        }
    }
}

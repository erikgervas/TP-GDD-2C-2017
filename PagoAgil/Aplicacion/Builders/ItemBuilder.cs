using PagoAgil.Aplicacion.Builders.Excepciones;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Builders
{
    public class ItemBuilder
    {
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public float monto { get; set; }
        public long numero_factura { get; set; }

        public ItemBuilder() { }

        public Item crear()
        {
            return new Item(0, this.nombre, this.monto, this.cantidad, this.numero_factura);
        }

        public void validar()
        {
            revisarLlenado();
            existeOtroIgual();
        }

        private void revisarLlenado()
        {
            List<String> errores = new List<String>();

            if (this.nombre == null  || this.nombre.Count() == 0) errores.Add("Nombre");
            if (this.cantidad == null) errores.Add("Cantidad");
            if (this.monto == null) errores.Add("Monto");

            if (errores.Count != 0) throw new NoSePuedeCrearException(errores);
        }

        private void existeOtroIgual()
        {
            // if (Existe otra empresa igual) throw new YaExisteObjetoConEsaClave();
        }
    }
}

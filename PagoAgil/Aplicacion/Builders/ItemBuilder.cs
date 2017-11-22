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
        public long numero_factura { get; set; }
        public int cantidad { get; set; }
        public float monto { get; set; }

        public ItemBuilder() { }

        public Item crear()
        {
            return new Item(0, this.nombre, this.monto, this.cantidad, this.numero_factura);
        }

        public void validar()
        {
            revisarLlenado();
            existeOtroIgual();
            cantidadesNegativas();
            cantidadesMuyGrandes();
            montoNegativo();
            montoMuyGrande();
            montoTotalMuyGrande();
        }

        private void cantidadesNegativas()
        {
            if (cantidad <= 0) throw new ValorException("Un item tiene cantidad no positiva.");
        }

        private void cantidadesMuyGrandes()
        {
            if (cantidad > int.MaxValue) throw new ValorException("Un item tiene una cantidad demasiado grande.");
        }

        private void montoNegativo()
        {
            if (monto <= 0) throw new ValorException("Un item tiene un monto no positivo.");
        }

        private void montoMuyGrande()
        {
            if (monto > float.MaxValue) throw new ValorException("Un item tiene un monto demasiado grande.");
        }

        private void montoTotalMuyGrande()
        {
            if (cantidad * monto > float.MaxValue) throw new ValorException("El monto total de un item es demasiado grande.");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Item : Identificable
    {
        public float monto { get; set; }
        public int cantidad { get; set; }

        public Item(long unId, string unNombre, float unMonto, int unaCantidad)
            : base(unId, unNombre)
        {
            this.monto = unMonto;
            this.cantidad = unaCantidad;
        }

        public float montoTotal()
        {
            return this.monto * this.cantidad;
        }
    }
}

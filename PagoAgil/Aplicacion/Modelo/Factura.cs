using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Factura : Habilitable
    {
        public float monto_total { get; set; }
        public DateTime fecha_alta { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public long dni_cliente { get; set; }
        public string nombre_empresa { get; set; }
        public List<Item> items { get; set; }

        public Factura(long unId, string unNombre, bool unEstado, float unMonto, DateTime alta, DateTime vencimiento, long unCliente, string unaEmpresa, List<Item> unosItems)
            : base(unId, unNombre, unEstado)
        {
            this.monto_total = unMonto;
            this.fecha_alta = alta;
            this.fecha_vencimiento = vencimiento;
            this.dni_cliente = unCliente;
            this.nombre_empresa = unaEmpresa;
            this.items = unosItems;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;

namespace PagoAgil.Aplicacion.View.Pago
{
    class PagoBuilder
    {
        public long numeroPago { get; set; }
        public double montoTotal { get; set; }
        public DateTime fechaPago{ get; set; }
        public int idMedioPago { get; set; }
        public int dniCliente { get; set; }
        public int cpSucursal { get; set; }

        public PagoDB crearPago()
        {
            return new PagoDB(this.numeroPago, this.montoTotal,this.fechaPago,this.idMedioPago,this.dniCliente,this.cpSucursal);
        }
    }
}

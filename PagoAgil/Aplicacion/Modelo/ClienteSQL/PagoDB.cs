using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class PagoDB
    {
        public long numeroPago { get; set; }
        public decimal montoTotal { get; set; }
        public DateTime fechaPago { get; set; }
        public int idMedioPago { get; set; }
        public int dniCliente { get; set; }
        public int cpSucursal { get; set; }

        public PagoDB(long unNroPago, decimal unMonto, DateTime unaFechaPago, int unIdMedioPago, int unDniCliente, int unCpSucursal)
        {
            this.numeroPago = unNroPago;
            this.montoTotal = unMonto;
            this.fechaPago = unaFechaPago;
            this.idMedioPago = unIdMedioPago;
            this.dniCliente = unDniCliente;
            this.cpSucursal = unCpSucursal;

        }
    }
}

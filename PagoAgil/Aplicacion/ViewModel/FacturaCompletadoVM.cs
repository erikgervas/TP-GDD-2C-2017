using PagoAgil.Aplicacion.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
    public class FacturaCompletadoVM
    {
        public FacturaBuilder factura { get; set; }

        public FacturaCompletadoVM()
        {
            this.factura = new FacturaBuilder();
        }
    }
}

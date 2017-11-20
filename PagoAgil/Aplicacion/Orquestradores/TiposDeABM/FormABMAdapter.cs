using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM
{
    public interface FormABMAdapter
    {
        void alta();

        void baja();

        void modificacion();
    }
}

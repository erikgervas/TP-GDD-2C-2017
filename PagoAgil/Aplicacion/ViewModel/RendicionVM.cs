using PagoAgil.Aplicacion.Orquestradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.ViewModel
{
    public class RendicionVM
    {



        public System.Data.DataTable obtenerEmpresasARendir()
        {

            return GestorDeRendiciones.getInstance().obtenerEmpresasARendir();

        }

        public string rendir(DataGridViewSelectedRowCollection empresasSeleccionadas)
        {

            Dictionary<string, int> filasAfectadasPorEmpresa = GestorDeRendiciones.getInstance().rendir(empresasSeleccionadas);

            if (filasAfectadasPorEmpresa.Count == 0)
                return "No tenia facturas para rendir.";

            string devolucion = "";

            foreach (var item in filasAfectadasPorEmpresa)
            {

                devolucion += "La empresa " + item.Key + " tuvo " + item.Value + " filas afectadas.\r\n";

            }

            return devolucion;

        }
    }
}

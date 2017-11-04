using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.Orquestradores
{
    public class GestorDeRendiciones
    {

        private static GestorDeRendiciones instance = new GestorDeRendiciones();

        private GestorDeRendiciones() { }

        public static GestorDeRendiciones getInstance()
        {
            return instance;
        }


        public DataTable obtenerEmpresasARendir()
        {

            return LectorDeTablas.getInstance().obtenerMejorado("empresasARendir()");
        
        }

        public Dictionary<string, int> rendir(DataGridViewSelectedRowCollection empresasSeleccionadas)
        {

            if (empresasSeleccionadas.Count == 0)
                throw new ArgumentNullException("No se eligió ninguna empresa para rendir");

            Dictionary<string, int> filasAfectadasPorEmpresa = new Dictionary<string, int>();

            foreach (DataGridViewRow empresa in empresasSeleccionadas)
            {

                int idEmpresa = (int) empresa.Cells["id_empresa"].Value;
                string nombreEmpresa = (string) empresa.Cells["nombre"].Value;

                int filasAfectadas = EjecutadorDeProcedures.getInstance().ejecutar("rendirFacturas(" + idEmpresa + ")");

                filasAfectadasPorEmpresa[nombreEmpresa] = idEmpresa;

            }

            return filasAfectadasPorEmpresa;

        }
    }
}

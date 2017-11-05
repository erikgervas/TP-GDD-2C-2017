using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    public class RepositorioFacturas : Repositorio<Factura>
    {
        private static RepositorioFacturas instancia = null;

        private RepositorioFacturas() { }

        public static RepositorioFacturas instanciar()
        {
            if (instancia == null) instancia = new RepositorioFacturas();

            return instancia;
        }
    }
}

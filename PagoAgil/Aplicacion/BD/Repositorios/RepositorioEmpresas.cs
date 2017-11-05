using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    public class RepositorioEmpresas : Repositorio<Empresa>
    {
        private static RepositorioEmpresas instancia = null;

        private RepositorioEmpresas() { }

        public static RepositorioEmpresas instanciar()
        {
            if (instancia == null) instancia = new RepositorioEmpresas();

            return instancia;
        }
    }
}

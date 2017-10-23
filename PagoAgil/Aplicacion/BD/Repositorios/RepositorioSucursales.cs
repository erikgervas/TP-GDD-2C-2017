using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    class RepositorioSucursales : Repositorio<Sucursal>
    {
        private static RepositorioSucursales instancia = null;

        private RepositorioSucursales() { }

        public static RepositorioSucursales instanciar()
        {
            if (instancia == null) instancia = new RepositorioSucursales();

            return instancia;
        }
    }
}

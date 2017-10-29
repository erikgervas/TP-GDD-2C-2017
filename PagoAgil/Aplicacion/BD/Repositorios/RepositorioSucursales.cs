using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    class RepositorioSucursales : Repositorio<Sucursal>
    {
        private static RepositorioSucursales instancia = null;
        private MedioSucursal almacenamiento = new MedioSucursal();

        private RepositorioSucursales() { }

        public static RepositorioSucursales instanciar()
        {
            if (instancia == null) instancia = new RepositorioSucursales();

            return instancia;
        }
    }
}

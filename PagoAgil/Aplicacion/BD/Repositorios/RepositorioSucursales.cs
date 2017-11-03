using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    class RepositorioSucursales : Repositorio<SucursalDB>
    {
        private static RepositorioSucursales instancia = new RepositorioSucursales();
        private MedioSucursal almacenamiento = new MedioSucursal();

        private RepositorioSucursales() { }

        public static RepositorioSucursales getInstancia()
        {
            if (instancia == null)
            {
                instancia = new RepositorioSucursales();
            }

            return instancia;
        }

        public MedioSucursal getAlmacenamiento()
        {
            return almacenamiento;

        }
    }
}

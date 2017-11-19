using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    class RepositorioRoles : Repositorio<Rol>
    {
        private static RepositorioRoles instancia;
        private MedioRol almacenamiento = new MedioRol();

        private RepositorioRoles() { }

        public static RepositorioRoles getInstancia()
        {
            if (instancia == null)
            {
                instancia = new RepositorioRoles();
            }

            return instancia;
        }

        public MedioRol getAlmacenamiento()
        {
            return almacenamiento;

        }

    }
}

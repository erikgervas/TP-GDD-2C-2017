using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;

namespace PagoAgil.Aplicacion.ViewModel
{
    class ListadoRolesVM
    {

        public Rol[] obtenerRoles() 
        {
           return RepositorioRoles.getInstancia().getAlmacenamiento().darTodos().ToArray();
        }

        public List<Funcionalidad> obtenerFuncionalidadesDe(int idRol) 
        {
            return RepositorioRoles.getInstancia().getAlmacenamiento().obtenerFuncionalidadesDeUnRol(idRol);
        }

    }
}

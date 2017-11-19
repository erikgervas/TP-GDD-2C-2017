using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.View.Roles.Excepciones;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.ViewModel
{
    class BajaRolVM
    {
        public void darDeBaja(Rol rolADespachar) 
        {
            if (rolADespachar.habilitado == false) throw new RolYaDeshabilitadoException("El rol ya se encuentra deshabilitado");
            if (rolADespachar.nombre.Equals(Sesion.usuario.rol.nombre)) throw new DeshabilitarRolActualException("No se puede desactivar el rol actual");

            RepositorioRoles.getInstancia().getAlmacenamiento().eliminar(rolADespachar);
        }

    }
}

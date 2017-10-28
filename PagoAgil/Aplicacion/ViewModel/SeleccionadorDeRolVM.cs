using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;
using System;

namespace PagoAgil.Aplicacion.View
{
    public class SeleccionadorDeRolVM
    {

        UsuarioDB usuarioActual;

        public SeleccionadorDeRolVM(UsuarioDB usuario)
        {
            this.usuarioActual = usuario;
        }

        public string getNombreUsuario() {
            return usuarioActual.getNombre();
        }

        public SucursalDB[] obtenerSucursales()
        {

            //return ClienteTSQL.Instance.obtenerSucursales(usuarioActual.getId());

            throw new NotImplementedException();
        }

        public RolDB[] obtenerRoles(SucursalDB sucursal)
        {

            //return ClienteTSQL.Instance.obtenerRoles(usuarioActual.getId(), sucursal.getID());

            throw new NotImplementedException();
        }

        public Usuario armarUsuario(RolDB rol)
        {

            Rol rolDelUsuario = this.armarRol(rol);

            return new Usuario(usuarioActual.getNombre(), rolDelUsuario);
        }

        private Rol armarRol(RolDB rol)
        {
            //return ClienteTSQL.Instance.obtenerRol(rol.getID());

            throw new NotImplementedException();
        }

    }

}

using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.Orquestradores;
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

            return GestorDeSucursales.getInstance().obtenerSucursales(usuarioActual);

        }

        public RolDB[] obtenerRoles(SucursalDB sucursal)
        {

            return GestorDeRoles.getInstance().obtenerRoles(usuarioActual, sucursal);

        }

        public Usuario armarUsuario(RolDB rol)
        {

            Rol rolDelUsuario = this.armarRol(rol);

            return new Usuario(usuarioActual.getNombre(), rolDelUsuario);
        }

        private Rol armarRol(RolDB rol)
        {

            return GestorDeRoles.getInstance().obtenerRol(rol);

        }

    }

}

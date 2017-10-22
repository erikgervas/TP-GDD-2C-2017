using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;

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

            return ClienteTSQL.Instance.obtenerSucursales(usuarioActual.getID());

        }

        public RolDB[] obtenerRoles(SucursalDB sucursal)
        {

            return ClienteTSQL.Instance.obtenerRoles(usuarioActual.getID(), sucursal.getID());
           
        }

        public Usuario armarUsuario(RolDB rol)
        {

            Rol rolDelUsuario = this.armarRol(rol);

            return new Usuario(usuarioActual.getNombre(), rolDelUsuario);
        }

        private Rol armarRol(RolDB rol)
        {
            return ClienteTSQL.Instance.obtenerRol(rol.getID());
        }

    }

}

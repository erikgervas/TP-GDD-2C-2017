using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicación.ViewModel;
using PagoAgil.Aplicación.Modelo.Cliente;

namespace PagoAgil.Aplicación.Modelo.Orquestador
{
    class SeleccionadorDeRolVM
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

            return ClienteSQL.Instance.obtenerSucursales(usuarioActual.getID());

        }

        public RolDB[] obtenerRoles(SucursalDB sucursal)
        {

            return ClienteSQL.Instance.obtenerRoles(usuarioActual.getID(), sucursal.getID());
           
        }

        public Usuario armarUsuario(RolDB rol)
        {

            Rol rolDelUsuario = this.armarRol(rol);

            return new Usuario(usuarioActual.getNombre(), rolDelUsuario);
        }

        private Rol armarRol(RolDB rol)
        {
            return ClienteSQL.Instance.obtenerRol(rol.getID());
        }

    }

}

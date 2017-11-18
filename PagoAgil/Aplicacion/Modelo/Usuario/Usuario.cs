using System;

namespace PagoAgil.Aplicacion.Modelo.Usuario
{
    public class Usuario
    {
        String nombre;
        Rol rol;

        public Usuario(string nombreUsuario, Rol rol)
        {
            this.nombre = nombreUsuario;
            this.rol = rol;
        }

        public Boolean poseesFuncionalidad(string funcionalidad)
        {
            return rol.posees(funcionalidad);
        }

    }
}

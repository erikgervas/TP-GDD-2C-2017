using System;

namespace PagoAgil.Aplicacion.Modelo.Usuario
{
    public class Usuario
    {
        public String nombre {get; set;}
        public Rol rol {get; set;}

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

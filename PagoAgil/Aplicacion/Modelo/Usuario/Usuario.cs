using System;

namespace PagoAgil.Aplicacion.Modelo.Usuario
{
    public class Usuario
    {
        public long id { get; set;}
        public String nombre {get; set;}
        public Rol rol {get; set;}

        public Usuario(long id, string nombreUsuario, Rol rol)
        {
            this.id = id;
            this.nombre = nombreUsuario;
            this.rol = rol;
        }

        public Boolean poseesFuncionalidad(string funcionalidad)
        {
            return rol.posees(funcionalidad);
        }

    }
}

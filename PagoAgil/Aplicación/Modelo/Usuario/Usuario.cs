using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicación.Modelo
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

    }
}

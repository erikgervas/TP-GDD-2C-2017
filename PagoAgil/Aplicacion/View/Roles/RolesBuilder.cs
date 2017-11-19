using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.Usuario;

namespace PagoAgil.Aplicacion.View.Roles
{
    class RolesBuilder
    {
        public string nombre { get; set; }
        public List<Funcionalidad> funcionalidades { get; set; }

        public Rol crearRol() 
        {
            return new Rol(this.nombre, this.funcionalidades);
        }

    }
}

using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public class RepositorioUsuarios : Repositorio<UsuarioDB>
    {

        private static RepositorioUsuarios instance = new RepositorioUsuarios();

        public static RepositorioUsuarios getInstance() {
            return instance;
        }

        public UsuarioDB obtener(string nombre)
        {
            return this.almacenamiento.dar(nombre);
        }

    }
}

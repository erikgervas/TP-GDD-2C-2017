using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores
{
    public class GestorDeRoles
    {

        private static GestorDeRoles instance = new GestorDeRoles();

        public static GestorDeRoles getInstance() {
            return instance;
        }

        private GestorDeRoles() { }

        public RolDB[] obtenerRoles(UsuarioDB usuario, SucursalDB sucursal)
        {

            String query = "select * from SQL_BOYS.obtenerRoles(" + usuario.getId() + ", " + sucursal.getId() + ")";

            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            List<RolDB> roles = new List<RolDB>();

            for (int i = 0; i < tabla.cantidadDeFilas(); i++)
            {

                RolDB rol = new RolDB(tabla.obtener(i));

                if (rol.getHabilitado())
                    roles.Add(rol);

            }

            return roles.ToArray();

        }

        public Rol obtenerRol(RolDB rol)
        {

            String query = "select * from SQL_BOYS.obtenerRol(" + rol.getId() + ")";

            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            return RolDB.generar(rol.getId(), tabla);

        }

    }
}

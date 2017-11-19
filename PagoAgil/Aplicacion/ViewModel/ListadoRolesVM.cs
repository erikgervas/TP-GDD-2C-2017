using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.BD;

namespace PagoAgil.Aplicacion.ViewModel
{
    class ListadoRolesVM
    {

        public Rol[] obtenerRoles() 
        {
            List<Rol> roles = new List<Rol>();

            TablaDTO tabla = LectorDeTablas.getInstance().obtener("SELECT * FROM SQL_BOYS.Rol");
            FilaDTO fila;

            for (int i = 0; i < tabla.cantidadDeFilas(); i++)
            {
                fila = tabla.obtener(i);
                roles.Add(new Rol(fila));
            }

            return roles.ToArray();
        }

    }
}

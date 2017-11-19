using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.BD.Utils;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    class MedioRol : Medio<Rol>
    {
        public List<Rol> darTodos()
        {
            string query = "SELECT * FROM SQL_BOYS.Rol";

            return obtainRolesFromQuery(query);

        }

        private List<Rol> obtainRolesFromQuery(string query)
        {
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            FilaDTO fila;
            List<Rol> roles = new List<Rol>();
            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                roles.Add(new Rol(fila));
            }

            return roles;

        }

        private List<Funcionalidad> obtainFuncionalidadesFromQuery(string query)
        {
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            FilaDTO fila;
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();
            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                funcionalidades.Add(new Funcionalidad(fila));
            }

            return funcionalidades;

        }

        public List<Funcionalidad> obtenerFuncionalidadesDeUnRol(int idRol) 
        {
            string query = "SELECT * FROM SQL_BOYS.obtenerFuncionalidadesDeRol(" + idRol + ")";

            return obtainFuncionalidadesFromQuery(query);
        }

        public long asignarId()
        {
            return 1L;
        }

        public void aniadir(Rol rol)
        {
            Insertador.getInstance().insertarRol(rol);
        }

        public void eliminar(Rol rol)
        {
            Despachador.getInstance().darDeBajaRol(rol);
        }

        public void modificar(Rol rol)
        {
            Actualizador.getInstance().actualizarRol(rol);
        }


        public System.Data.DataTable darFiltrados(string[] filtros)
        {
            throw new NotImplementedException();
        }


        public System.Data.DataTable darTabla()
        {
            throw new NotImplementedException();
        }


        public System.Data.DataTable darTablaFiltrados(List<Parametro> parametros)
        {
            throw new NotImplementedException();
        }

    }
}

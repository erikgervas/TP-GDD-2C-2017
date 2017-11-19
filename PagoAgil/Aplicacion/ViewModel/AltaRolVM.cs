using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.ViewModel
{
    class AltaRolVM
    {
        public void crearRol(Rol nuevoRol) 
        {
            RepositorioRoles.getInstancia().almacenamiento.aniadir(nuevoRol);
        }

        public List<Funcionalidad> obtenerFuncionalidades() 
        {
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            TablaDTO tabla = LectorDeTablas.getInstance().obtener("SELECT * FROM SQL_BOYS.Funcionalidad");
            FilaDTO fila;

            for (int i = 0; i < tabla.cantidadDeFilas(); i++)
            {
                fila = tabla.obtener(i);
                funcionalidades.Add(new Funcionalidad(fila));
            }

            return funcionalidades;
        }


    }
}

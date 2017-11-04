using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes
{
    public class MedioUsuario: Medio<UsuarioDB>
    {

        public UsuarioDB dar(string nombre)
        {

            string query = "SELECT * from SQL_BOYS.obtenerUsuario('" + nombre + "')";            

            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            FilaDTO fila = tabla.obtener(0);

            if (fila == null)
                return null;
                
            return new UsuarioDB(fila);


        }

        public List<UsuarioDB> darTodos()
        {
            return null;
        }

        public long asignarId()
        {
            return 1L;
        }

        public void aniadir(UsuarioDB unaEntidad)
        {

        }

        public void eliminar(UsuarioDB unaEntidad)
        {

        }

        public void modificar(UsuarioDB unaEntidad)
        {

        }

        public DataTable darFiltrados(string[] filtros)
        {
            throw new NotImplementedException();
        }


        public DataTable darTabla()
        {
            throw new NotImplementedException();
        }


        public DataTable darTablaFiltrados(List<Utils.Parametro> parametros)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Utils
{
    public class EjecutadorDeFunciones
    {
        private static EjecutadorDeFunciones instancia = null;

        private EjecutadorDeFunciones() { }

        public static EjecutadorDeFunciones instanciar()
        {
            if(instancia == null) instancia = new EjecutadorDeFunciones();

            return instancia;
        }

        public Object ejecutarFuncion(String funcion, object valor, SqlDbType tipo)
        {

            SqlCommand comando = new SqlCommand("SELECT SQL_BOYS." + funcion + "(@parametro)", Conexion.getInstance().obtenerConexion());

            comando.CommandType = CommandType.Text;

            SqlParameter parametro = new SqlParameter("@parametro", tipo);

            parametro.Value = valor;

            comando.Parameters.Add(parametro);

            return comando.ExecuteScalar();
        }
    }
}

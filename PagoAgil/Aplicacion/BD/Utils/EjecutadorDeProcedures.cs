using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Utils
{
    public class EjecutadorDeProcedures
    {

        private static EjecutadorDeProcedures instance = new EjecutadorDeProcedures();

        private EjecutadorDeProcedures(){}

        public static EjecutadorDeProcedures getInstance() {
            return instance;
        }

        /*
         * Retorna cantidad de filas afectadas
         */
        public int ejecutar(string procedure)
        {

            string query = "EXEC SQL_BOYS." + procedure;

            SqlCommand comando = new SqlCommand(query, Conexion.getInstance().obtenerConexion());

            comando.CommandTimeout = 0;

            return comando.ExecuteNonQuery();

        }

    }
}
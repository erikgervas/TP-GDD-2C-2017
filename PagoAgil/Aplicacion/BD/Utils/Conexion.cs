using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PagoAgil.Aplicacion.BD
{
    public class Conexion
    {

        private static Conexion instance = new Conexion();

        public static Conexion getInstance()
        {
            return instance;
        }

        private Conexion() {
        }

        SqlConnection conexion = null;

        public SqlConnection obtenerConexion()
        {

            if (conexion == null)
                this.conexion = this.generarConexion();

            return conexion;

        }

        private SqlConnection generarConexion()
        {
            string connectionString = this.connectionString();

            SqlConnection conexionGenerada = new SqlConnection(connectionString);

            conexionGenerada.Open();        

            return conexionGenerada;
        }

        private string connectionString()
        {

            string conexion = ConfigurationManager.AppSettings["conexion"];
            return @conexion;

        }
        
    }
}

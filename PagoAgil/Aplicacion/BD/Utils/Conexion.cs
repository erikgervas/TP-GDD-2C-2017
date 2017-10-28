using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine("State: {0}", conexionGenerada.State);
            Console.WriteLine("ConnectionString: {0}",
                conexionGenerada.ConnectionString);          

            return conexionGenerada;
        }

        private string connectionString()
        {

            return @"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD2C2017;Persist Security Info=True;User ID=gd;Password=gd2017";

        }
        
    }
}

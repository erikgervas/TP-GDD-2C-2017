using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Utils
{
    public class ProveedorDeTablas
    {
        private static ProveedorDeTablas instancia = null;

        private ProveedorDeTablas() { }

        public static ProveedorDeTablas instanciar()
        {
            if (instancia == null) instancia = new ProveedorDeTablas();

            return instancia;
        }

        public DataTable obtenerTabla(String funcion, object valor, SqlDbType tipo)
        {

            SqlCommand comando = new SqlCommand("SELECT * FROM SQL_BOYS." + funcion + "(@parametro)", Conexion.getInstance().obtenerConexion());

            comando.CommandType = CommandType.Text;

            SqlParameter parametro = new SqlParameter("@parametro", tipo);

            parametro.Value = valor;

            comando.Parameters.Add(parametro);

            DataTable tabla = new DataTable();

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(tabla);

            return tabla;
        }
    }
}

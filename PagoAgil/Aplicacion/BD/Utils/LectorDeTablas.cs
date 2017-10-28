using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public class LectorDeTablas
    {

        private static LectorDeTablas instance = new LectorDeTablas();

        public static LectorDeTablas getInstance()
        {
            return instance;
        }

        private LectorDeTablas()
        {
        }

        public TablaDTO obtener(String query)
        {

            SqlCommand comando = new SqlCommand(query, Conexion.getInstance().obtenerConexion());

            SqlDataReader reader = comando.ExecuteReader();

            return this.obtenerTabla(reader);

        }

        private TablaDTO obtenerTabla(SqlDataReader reader)
        {

            TablaDTO tablaADevolver = new TablaDTO();

            while (reader.Read())
            {
                
                tablaADevolver.agregarFila(this.obtenerFila(reader));

            }

            reader.Close();

            return tablaADevolver;
        }

        private FilaDTO obtenerFila(SqlDataReader reader)
        {
            FilaDTO filaADevolver = new FilaDTO();

            int columnas = reader.FieldCount;

            for (int i = 0; i < columnas; i++)
            {

                filaADevolver.agregarElemento(reader.GetValue(i).ToString());

            }

            return filaADevolver;
        }

    }
}

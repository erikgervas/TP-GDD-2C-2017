using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace PagoAgil
{
    class ClienteSQL
    {
        SqlConnection conexionSQL = new SqlConnection(@""); // TODO

        private static ClienteSQL instance;

        private ClienteSQL() { }

        public static ClienteSQL Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ClienteSQL();
                }
                return instance;
            }
        }

        public Boolean verificarUsuario(string usuario, string password) {

            String passwordSHA = Encriptador.Instance.encriptar(password);

            String query = "SELECT * FROM Usuario where Nombre = '" + usuario + "' AND Contraseña = '" + passwordSHA + "'"; // Se debería implementar una clase que hace queries

            /*

            // ⇊ NO SE QUE MIERDA ES ESTO ⇊

            SqlDataAdapter adapterSQL = new SqlDataAdapter(query, conexionSQL);

            DataTable tabla = new DataTable();

            adapterSQL.Fill(tabla);

            // ⇈ NO SE QUE MIERDA ES ESTO ⇈

            return tabla.Rows.Count == 1;
            
            */

            return true;

        }

        public void inhabilitarUsuario(string usuario)
        {
            // ⇊

            // Hacer query que haga usuario.estado = false

            // ⇈

            throw new NotImplementedException();
        }
    }
}

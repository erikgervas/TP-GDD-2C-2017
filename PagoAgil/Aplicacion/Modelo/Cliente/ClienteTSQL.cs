using PagoAgil.Apliacion.Modelo.Serializador;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.ViewModel;
using System;
using System.Data.SqlClient;

namespace PagoAgil.Aplicacion.Modelo.ClienteSQL
{
    public class ClienteTSQL
    {
        SqlConnection conexionSQL = new SqlConnection(@""); // TODO

        private static ClienteTSQL instance;

        private ClienteTSQL() { }

        public static ClienteTSQL Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ClienteTSQL();
                }
                return instance;
            }
        }

        public UsuarioDB obtenerUsuario(string usuario, string password) {

            String passwordSHA = EncriptadorSHA.Instance.encriptar(password);

            String query = "SELECT * FROM Usuario where Nombre = '" + usuario + "' AND Contraseña = '" + passwordSHA + "'"; // Se debería implementar una clase que hace queries

            /*

            // ⇊ NO SE QUE MIERDA ES ESTO ⇊

            SqlDataAdapter adapterSQL = new SqlDataAdapter(query, conexionSQL);

            DataTable tabla = new DataTable();

            adapterSQL.Fill(tabla);
             
            return tabla.Rows.Count == 1;

            // ⇈ NO SE QUE MIERDA ES ESTO ⇈
    
            */

            /*
             * Tiene que retornar un UsuarioDB(int pk, string nombre) 
            */

            throw new NotImplementedException();

        }

        public void inhabilitarUsuario(string usuario)
        {
            // ⇊

            // Hacer query que haga usuario.estado = false

            // ⇈

            throw new NotImplementedException();
        }

        public SucursalDB[] obtenerSucursales(int usuario)
        {

            // ⇊

            // Hacer query que obtenga los nombres de las sucursales junto a sus ID las cuales estan relacionadas con el usuario. NO TIENEN QUE ESTAR REPETIDAS

            // ⇈

            throw new NotImplementedException();

        }

        public RolDB[] obtenerRoles(int usuario, int sucursal)
        {

            // ⇊

            // Hacer query que obtenga los nombres de los roles junto a sus ID los cuales tiene un usuario en esa sucursal.

            // ⇈

            throw new NotImplementedException();

        }

        public Rol obtenerRol(int rol)
        {

            // ⇊

            // Hacer query que obtenga el rol completo, junto a sus funcionalidades.

            // ⇈

            throw new NotImplementedException();

        }

    }
}

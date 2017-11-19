using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;

namespace PagoAgil.Aplicacion.BD.Utils
{
    class Actualizador
    {
        private static Actualizador instance;

        public static Actualizador getInstance()
        {
            if (instance == null) instance = new Actualizador();

            return instance;
        }

        public void actualizarSucursal(SucursalDB s) 
        {
            SqlCommand cmd = new SqlCommand("SQL_BOYS.actualizarSucursal", Conexion.getInstance().obtenerConexion());

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CP", DbType.Int32).Value = s.codigoPostal;
            cmd.Parameters.AddWithValue("@nombre", DbType.String).Value = s.nombre;
            cmd.Parameters.AddWithValue("@domicilio", DbType.String).Value = s.domicilio;
            cmd.Parameters.AddWithValue("@estado", DbType.Boolean).Value = s.habilitado;

            cmd.ExecuteNonQuery();

        }
        public void actualizarCliente(ClienteDB c)
        {

            SqlCommand cmd = new SqlCommand("UPDATE INTO SQL_BOYS.Cliente " +
                        " SET nombre=@nombre, apellido=@apellido, nacimiento=@nacimiento,mail=@mail,domicilio=@domicilio,codigo_postal=@cp,telefono=@telefono,habilitadodx=@hab"
                         + "WHERE dni_cliente = @dni;", Conexion.getInstance().obtenerConexion());

          

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@dni", DbType.Int32);
            cmd.Parameters.AddWithValue("@nombre", DbType.String);
            cmd.Parameters.AddWithValue("@apellido", DbType.String);
            cmd.Parameters.AddWithValue("@nacimiento", DbType.DateTime);
            cmd.Parameters.AddWithValue("@mail", DbType.String);
            cmd.Parameters.AddWithValue("@domicilio", DbType.String);
            cmd.Parameters.AddWithValue("@cp", DbType.Int32);
            cmd.Parameters.AddWithValue("@telefono", DbType.Int32);
            cmd.Parameters.AddWithValue("@hab", DbType.Boolean);

            cmd.Parameters[0].Value = c.id;
            cmd.Parameters[1].Value = c.nombre;
            cmd.Parameters[2].Value = c.apellido;
            cmd.Parameters[3].Value = c.nacimiento;
            cmd.Parameters[4].Value = c.mail;
            cmd.Parameters[5].Value = c.domicilio;
            cmd.Parameters[6].Value = c.codigoPostal;
            cmd.Parameters[7].Value = c.telefono;
            cmd.Parameters[8].Value = c.habilitado;

        }

        public void actualizarRol(Rol r)
        {
            SqlCommand cmd = new SqlCommand("SQL_BOYS.actualizarRol", Conexion.getInstance().obtenerConexion());

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idRol", DbType.Int32).Value = r.id;
            cmd.Parameters.AddWithValue("@nombre", DbType.String).Value = r.nombre;
            cmd.Parameters.AddWithValue("@estado", DbType.Boolean).Value = r.habilitado;

            cmd.ExecuteNonQuery();

        }

    }
}

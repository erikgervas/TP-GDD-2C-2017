using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.BD.Utils
{
    class Insertador
    {
        private static Insertador instance;

        public static Insertador getInstance()
        {
            if (instance == null) instance = new Insertador();

            return instance;
        }


        public void insertarSucursal(Sucursal s)
        {
                SqlCommand cmd = new SqlCommand("INSERT INTO SQL_BOYS.Sucursal (cp_sucursal,nombre,domicilio,habilitadx) " +
                        " VALUES (@cp, @nombre, @domicilio, @habilitado)", Conexion.getInstance().obtenerConexion());

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cp", DbType.Int32);
                cmd.Parameters.AddWithValue("@nombre", DbType.String);
                cmd.Parameters.AddWithValue("@domicilio", DbType.String);
                cmd.Parameters.AddWithValue("@habilitado", DbType.Boolean);

                cmd.Parameters[0].Value = s.codigoPostal;
                cmd.Parameters[1].Value = s.nombre;
                cmd.Parameters[2].Value = s.domicilio;
                cmd.Parameters[3].Value = s.estado;

                cmd.ExecuteNonQuery();
        }

    }
}

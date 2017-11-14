using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;

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

    }
}

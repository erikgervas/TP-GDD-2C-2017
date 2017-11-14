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
    class Despachador
    {
        private static Despachador instance;

        public static Despachador getInstance()
        {
            if (instance == null) instance = new Despachador();

            return instance;
        }

        public void darDeBajaSucursal(SucursalDB s) 
        {
            SqlCommand cmd = new SqlCommand("UPDATE SQL_BOYS.Sucursal SET habilitadx = 0 WHERE cp_sucursal = " +
                         s.codigoPostal, Conexion.getInstance().obtenerConexion());

            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
        }

    }
}

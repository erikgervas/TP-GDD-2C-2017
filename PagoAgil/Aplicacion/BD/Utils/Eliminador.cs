using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Utils.DTO
{
    class Eliminador
    {
        private static Eliminador instance;

        public static Eliminador getInstance()
        {
            if (instance == null) instance = new Eliminador();

            return instance;
        }

        public void eliminarCliente(ClienteDB c)
        {
            SqlCommand cmd = new SqlCommand("UPDATE SQL_BOYS.Cliente  SET habilitadx=0 WHERE dni_cliente=@dni", Conexion.getInstance().obtenerConexion());

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@dni", c.id);

            cmd.ExecuteNonQuery();

           
        }


    }

    }


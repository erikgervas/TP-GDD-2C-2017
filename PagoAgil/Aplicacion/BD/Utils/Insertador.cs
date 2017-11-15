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
    class Insertador
    {
        private static Insertador instance;

        public static Insertador getInstance()
        {
            if (instance == null) instance = new Insertador();

            return instance;
        }


        public void insertarSucursal(SucursalDB s)
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
                cmd.Parameters[3].Value = s.habilitado;

                cmd.ExecuteNonQuery();
        }

        public void insertarPago(PagoDB p)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO SQL_BOYS.Pago (monto_total,fecha_pago,id_medio_de_pago,dni_cliente,cp_sucursal) " +
                        " VALUES (@montoTotal, @fechaPago, @idMedioPago, @dniCliente, @cpSucursal)", Conexion.getInstance().obtenerConexion());

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@montoTotal", DbType.Decimal);
            cmd.Parameters.AddWithValue("@fechaPago", DbType.DateTime);
            cmd.Parameters.AddWithValue("@idMedioPago", DbType.Int32);
            cmd.Parameters.AddWithValue("@dniCliente", DbType.Int32);
            cmd.Parameters.AddWithValue("@cpSucursal", DbType.Int32);

            cmd.Parameters[0].Value = p.montoTotal;
            cmd.Parameters[1].Value = p.fechaPago;
            cmd.Parameters[2].Value = p.idMedioPago;
            cmd.Parameters[3].Value = p.dniCliente;
            cmd.Parameters[4].Value = p.cpSucursal;

            cmd.ExecuteNonQuery();

        }

    }
}

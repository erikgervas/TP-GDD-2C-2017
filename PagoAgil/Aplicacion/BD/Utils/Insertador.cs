using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;
using System.Windows.Forms;

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
        public void insertarCliente(ClienteDB c)
        {

            using (SqlCommand cmd = new SqlCommand("INSERT INTO SQL_BOYS.Cliente (dni_cliente, nombre, apellido, nacimiento,mail,domicilio,codigo_postal,telefono,habilitadx) VALUES (@dni, @nombre, @apellido, @nacimiento,@mail,@domicilio,@cp,@telefono,@hab)", Conexion.getInstance().obtenerConexion()))
            { 
                cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@dni", c.id);
            cmd.Parameters.AddWithValue("@nombre", c.nombre);
            cmd.Parameters.AddWithValue("@apellido", c.apellido);
            cmd.Parameters.AddWithValue("@nacimiento", c.nacimiento);
            cmd.Parameters.AddWithValue("@mail", c.mail);
            cmd.Parameters.AddWithValue("@domicilio",c.domicilio);
            cmd.Parameters.AddWithValue("@cp", c.codigoPostal);
            cmd.Parameters.AddWithValue("@telefono", c.telefono);
            cmd.Parameters.AddWithValue("@hab",c.habilitado);
                /*
                cmd.Parameters[0].Value = c.id;
                cmd.Parameters[1].Value = c.nombre;
                cmd.Parameters[2].Value = c.apellido;
                cmd.Parameters[3].Value = c.nacimiento;
                cmd.Parameters[4].Value = c.mail;
                cmd.Parameters[5].Value = c.domicilio;
                cmd.Parameters[6].Value = c.codigoPostal;
                cmd.Parameters[7].Value = c.telefono;
                cmd.Parameters[8].Value = c.habilitado;
                 */
                try {cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente actualizado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                // Check Error

            }
        }

        public void insertarRol(Rol r) 
        {
            int idRol;
            SqlCommand cmd1 = new SqlCommand("SELECT SQL_BOYS.obtenerProximoIdRol()", Conexion.getInstance().obtenerConexion());
            idRol = int.Parse(cmd1.ExecuteScalar().ToString());

            SqlCommand cmd2 = new SqlCommand("INSERT INTO SQL_BOYS.Rol (nombre,habilitadx) " +
                        " VALUES (@nombre, @habilitado)", Conexion.getInstance().obtenerConexion());

            cmd2.CommandType = CommandType.Text;
            cmd2.Parameters.AddWithValue("@nombre", DbType.String);
            cmd2.Parameters.AddWithValue("@habilitado", DbType.Boolean);

            cmd2.Parameters[0].Value = r.nombre;
            cmd2.Parameters[1].Value = true;

            cmd2.ExecuteNonQuery();

            this.insertarFuncionalidadesDeRol(r, idRol);

        }

        public void insertarFuncionalidadesDeRol(Rol r, int idRol) 
        {
            for (int i = 0; i < r.funcionalidades.Count; i++)
            {
                SqlCommand cmd3 = new SqlCommand("INSERT INTO SQL_BOYS.Funcionalidad_Por_Rol (id_funcionalidad,id_rol) " +
                        " VALUES (@id_funcionalidad, @id_rol)", Conexion.getInstance().obtenerConexion());

                cmd3.CommandType = CommandType.Text;
                cmd3.Parameters.AddWithValue("@id_funcionalidad", DbType.Int32);
                cmd3.Parameters.AddWithValue("@id_rol", DbType.Int32);

                cmd3.Parameters[0].Value = r.funcionalidades.ElementAt(i).id;
                cmd3.Parameters[1].Value = idRol;

                cmd3.ExecuteNonQuery();
            }

        }

    }
}

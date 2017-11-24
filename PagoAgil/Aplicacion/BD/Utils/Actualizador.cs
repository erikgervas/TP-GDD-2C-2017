using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Usuario;
using PagoAgil.Aplicacion.BD.Utils;
using System.Windows.Forms;
using System.Collections;
using PagoAgil.Aplicacion.Modelo.Excepciones;

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
        public void actualizarCliente(ClienteDB c,int dniViejo)
        {

            SqlCommand cmd = new SqlCommand("UPDATE SQL_BOYS.Cliente SET dni_cliente=@dni,nombre=@nombre,apellido=@apellido,nacimiento=@nacimiento,mail=@mail,domicilio=@domicilio,codigo_postal=@cp,telefono=@telefono,habilitadx=@hab WHERE dni_cliente=@dniViejo", Conexion.getInstance().obtenerConexion());

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@dniViejo", dniViejo);
            cmd.Parameters.AddWithValue("@dni", c.id);
            cmd.Parameters.AddWithValue("@nombre", c.nombre);
            cmd.Parameters.AddWithValue("@apellido", c.apellido);
            cmd.Parameters.AddWithValue("@nacimiento", c.nacimiento);
            cmd.Parameters.AddWithValue("@mail", c.mail);
            cmd.Parameters.AddWithValue("@domicilio", c.domicilio);
            cmd.Parameters.AddWithValue("@cp", c.codigoPostal);
            cmd.Parameters.AddWithValue("@telefono", c.telefono);
            cmd.Parameters.AddWithValue("@hab", c.habilitado);
            try {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado con exito");
            }
            catch (SqlException ex)
            {

                if (ex.ErrorCode == -2146232060)
                    MessageBox.Show(new DniRepetidoClienteException("El cliente DNI:"+c.id +" ya existe. Por favor ingrese un DNI distinto", ex).Message);
                else
                    MessageBox.Show(ex.Message);
            }

        }

        public void actualizarRol(Rol r)
        {
            SqlCommand cmd = new SqlCommand("SQL_BOYS.actualizarRol", Conexion.getInstance().obtenerConexion());

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idRol", DbType.Int32).Value = r.id;
            cmd.Parameters.AddWithValue("@nombre", DbType.String).Value = r.nombre;
            cmd.Parameters.AddWithValue("@estado", DbType.Boolean).Value = r.habilitado;

            cmd.ExecuteNonQuery();

            try
            {
                Insertador.getInstance().insertarFuncionalidadesDeRol(r, r.id);
            }
            catch(NullReferenceException)
            {
            }
        }

    }
}

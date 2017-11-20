using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.BD.Utils.DTO;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    class MedioCliente : Medio<ClienteDB>
    {
        public void aniadir(ClienteDB unaEntidad)
        {
            Insertador.getInstance().insertarCliente(unaEntidad);
        }

        public long asignarId()
        {
            throw new NotImplementedException();
        }

        public List<ClienteDB> darTodos()
        {
            string query = "SELECT * FROM SQL_BOYS.Cliente";

            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            FilaDTO fila;
            List<ClienteDB> clientes = new List<ClienteDB>();
            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                clientes.Add(new ClienteDB(fila));
            }

            return clientes;
        }

        internal List<ClienteDB> obtenerClientesFiltradosPor( string condicion,string filtro,  string valor)
        {
            string query = "SELECT * FROM SQL_BOYS.Cliente WHERE "+condicion+filtro+"'"+valor+"'";

            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            FilaDTO fila;
            List<ClienteDB> clientes = new List<ClienteDB>();
            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                clientes.Add(new ClienteDB(fila));
            }

            return clientes;
        }

        public void eliminar(ClienteDB unaEntidad)
        {
            Eliminador.getInstance().eliminarCliente(unaEntidad);
        }

        public void modificar(ClienteDB unaEntidad)
        {
            Actualizador.getInstance().actualizarCliente(unaEntidad);
        }

        public List<string> obtenerCamposCliente()
        {
            string query = "SELECT COLUMN_NAME 'All_Columns' FROM GD2C2017.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='Cliente'";
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);
            FilaDTO fila;
            List<string> cond = new List<string>();
            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                cond.Add(fila.obtener().ElementAt(0));
            }
            
            return cond;

        }


        public System.Data.DataTable darFiltrados(string[] filtros)
        {
            throw new NotImplementedException();
        }


        public System.Data.DataTable darTabla()
        {
            return LectorDeTablas.getInstance().obtenerMejorado("Cliente");
        }


        public System.Data.DataTable darTablaFiltrados(List<Utils.Parametro> parametros)
        {
            throw new NotImplementedException();
        }
    }
}

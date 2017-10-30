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
            throw new NotImplementedException();
        }

        public long asignarId()
        {
            throw new NotImplementedException();
        }

        public List<ClienteDB> darTodos()
        {
            string query = "SELECT * FROM dbo.Cliente";

            return obtainSucursalesFromQuery(query);

        }

        private List<ClienteDB> obtainSucursalesFromQuery(string query)
        {
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
            throw new NotImplementedException();
        }

        public void modificar(ClienteDB unaEntidad)
        {
            throw new NotImplementedException();
        }
    }
}

using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores
{
    class GestorDeClientes
    {
        private static GestorDeClientes instance = new GestorDeClientes();

        public static GestorDeClientes getInstance()
        {
            return instance;
        }

        private GestorDeClientes() { }

<<<<<<< HEAD
        
=======
        public List<ClienteDB> obtenerClientes()
        {

            String query = "select * from SQL_BOYS.obtenerClientes()";

            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            List<ClienteDB> clientes = new List<ClienteDB>();

            
            for (int i = 0; i < tabla.cantidadDeFilas(); i++)
            {
>>>>>>> 9548267faa0c9d3b420ea0aa27f49d82dafe949a


        

        
    }
}

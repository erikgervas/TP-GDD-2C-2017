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

        


        

        
    }
}

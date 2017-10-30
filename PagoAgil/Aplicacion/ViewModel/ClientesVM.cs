using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Orquestradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
     class ClientesVM
    {

     
        public List<ClienteDB> obtenerClientes()
        {

            return GestorDeClientes.getInstance().obtenerClientes();

        }



    }
}

using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;
using PagoAgil.Aplicacion.BD.Repositorios;
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
        MedioCliente medioCliente = new MedioCliente();
     
        public List<ClienteDB> obtenerClientes()
        {

            return medioCliente.darTodos();

        }

        public List<string> obtenerCondicionesDeFiltro()
        {


            return medioCliente.obtenerCamposCliente();
        }

        public List<ClienteDB> obtenerClientesFiltradosPor(string condicion,string filtro, string valor)
        {
            //return medioCliente.obtenerClientesFiltradosPor( condicion, filtro, valor);

            return RepositorioClientes.getInstance().getAlmacenamiento().obtenerClientesFiltradosPor(condicion, filtro, valor);
        }

    }
}

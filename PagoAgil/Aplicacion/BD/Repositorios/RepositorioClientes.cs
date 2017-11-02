using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    class RepositorioClientes : Repositorio<ClienteDB>
    {
        private static RepositorioClientes instance = new RepositorioClientes();
        private MedioCliente almacenamiento = new MedioCliente();

        public static RepositorioClientes getInstance()
        {
            return instance;
        }

        public MedioCliente getAlmacenamiento()
        {
            return almacenamiento;
        }
    }
}

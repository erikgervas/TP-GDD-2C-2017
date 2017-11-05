using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.Repositorios;
using System.Data;

namespace PagoAgil.Aplicacion.ViewModel
{
    class ListadoSucursalesVM
    {
        public DataTable filtrarSucursales(string nombre, string direccion, int codigoPostal)
        {
            return RepositorioSucursales.getInstancia().getAlmacenamiento().darTodosLosQueCumplanLosFiltros(nombre,direccion,codigoPostal);

        }
    }
}

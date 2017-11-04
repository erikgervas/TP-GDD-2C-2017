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
        /*public DataTable filtrarSucursales(string nombre, string direccion, int codigoPostal)
        {
            DataTable sucursalesFiltradas;
            /*List<SucursalDB> sucursalesFiltradasNombre = new List<SucursalDB>();
            List<SucursalDB> sucursalesFiltradasDireccion = new List<SucursalDB>();
            List<SucursalDB> sucursalesFiltradasCP = new List<SucursalDB>();

            if (nombre != null) sucursalesFiltradasNombre = RepositorioSucursales.getInstancia().getAlmacenamiento().filtrarPorNombre(nombre);

            if (direccion != null) sucursalesFiltradasDireccion = RepositorioSucursales.getInstancia().getAlmacenamiento().filtrarPorDireccion(direccion);

            if (codigoPostal != 0) sucursalesFiltradasCP = RepositorioSucursales.getInstancia().getAlmacenamiento().filtrarPorCodigoPostal(codigoPostal);

            sucursalesFiltradas = sucursalesFiltradasNombre.Intersect(sucursalesFiltradasDireccion).Intersect(sucursalesFiltradasCP).ToList();

            return sucursalesFiltradas;
        }*/
    }
}

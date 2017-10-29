using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.ViewModel
{
    class ListadoSucursalesVM
    {
        public List<SucursalDB> filtrarSucursales(string nombre, string direccion, int codigoPostal)
        {
            List<SucursalDB> sucursalesFiltradas = new List<SucursalDB>();
            List<SucursalDB> sucursalesFiltradasNombre = new List<SucursalDB>();
            List<SucursalDB> sucursalesFiltradasDireccion = new List<SucursalDB>();
            List<SucursalDB> sucursalesFiltradasCP = new List<SucursalDB>();

            if (nombre != null) sucursalesFiltradasNombre = RepositorioSucursales.getInstancia().getAlmacenamiento().filtrarPorNombre(nombre);

            if (direccion != null) sucursalesFiltradasDireccion = RepositorioSucursales.getInstancia().getAlmacenamiento().filtrarPorDireccion(direccion);

            if (codigoPostal != null) sucursalesFiltradasCP = RepositorioSucursales.getInstancia().getAlmacenamiento().filtrarPorCodigoPostal(codigoPostal);

            sucursalesFiltradas = sucursalesFiltradasNombre.Intersect(sucursalesFiltradasDireccion).Intersect(sucursalesFiltradasCP).ToList();

            return sucursalesFiltradas;
        }
    }
}

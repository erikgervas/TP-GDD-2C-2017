using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.BD.Utils;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    class MedioSucursal : Medio<SucursalDB>
    {

        public List<SucursalDB> darTodos()
        {
            string query = "SELECT * FROM SQL_BOYS.Sucursal";

            return obtainSucursalesFromQuery(query);

        }

        public List<SucursalDB> filtrarPorNombre(string nombre)
        {

            string query = "SELECT * from SQL_BOYS.obtenerSucursalPorNombre('" + nombre + "')";

            return obtainSucursalesFromQuery(query);

        }

        public List<SucursalDB> filtrarPorDireccion(string direccion)
        {

            string query = "SELECT * from SQL_BOYS.obtenerSucursalPorDireccion('" + direccion + "')";

            return obtainSucursalesFromQuery(query);

        }

        public List<SucursalDB> filtrarPorCodigoPostal(int cp)
        {

            string query = "SELECT * from SQL_BOYS.obtenerSucursalPorCodigoPostal('" + cp.ToString() + "')";

            return obtainSucursalesFromQuery(query);

        }

        private List<SucursalDB> obtainSucursalesFromQuery(string query)
        {
            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            FilaDTO fila;
            List<SucursalDB> sucursales = new List<SucursalDB>();
            int cant = tabla.cantidadDeFilas();

            for (int i = 0; i < cant; i++)
            {

                fila = tabla.obtener(i);

                sucursales.Add(new SucursalDB(fila));
            }

            return sucursales;

        }
        

        public long asignarId()
        {
            return 1L;
        }

        public void aniadir(SucursalDB unaSucursal)
        {
            Insertador.getInstance().insertarSucursal(unaSucursal);
        }

        public void eliminar(SucursalDB unaEntidad)
        {

        }

        public void modificar(SucursalDB unaEntidad)
        {

        }
    }
}

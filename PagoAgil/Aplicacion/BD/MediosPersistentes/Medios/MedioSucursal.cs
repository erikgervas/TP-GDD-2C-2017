using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.BD.Utils;
using System.Data;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    class MedioSucursal : Medio<SucursalDB>
    {

        public List<SucursalDB> darTodos()
        {
            string query = "SELECT * FROM SQL_BOYS.Sucursal";

            return obtainSucursalesFromQuery(query);

        }

        public DataTable darTodosEnTabla()
        {
            string query = "Sucursal";

            return LectorDeTablas.getInstance().obtenerMejorado(query);
        }

        public DataTable darTodosLosQueCumplanLosFiltros(string nombre, string direccion, int codigoPostal)
        {

            nombre = (nombre == "") ? "NULL" : "'" + nombre + "'";
            direccion = (direccion == "") ? "NULL" : "'" + direccion + "'";

            string query = "obtenerSucursalPorFiltrado(" + codigoPostal + "," + nombre + "," + direccion + ")";

            return LectorDeTablas.getInstance().obtenerMejorado(query);
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

        public SucursalDB obtenerSucursalPorCP(int cp) 
        {
            string query = "SELECT * FROM SQL_BOYS.obtenerSucursalPorCodigoPostal("+ cp + ")";

            return obtainSucursalesFromQuery(query).ElementAt(0);
        }

        public long asignarId()
        {
            return 1L;
        }

        public void aniadir(SucursalDB unaSucursal)
        {
            Insertador.getInstance().insertarSucursal(unaSucursal);
        }

        public void eliminar(SucursalDB unaSucursal)
        {
            Despachador.getInstance().darDeBajaSucursal(unaSucursal);
        }

        public void modificar(SucursalDB unaSucursal)
        {
            Actualizador.getInstance().actualizarSucursal(unaSucursal);
        }


        public System.Data.DataTable darFiltrados(string[] filtros)
        {
            throw new NotImplementedException();
        }


        public System.Data.DataTable darTabla()
        {
            throw new NotImplementedException();
        }


        public System.Data.DataTable darTablaFiltrados(List<Parametro> parametros)
        {
            throw new NotImplementedException();
        }
    }
}

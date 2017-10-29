using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;

namespace PagoAgil.Aplicacion.BD.MediosPersistentes.Medios
{
    class MedioSucursal : Medio<SucursalDB>
    {

        public List<SucursalDB> darTodos()
        {
            string query = "SELECT * FROM dbo.Sucursal";

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

        public void aniadir(SucursalDB unaEntidad)
        {

        }

        public void eliminar(SucursalDB unaEntidad)
        {

        }

        public void modificar(SucursalDB unaEntidad)
        {

        }
    }
}

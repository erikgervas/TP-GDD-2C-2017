using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores
{
    public class GestorDeSucursales
    {

        private static GestorDeSucursales instance = new GestorDeSucursales();

        public static GestorDeSucursales getInstance() {
            return instance;
        }

        private GestorDeSucursales(){}

        public SucursalDB[] obtenerSucursales(UsuarioDB usuarioActual)
        {

            String query = "select * from SQL_BOYS.obtenerSucursales(" + usuarioActual.getId() + ")";

            TablaDTO tabla = LectorDeTablas.getInstance().obtener(query);

            List<SucursalDB> sucursales = new List<SucursalDB>();

            for (int i = 0; i < tabla.cantidadDeFilas(); i++)
            {

                SucursalDB sucursal = new SucursalDB(tabla.obtener(i));
                
                if(sucursal.getHabilitado())
                    sucursales.Add(sucursal);

            }

            return sucursales;

        }

    }
}

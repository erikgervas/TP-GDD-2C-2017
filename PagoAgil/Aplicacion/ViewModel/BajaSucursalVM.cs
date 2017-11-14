using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.Repositorios;
using System.Data;

namespace PagoAgil.Aplicacion.View

{
    class BajaSucursalVM
    {

        public DataTable traerSucursalElegida(int cp) 
        {
            return RepositorioSucursales.getInstancia().getAlmacenamiento().darTodosLosQueCumplanLosFiltros("", "", cp);
        }

        public void darDeBaja(int cp)
        {

            SucursalDB sucursalADespachar = RepositorioSucursales.getInstancia().getAlmacenamiento().obtenerSucursalPorCP(cp);
            RepositorioSucursales.getInstancia().getAlmacenamiento().eliminar(sucursalADespachar);
  
        }
    }
}

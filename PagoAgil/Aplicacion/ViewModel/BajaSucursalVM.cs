using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.Repositorios;
using System.Data;
using PagoAgil.Aplicacion.View.Sucursales.Excepciones;

namespace PagoAgil.Aplicacion.View

{
    class BajaSucursalVM
    {

        public DataTable traerSucursalElegida(int cp) 
        {
            return RepositorioSucursales.getInstancia().getAlmacenamiento().darTodosLosQueCumplanLosFiltros("", "", cp);
        }

        public void darDeBaja(SucursalDB sucursalADespachar)
        {
            if (sucursalADespachar.habilitado == false) throw new SucursalYaDeshabilitadaException("Sucursal ya deshabilitada");
            if (sucursalADespachar.codigoPostal.Equals(Sesion.sucursal.codigoPostal)) throw new DeshabilitarSucursalActualException("No se puede deshabilitar la sucursal actual");
 
            RepositorioSucursales.getInstancia().getAlmacenamiento().eliminar(sucursalADespachar);
  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.View.Sucursales
{
    class SucursalesBuilder
    {
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public int codigoPostal { get; set; }
        public bool habilitado { get; set; }

        public SucursalDB crearSucursal()
        {
            return new SucursalDB(this.codigoPostal, this.nombre, this.domicilio, true);
        }

        public SucursalDB crearSucursalModificada() 
        {
            return new SucursalDB(this.codigoPostal, this.nombre, this.domicilio, this.habilitado);
        }
    }
}

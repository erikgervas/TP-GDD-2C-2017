using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.BD.Repositorios;

namespace PagoAgil.Aplicacion.View.Sucursales
{
    class SucursalesBuilder
    {
        public string nombre { get; set; }
        public string domicilio { get; set; }
        public int codigoPostal { get; set; }

        public Sucursal crearSucursal()
        {
            return new Sucursal(RepositorioSucursales.getInstancia().proximoId, this.nombre, true, this.domicilio, this.codigoPostal);
        }
    }
}

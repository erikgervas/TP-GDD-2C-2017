using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.View.Sucursales.Excepciones;

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
            this.validarCampos(this.codigoPostal, this.nombre, this.domicilio);
            return new SucursalDB(this.codigoPostal, this.nombre, this.domicilio, true);
        }

        public SucursalDB crearSucursalModificada() 
        {
            this.validarCampos(this.codigoPostal, this.nombre, this.domicilio);
            return new SucursalDB(this.codigoPostal, this.nombre, this.domicilio, this.habilitado);
        }

        private void validarCampos(int cp, string nombre, string domicilio) 
        {
            if (cp == 0 || nombre.Trim().Length == 0 || domicilio.Trim().Length == 0) throw new camposVaciosException();
        }
    }
}

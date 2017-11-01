using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
    public class EmpresasAltaVM
    {
        public EmpresaBuilder empresa { get; set; }

        public EmpresasAltaVM()
        {
            this.empresa = new EmpresaBuilder();
        }

        public void cambiarNombre(string p)
        {
            this.empresa.nombre = p;
        }

        public void cambiarCuit(string p)
        {
            this.empresa.cuit = p;
        }

        public void cambiarDireccion(string p)
        {
            this.empresa.direccion = p;
        }

        public void cambiarRubro(string p)
        {
            this.empresa.rubro = p;
        }

        public void cambiarDiaRendicion(ushort p)
        {
            this.empresa.diaRendicion = p;
        }

        public void cambiarEstado(bool p)
        {
            this.empresa.estado = p;
        }

        public void limpiar()
        {
            this.empresa = new EmpresaBuilder();
        }

        public Empresa darDeAlta()
        {
            return this.empresa.crear();
        }
    }
}

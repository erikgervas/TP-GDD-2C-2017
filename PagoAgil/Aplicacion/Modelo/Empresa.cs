using PagoAgil.Aplicacion.Modelo;
using System;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Empresa : Habilitable
    {
        public string cuit { get; set; }
        public string direccion { get; set; }
        public string rubro { get; set; }
        public ushort diaRendicion { get; set; }
        public ushort porcentajeComision { get; set; }

        public Empresa (long unId, string unNombre, bool unEstado, string unCuit, string unaDireccion, string unRubro, ushort unDia, ushort unPorcentajeComision) : base (unId, unNombre, unEstado)
        {
            this.cuit = unCuit;
            this.direccion = unaDireccion;
            this.rubro = unRubro;
            this.diaRendicion = unDia;
            this.porcentajeComision = unPorcentajeComision;
        }

        private bool facturasRendidas()
        {
            throw new NotImplementedException();
        }

        private void rendir()
        {
            throw new NotImplementedException();
        }
    }
}

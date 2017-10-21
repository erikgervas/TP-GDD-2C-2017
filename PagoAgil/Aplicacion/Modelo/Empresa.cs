using PagoAgil.Aplicacion.Modelo;
using System;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Empresa : Habilitable
    {
        private long p1;
        private string p2;
        private bool p3;
        private string p4;
        private string p5;
        private string p6;
        private int p7;

        public string cuit { get; set; }
        public string direccion { get; set; }
        public string rubro { get; set; }
        public ushort diaRendicion { get; set; }

        public Empresa (long unId, string unNombre, bool unEstado, string unCuit, string unaDireccion, string unRubro, ushort unDia) : base (unId, unNombre, unEstado)
        {
            this.cuit = unCuit;
            this.direccion = unaDireccion;
            this.rubro = unRubro;
            this.diaRendicion = unDia;
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

using PagoAgil.Aplicacion.Modelo;
using System;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Empresa : Identificable
    {

        private string cuit;
        private string direccion;
        private Rubro rubro;
        private ushort diaRendicion;

        Empresa (long unId, string unNombre, bool unEstado, string unCuit, string unaDireccion, Rubro unRubro, ushort unDia) : base (unId, unNombre, unEstado) {
            this.Cuit = unCuit;
            this.Direccion = unaDireccion;
            this.RubroDeEmpresa = unRubro;
            this.DiaRendicion = unDia;
        }

        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Rubro RubroDeEmpresa
        {
            get { return rubro; }
            set { rubro = value; }
        }

        public ushort DiaRendicion
        {
            get { return diaRendicion; }
            set { diaRendicion = value; }
        }

        override public void deshabilitar()
        {
            this.Estado = this.facturasRendidas();
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

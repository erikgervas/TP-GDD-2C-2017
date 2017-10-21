using PagoAgil.Aplicacion.Modelo;
using System;

namespace PagoAgil.Aplicacion.Modelo
{
    public class Empresa : Habilitable
    {
        private string cuit { get; set; }
        private string direccion { get; set; }
        private string rubro { get; set; }
        private ushort diaRendicion { get; set; }

        Empresa (long unId, string unNombre, bool unEstado, string unCuit, string unaDireccion, string unRubro, ushort unDia) : base (unId, unNombre, unEstado)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;
using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    class RepositorioFacturas : Repositorio<Factura>
    {
        private static RepositorioFacturas instancia = new RepositorioFacturas();
        private MedioFactura almacenamiento = new MedioFactura();

        private RepositorioFacturas() { }

        public static RepositorioFacturas getInstancia()
        {
            if (instancia == null)
            {
                instancia = new RepositorioFacturas();
            }

            return instancia;
        }

        public MedioFactura getAlmacenamiento()
        {
            return almacenamiento;

        }
    }
}

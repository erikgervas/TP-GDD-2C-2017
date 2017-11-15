using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;
using PagoAgil.Aplicacion.BD.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores
{
    public class Bootstrap
    {
        public static void iniciarComponentes()
        {
            iniciarRepositorios();
        }

        public static void iniciarRepositorios()
        {
            RepositorioRubros.instanciar().almacenamiento = new MedioRubro();
            RepositorioEmpresas.instanciar().almacenamiento = new MedioEmpresa();
            RepositorioFacturas.instanciar().almacenamiento = new MedioFactura();
        }
    }
}

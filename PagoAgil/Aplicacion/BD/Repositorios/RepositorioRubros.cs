using PagoAgil.Aplicacion.BD.MediosPersistentes.Medios;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    public class RepositorioRubros : Repositorio<String>
    {
        private static RepositorioRubros instancia = null;

        private RepositorioRubros() { }

        public static RepositorioRubros instanciar()
        {
            if (instancia == null) instancia = new RepositorioRubros();

            return instancia;
        }

        public MedioRubro extenderAlmacenamiento()
        {
            return new MedioRubro();
        }
    }
}

using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
    public class EmpresasCompletadoVM
    {
        public EmpresaBuilder empresa { get; set; }
        public List<String> rubros { get; set; }

        public EmpresasCompletadoVM()
        {
            this.empresa = new EmpresaBuilder();
            this.rubros = RepositorioRubros.instanciar().listarElementos();
        }

    }
}

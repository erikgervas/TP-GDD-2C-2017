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
    public class FacturaCompletadoVM
    {
        public FacturaBuilder factura { get; set; }
        public List<Empresa> empresas { get; set; }

        public FacturaCompletadoVM()
        {
            this.empresas = RepositorioEmpresas.instanciar().listarElementos();
            this.factura = new FacturaBuilder();
        }

    }
}

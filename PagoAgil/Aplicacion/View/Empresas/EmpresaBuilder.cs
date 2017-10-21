using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.View.Empresas
{
    public class EmpresaBuilder
    {
        public string nombre { get; set; }
        public string cuit { get; set; }
        public string direccion { get; set; }
        public string rubro { get; set; }
        public ushort diaRendicion { get; set; }

        public Empresa crearEmpresa()
        {
            return new Empresa(RepositorioEmpresas.instanciar().proximoId, this.nombre, true, this.cuit, this.direccion, this.rubro, this.diaRendicion);
        }
    }
}

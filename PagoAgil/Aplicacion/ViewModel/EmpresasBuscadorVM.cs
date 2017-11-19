using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD.Utils;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.ViewModel
{
    public class EmpresasBuscadorVM
    {
        public List<String> rubros { get { return RepositorioRubros.instanciar().listarElementos(); } }
        public EmpresaBuilder empresa { get; set; }

        public EmpresasBuscadorVM() { }

        public DataTable buscar(string nombre, string cuit, string rubro, long id)
        {
            List<Parametro> parametros = new List<Parametro>(4);

            parametros.Add(ParametroFactory.crear("nombre", SqlDbType.NVarChar, nombre));
            parametros.Add(ParametroFactory.crear("cuit", SqlDbType.NVarChar, cuit));
            parametros.Add(ParametroFactory.crear("nombre_rubro", SqlDbType.NVarChar, rubro));
            parametros.Add(ParametroFactory.crear("id_empresa", SqlDbType.Int, id));

            return RepositorioEmpresas.instanciar().obtenerTablaFiltrados(parametros);
        }
    }
}

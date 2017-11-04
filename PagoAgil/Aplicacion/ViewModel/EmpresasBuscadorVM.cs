using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.BD.Utils;
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

        public EmpresasBuscadorVM() { }

        public DataTable buscar(string nombre, string cuit, string rubro)
        {
            List<Parametro> parametros = new List<Parametro>(3);

            parametros.Add(ParametroFactory.crear("nombre", SqlDbType.NVarChar, nombre));
            parametros.Add(ParametroFactory.crear("cuit", SqlDbType.NVarChar, cuit));
            parametros.Add(ParametroFactory.crear("nombre_rubro", SqlDbType.NVarChar, rubro));

            return RepositorioEmpresas.instanciar().obtenerTablaFiltrados(parametros);
        }
    }
}

using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.BD.Repositorios;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.View.Empresas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM
{
    public class Alta<E> : TipoDeABM<E>
    {
        public string[] completado(string abm)
        {
            return new string[] { "Alta de " + abm, "Alta de " + abm + " nueva", "Datos de la nueva " + abm, "Confirmar" };
        }

        public string[] confirmado(string abm)
        {
            return new string[] { "Alta de " + abm, "Confirmación de alta", "Datos de la nueva " + abm, "Dar de alta" };
        }

        public string[] ok(string abm)
        {
            return new string[] { "Alta de " + abm, "¡¡La " + abm + " se ha dado de alta con éxito!!" };
        }

        public void botones(EmpresasConfirmacion empresasConfirmacion) { }

        public void botones(EmpresasCompletado empresasCompletado) { }

        public void realizate(Repositorio<E> repositorio, E entidad)
        {
            repositorio.alta(entidad);
        }
    }
}

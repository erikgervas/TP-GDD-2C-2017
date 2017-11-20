using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion.View.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM
{
    public class Baja<E> : TipoDeABM<E>
    {
        public string[] completado(string abm)
        {
            return new string[] { "Baja de " + abm, "Baja de " + abm, "Datos de la " + abm, "Confirmar" };
        }

        public string[] confirmado(string abm)
        {
            return new string[] { "Baja de " + abm, "Confirmación de baja", "Datos de la " + abm, "Dar de baja" };
        }

        public string[] ok(string abm)
        {
            return new string[] { "Baja de " + abm, "La " + abm + " se ha dado de baja con éxito." };
        }

        public void mostrar(FormABMAdapter form)
        {
            form.baja();
        }

        public void realizate(Repositorio<E> repositorio, E entidad)
        {
            repositorio.baja(entidad);
        }
    }
}

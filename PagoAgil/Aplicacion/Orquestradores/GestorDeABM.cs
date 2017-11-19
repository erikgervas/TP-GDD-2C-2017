using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Builders;
using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Orquestradores.TiposDeABM;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion.View.Facturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.Orquestradores
{
    public abstract class GestorABM<E>
    {
        public TipoDeABM<E> abm { get; set; }
        public bool estado { get; set; }

        protected abstract string nombreAbm();

        public string[] titulosCompletado()
        {
            return this.abm.completado(this.nombreAbm());
        }

        public string[] titulosConfirmado()
        {
            return this.abm.confirmado(this.nombreAbm());
        }

        public string[] titulosOk()
        {
            return this.abm.ok(this.nombreAbm());
        }

        public void mostrar(FormABMAdapter form)
        {
            this.abm.mostrar(form);
        }

        public void realizarABM(Repositorio<E> repositorio, E entidad)
        {
            this.abm.realizate(repositorio, entidad);
        }
    }
}

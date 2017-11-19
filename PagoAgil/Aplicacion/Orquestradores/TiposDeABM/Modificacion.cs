using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.View.Empresas;
using PagoAgil.Aplicacion.View.Facturas;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM
{
    public class Modificacion<E> : TipoDeABM<E>
    {
        public string[] completado(string abm)
        {
            return new string[] { "Modificación de " + abm, "Modificación de " + abm, "Datos de la " + abm, "Confirmar" };
        }

        public string[] confirmado(string abm)
        {
            return new string[] { "Modificación de " + abm, "Confirmación de Modificación", "Datos de la " + abm, "Modificar" };
        }

        public string[] ok(string abm)
        {
            return new string[] { "Modificación de " + abm, "La " + abm + " se ha modificado con éxito." };
        }

        public void botones(EmpresasConfirmacion empresasConfirmacion)
        {

        }

        public void botones(EmpresasCompletado empresasCompletado)
        {
            if(empresasCompletado.viewModel.empresa.estado) empresasCompletado.habilitadaCheckBox.Enabled = false;
            empresasCompletado.cuitText.Enabled = false;
        }

        public void botones(FacturaConfirmado facturaConfirmado)
        {
            
        }

        public void realizate(Repositorio<E> repositorio, E entidad)
        {
            repositorio.almacenamiento.modificar(entidad);
        }
    }
}

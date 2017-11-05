using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.View.Empresas;

namespace PagoAgil.Aplicacion.Orquestradores.TiposDeABM
{
    public class Modificacion<E> : TipoDeABM<E>
    {
        public string[] completado(string abm)
        {
            return new string[] { "Modificación de " + abm, "Modifiación de " + abm, "Datos de la " + abm, "Confirmar" };
        }

        public string[] confirmado(string abm)
        {
            return new string[] { "Modificación de " + abm, "Confirmación de Modificación", "Datos de la " + abm, "Modificar" };
        }

        public string[] ok(string abm)
        {
            return new string[] { "Modificación de " + abm, "La empresa se ha modificado con éxito." };
        }

        public void botones(EmpresasConfirmacion empresasConfirmacion)
        {

        }

        public void botones(EmpresasCompletado empresasCompletado)
        {
            empresasCompletado.habilitadaCheckBox.Visible = false;
        }

        public void realizate(Repositorio<E> repositorio, E entidad)
        {
            repositorio.almacenamiento.modificar(entidad);
        }
    }
}

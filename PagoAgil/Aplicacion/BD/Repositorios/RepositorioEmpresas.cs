using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    public class RepositorioEmpresas : Repositorio<Empresa>
    {
        private static RepositorioEmpresas instancia = null;

        private RepositorioEmpresas() { }

        public static RepositorioEmpresas instanciar()
        {
            if (instancia == null) instancia = new RepositorioEmpresas();

            return instancia;
        }
    }
}

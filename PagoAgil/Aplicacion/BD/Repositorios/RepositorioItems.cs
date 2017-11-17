using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    public class RepositorioItems : Repositorio<Item>
    {
        private static RepositorioItems instancia = null;

        private RepositorioItems() { }

        public static RepositorioItems instanciar()
        {
            if (instancia == null) instancia = new RepositorioItems();

            return instancia;
        }
    }
}
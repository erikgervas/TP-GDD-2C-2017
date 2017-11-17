using PagoAgil.Aplicacion.Modelo;

namespace PagoAgil.Aplicacion.BD.Repositorios
{
    public class RepositorioFacturas : Repositorio<Factura>
    {
        private static RepositorioFacturas instancia = null;

        private RepositorioFacturas() { }

        public static RepositorioFacturas instanciar()
        {
            if (instancia == null) instancia = new RepositorioFacturas();

            return instancia;
        }
    }
}

namespace PagoAgil.Aplicacion.Modelo
{
    public abstract class Identificable : Entidad
    {
        public string nombre { get; set; }

        public Identificable (long unId, string unNombre) : base(unId)
        {
            this.nombre = unNombre;
        }
    }
}

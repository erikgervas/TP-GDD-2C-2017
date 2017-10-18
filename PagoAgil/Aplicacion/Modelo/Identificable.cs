namespace PagoAgil.Aplicacion.Modelo
{
    public abstract class Identificable
    {
        private long id;
        private string nombre;
        private bool habilitada;

        public Identificable (long unId, string unNombre, bool unEstado)
        {
            id = unId;
            this.Nombre = unNombre;
            this.Estado = unEstado;
        }

        public long Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public bool Estado
        {
            get { return habilitada; }
            set { habilitada = value; }
        }

        public virtual void habilitar()
        {
            this.Estado = true;
        }

        public virtual void deshabilitar()
        {
            this.Estado = false;
        }
    }
}

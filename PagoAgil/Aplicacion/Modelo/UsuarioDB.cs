namespace PagoAgil.Aplicacion.Modelo
{
    public class UsuarioDB
    {

        int ID;
        string nombre;

        public UsuarioDB(int id, string nombre)
        {
            this.ID = id;
            this.nombre = nombre;
        }

        public int getID()
        {
            return this.ID;
        }

        public string getNombre()
        {
            return this.nombre;
        }

    }

}

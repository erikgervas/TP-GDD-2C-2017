namespace PagoAgil.Aplicacion.Modelo.Cliente
{
    public class RolDB
    {

        int ID;
        string descripcion;

        public int getID()
        {
            return this.ID;
        }

        public override string ToString()
        {
            return this.descripcion;
        }

    }
}

using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Excepciones;
using PagoAgil.Aplicacion.View.Validador;

namespace PagoAgil
{
    class LoginVM
    {

        public UsuarioDB obtener(string nombre, string pass)
        {
 
            return GestorDeUsuarios.getInstance().obtenerUsuario(nombre, pass);
        
        }

        public void inhabilitar(string nombre)
        {

            GestorDeUsuarios.getInstance().inhabilitar(nombre);

        }

    }
}

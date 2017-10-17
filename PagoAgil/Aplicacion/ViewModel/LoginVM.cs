using PagoAgil.Aplicacion.Modelo;
using PagoAgil.Aplicacion.Modelo.Cliente;
using PagoAgil.Aplicacion.Modelo.Excepciones;
using PagoAgil.Aplicacion.ViewModel.Validador;

namespace PagoAgil
{
    class LoginVM
    {

        int CantidadDeIntentos = 0;

        public UsuarioDB obtener(string usuario, string pass)
        {
        
            if (ValidadorDeInputs.Instance.esValido(usuario) && ValidadorDeInputs.Instance.esValido(pass))
            {
                return this.obtenerUsuario(usuario, pass);
            }

            CantidadDeIntentos++;

            if (CantidadDeIntentos >= 3)
            {
                CantidadDeIntentos = 0;
                throw new DemasiadosIntentosException("Intentaste logear más de 3 veces");                
            }

            return null;
        
        }

        public void inhabilitar(string usuario)
        {
            if (ValidadorDeInputs.Instance.esValido(usuario)) {
                ClienteSQL.Instance.inhabilitarUsuario(usuario);
            }

        }

        private UsuarioDB obtenerUsuario(string nombreUsuario, string pass)
        {
            
            return ClienteSQL.Instance.obtenerUsuario(nombreUsuario, pass);
            
        }

    }
}

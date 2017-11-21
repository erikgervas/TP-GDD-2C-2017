using PagoAgil.Apliacion.Modelo.Serializador;
using PagoAgil.Aplicacion.BD;
using PagoAgil.Aplicacion.Modelo.ClienteSQL;
using PagoAgil.Aplicacion.Modelo.Excepciones;
using PagoAgil.Aplicacion.View.Validador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgil.Aplicacion.ViewModel.Validador
{
    class GestorDeUsuarios
    {

        private static GestorDeUsuarios instance = new GestorDeUsuarios();

        public static GestorDeUsuarios getInstance()
        {
            return instance;
        }

        int cantidadDeIntentos = 0;

        public UsuarioDB obtenerUsuario(string nombreUsuario, string password)
        {

            if (ValidadorDeInputs.Instance.esValido(nombreUsuario) && ValidadorDeInputs.Instance.esValido(password))
            {

                UsuarioDB usuario = RepositorioUsuarios.getInstance().obtener(nombreUsuario);

                if (this.esUsuarioValido(usuario, password))
                {
                    cantidadDeIntentos = 0;
                    return usuario;
                }

            }

            this.loginErroneo();

            return null;

        }

        public void inhabilitar(string nombre)
        {

            if (ValidadorDeInputs.Instance.esValido(nombre))
            {
                try
                {
                    RepositorioUsuarios.getInstance().baja(RepositorioUsuarios.getInstance().obtener(nombre));
                    MessageBox.Show("Usuario inhabilitado");
                }
                catch(NullReferenceException)
                {
                    MessageBox.Show("Usuario inexistente");
                }
            }

        }

        private Boolean esUsuarioValido(UsuarioDB usuario, string password)
        {

            return usuario != null && usuario.getContrasenia().Equals(EncriptadorSHA.Instance.encriptar(password)) && usuario.getHabilitado();

            

        }

        private void loginErroneo()
        {
            cantidadDeIntentos++;

            if (cantidadDeIntentos >= 3)
            {
                cantidadDeIntentos = 0;
                throw new UsuarioInhabilitadoException("Intentaste logear más de 3 veces");
            }

        }

    }
}

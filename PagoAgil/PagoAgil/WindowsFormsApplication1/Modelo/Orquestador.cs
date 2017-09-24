using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Orquestador
    {

        int CantidadDeIntentos = 0;

        public Boolean esUsuarioValido(string usuario, string pass)
        {
        
            if (ValidadorDeInputs.Instance.esValido(usuario) && ValidadorDeInputs.Instance.esValido(pass))
            {
                return ClienteSQL.Instance.verificarUsuario(usuario, pass);
            }

            CantidadDeIntentos++;

            if (CantidadDeIntentos >= 3)
            {
                throw new LogingDemasiadosIntentosException("Intentaste logear más de 3 veces");
                CantidadDeIntentos = 0;
            }

            return false;
        
        }

        public void inhabilitar(string usuario)
        {
            if (ValidadorDeInputs.Instance.esValido(usuario)) {
                ClienteSQL.Instance.inhabilitarUsuario(usuario);
            }

        }
    }
}

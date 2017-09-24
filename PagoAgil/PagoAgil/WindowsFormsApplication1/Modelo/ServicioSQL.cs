using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ServicioSQL
    {

        private static ServicioSQL instance;

        private ServicioSQL() { }

        public static ServicioSQL Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ServicioSQL();
                }
                return instance;
            }
        }

        public Boolean esUsuarioValido(string usuario, string pass)
        {
        
            if (ValidadorDeInputs.Instance.esValido(usuario) && ValidadorDeInputs.Instance.esValido(pass))
            {
                return ClienteSQL.Instance.verificarUsuario(usuario, pass);
            }

            return false;
        
        }

        

    }
}

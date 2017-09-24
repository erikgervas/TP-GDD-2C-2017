using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ValidadorDeInputs
    {

        private static ValidadorDeInputs instance;

        private ValidadorDeInputs() {}

        public static ValidadorDeInputs Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ValidadorDeInputs();
                }
                return instance;
            }
        }

        public Boolean esValido(string texto)
        {
            return !texto.Contains("'") && texto != "";
        }

    }
}

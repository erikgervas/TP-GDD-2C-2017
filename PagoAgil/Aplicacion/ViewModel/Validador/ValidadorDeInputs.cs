using System;

namespace PagoAgil.Aplicacion.ViewModel.Validador
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

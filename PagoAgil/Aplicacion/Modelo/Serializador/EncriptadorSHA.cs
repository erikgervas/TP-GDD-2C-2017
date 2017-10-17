using System;
using System.Security.Cryptography;
using System.Text;

namespace PagoAgil.Apliacion.Modelo.Serializador
{
    public class EncriptadorSHA
    {

        private static EncriptadorSHA instance;

        private EncriptadorSHA() { }

        public static EncriptadorSHA Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new EncriptadorSHA();
                }
                return instance;
            }
        }

        public string encriptar(string textoAEncriptar)
        {

            byte[] bytes = Encoding.UTF8.GetBytes(textoAEncriptar);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }

            return hashString;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApplication1
{
    class Encriptador
    {

        private static Encriptador instance;

        private Encriptador() { }

        public static Encriptador Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Encriptador();
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

using System;
using System.Security.Cryptography;
using System.Text;

namespace Duisv.Herramientas
{
    internal class Codificador
    {
        public static string ObtenerClaveCodificada(string clave)
        {
            var sHA1 = new SHA1CryptoServiceProvider();

            byte[] entrada = (new UnicodeEncoding()).GetBytes(clave);
            byte[] hash = sHA1.ComputeHash(entrada);

            return Convert.ToBase64String(hash);
        }
    }
}

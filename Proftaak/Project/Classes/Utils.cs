using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace EvenementBeheerSysteem.Classes
{
    static class Utils
    {

        private static readonly RNGCryptoServiceProvider rngProvider;

        private const string ALPHA_NUM = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXXYZ0123456789";
        static Utils()
        {
            rngProvider = new RNGCryptoServiceProvider();
        }


        public static string GeneratePassword(int lenght = 7)
        {
            byte[] randomBytes = new byte[lenght];
            rngProvider.GetBytes(randomBytes, 0, randomBytes.Length);
            return randomBytes.Aggregate(string.Empty, (current, b) => current + ALPHA_NUM[b% (ALPHA_NUM.Length - 1)]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Cryptology
    {

        public static string Encryption(String text, int key)
        {
            char[] x = text.ToCharArray();       
            string encryptedText = null;

            foreach (char item in x) 
            {
                encryptedText += Convert.ToChar(item + key);

            }
            return encryptedText;

        }

        public static string Decryption(String text, int key)
        {
            char[] x = text.ToCharArray();
            string decryptedText = null;
            
            foreach (char item in x)
            {
                decryptedText += Convert.ToChar(item - key);
            }

            return decryptedText;
        }



    }
}

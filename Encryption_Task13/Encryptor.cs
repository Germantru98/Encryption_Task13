using System.Collections.Generic;

namespace Encryption_Task13
{
    internal class Encryptor
    {
        public string Generate_Pseudorandom_KeyWord(int length, int startSeed, List<char> alphabet)
        {
            string result = "";
            int x = startSeed;
            int increment = 3;

            for (int i = 0; i < length; i++)
            {
                x = (x + increment) % length;
                result += alphabet[x];
            }
            return result;
        }

        private string GetRepeatKey(string s, int n)
        {
            var r = s;
            while (r.Length < n)
            {
                r += r;
            }

            return r.Substring(0, n);
        }

        private string Cipher(string text, string secretKey)
        {
            var currentKey = GetRepeatKey(secretKey, text.Length);
            var res = string.Empty;
            for (var i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();
            }

            return res;
        }

        public string Encrypt(string plainText, string password)
            => Cipher(plainText, password);

        public string Decrypt(string encryptedText, string password)
            => Cipher(encryptedText, password);
    }
}
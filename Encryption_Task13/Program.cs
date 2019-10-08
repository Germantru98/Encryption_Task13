using System;

namespace Encryption_Task13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Encryptor encryptor = new Encryptor();
            DataPharser data = new DataPharser();
            var message = data.getMessage();
            var key = encryptor.Generate_Pseudorandom_KeyWord(8, 3, data.GetAlphabet());
            Console.WriteLine("Сгенерированный ключ: " + key);
            var encryptedMessage = encryptor.Encrypt(message, key);
            Console.WriteLine(encryptedMessage);
            var decryptedMessage = encryptor.Decrypt(encryptedMessage, key);
            Console.WriteLine(decryptedMessage);
        }
    }
}
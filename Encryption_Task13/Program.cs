using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryptor encryptor = new Encryptor();
            DataPharser data = new DataPharser();
            var message = data.getMessage();
            var key = encryptor.Generate_Pseudorandom_KeyWord(8, 3, data.GetAlphabet());
            Console.WriteLine("Сгенерированный ключ: "+key);
            var encryptedMessage = encryptor.Encrypt(message, key);
            Console.WriteLine(encryptedMessage);
            var decryptedMessage = encryptor.Decrypt(encryptedMessage, key);
            Console.WriteLine(decryptedMessage);
        }
    }
}

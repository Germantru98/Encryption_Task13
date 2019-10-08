using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Encryption_Task13
{
    internal class DataPharser
    {
        public string getMessage()
        {
            using (StreamReader stream = new StreamReader("Message.txt", Encoding.Default))
            {
                return stream.ReadToEnd().ToUpper();
            }
        }

        public List<char> GetAlphabet()
        {
            using (StreamReader stream = new StreamReader("Alphabet.txt", Encoding.Default))
            {
                return stream.ReadToEnd().ToList();
            }
        }
    }
}
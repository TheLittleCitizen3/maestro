using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decryptor
{
    class Program
    {

        static void Main(string[] args)
        {
            string decryptedString = "";
            foreach (var i in args)
            {
                string secrectChar = _secret(i);
                secretString -= 1;
                decryptedString += (char)secretString;
            }

            Console.WriteLine(decryptedString);
        }
    }
}

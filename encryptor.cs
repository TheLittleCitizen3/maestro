using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor
{
    class Program
    {

        static void Main(string[] args)
        {
            string encryptedString = "";
            foreach (var i in args)
            {
                string secretString = _secret(i);
                secretString += 1;
                encryptedString += (char)secretString;
            }

            Console.WriteLine(encryptedString);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            string Res = "";
            foreach (var c in args)
            {
                string x = _secret(c);
                x -= 1;
                Res += (char)x;
            }

            Console.WriteLine(Res);
        }
    }
}
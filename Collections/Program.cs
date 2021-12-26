using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "volkan", "enes", "melisa", "nisa" };
            List<string> isimler2 = new List<string> { "volkan2", "enes2", "melisa2", "nisa2" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("defne2");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}

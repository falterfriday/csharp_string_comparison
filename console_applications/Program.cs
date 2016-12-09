using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "hello, who is this?";
            string string2 = "Hello, who is this?";
            if (string1.Equals(string2))
            {
                Console.WriteLine("Yeah... they're equal");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nope... Not so equal");
                Console.ReadKey();
            }
                //using StringComparison to ignore case
            if (string1.Equals(string2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Yeah... they're equal");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Nope... Not so equal");
                Console.ReadKey();
            }
        }
    }
}

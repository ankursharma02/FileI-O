using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class try_parse_demo
    {
        public static void Main()
        {
            Console.WriteLine("Enter a  int value ");
            int a;
            if (Int32.TryParse(Console.ReadLine(), out a))
                Console.WriteLine(a);
             else
                Console.WriteLine("Not a  integer number");

            Console.ReadLine();
        }
    }
}

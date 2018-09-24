using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            while (i != 0)
            {
                Console.WriteLine("Enter 0 to exit");
                i = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("okay bye press Enter to close console");
            Console.Read();
            
        }
    }
}

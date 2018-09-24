using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'A'; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

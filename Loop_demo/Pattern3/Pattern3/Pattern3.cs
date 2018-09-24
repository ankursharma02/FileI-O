using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern3
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'E'; i++)
            {
                for (char j = 'E'; j >= i; j--)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

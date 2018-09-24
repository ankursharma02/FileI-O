using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern4
{
    class Pattern4
    {
        
        static void Main(string[] args)
        {
            char ch;
            for (char i = 'A'; i <= 'E'; i++)
            {
                ch= 'A';
                for (char k = 'E'; k > i; k--)
                    Console.Write(" ");
                for (char j = 'A'; j <= i; j++)
                {
                     Console.Write(ch++);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}

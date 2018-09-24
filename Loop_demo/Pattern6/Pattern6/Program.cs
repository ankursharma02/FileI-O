using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern6
{
    class Program
    {
        static void Main(string[] args)
        {
            int no=0;
            for (int i = 1; i <= 5; i++)
            {
                no = i;
                for (int j = 5; j > i; j--)
                    Console.Write(" ");
                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    if (k <= i)
                        Console.Write(k);
                    else
                        Console.Write(--no);
                   
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

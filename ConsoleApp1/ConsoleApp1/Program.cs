using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome again");
            int n = 1;
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 5; k >=n; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n*2-1; j++)
                {
                    if (j == 1 || j == n * 2 - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                if (i < 5)
                    n++;
                else
                    n--;
             }
            Console.Read();
           
        }
    }
}

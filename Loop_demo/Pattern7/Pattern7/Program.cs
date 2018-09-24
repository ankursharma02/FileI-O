using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern7
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 1;
           
            for (int i = 0; i <=10; i++)
            {
                for (int j = 1; j <= no; j++)
                    Console.Write("*");
                Console.WriteLine();
                if (i < 10/ 2)
                    no++;
                else
                    no--;
            }
            Console.ReadLine();
        }
    }
}

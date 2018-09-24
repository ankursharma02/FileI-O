using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1
{
    class Pattern1
    {
        static void Main(string[] args)
        {
            int no;

            for (int i = 1; i <= 5; i++)
            {
                no = i;
                for (int j = 1; j <=i; j++)
                {
                    Console.Write(no + " ");
                    no += 5 - j;

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

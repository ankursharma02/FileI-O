using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Var_length_per
    {
        public static void Main()
        {
            int res;
            res = sum(2, 3, 4);
            Console.WriteLine("sum of 2,3,4 =" + res);
            res = sum(2, 2, 2, 3, 4, 3, 4, 3);
            Console.WriteLine("sum of 2, 2, 2, 3, 4, 3, 4, 3=" + res);
            Console.ReadLine();

        }
        public static int sum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            return sum;

        }
    }
}

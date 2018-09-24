using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Call_by_ref
    {
        public static void Main()
        {
            Console.WriteLine("Enter two values ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            
            swap(ref a,ref b);
            Console.WriteLine("After swape a: " + a + " b: " + b);
            Console.ReadLine();
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
    }
}

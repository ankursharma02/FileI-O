using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Out_peram
    {
        public static void Main()
        {
            int a, b,sum,prod,diff;
            Console.WriteLine("Enter two values ");
            a=Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Calculate(a, b, out sum, out prod, out diff);
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("prod=" + prod);
            Console.WriteLine("diff=" + diff);
            Console.ReadLine();
        }
        public static void Calculate(int a, int b, out int s, out int p, out int d)
        {
            s = a + b;
            p = a * b;
            d = a - b;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rev_meth1
    {
        public static void Main()
        {
            Console.WriteLine("Enter value to fact ");
            int no = Convert.ToInt32(Console.ReadLine());
            int fact = fact_demo(no);
            Console.WriteLine("fact of " + no + " is " + fact);
            Console.ReadLine();

        }
        public static int fact_demo(int no)
        {
            if (no == 1)
                return 1;
            else
                return no * fact_demo(no - 1);
        }
    }
}

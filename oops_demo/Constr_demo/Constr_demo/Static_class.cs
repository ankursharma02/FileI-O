using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constr_demo
{
    class Static_class
    {
        public static float PI = 3.14f;
        public static int cube(int n) { return n * n * n; }

    }
    class use_static_class
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is: " + Static_class.PI);
            Console.WriteLine("Cube of 3 is: " + Static_class.cube(3));
            Console.ReadLine();
        }
    }
}

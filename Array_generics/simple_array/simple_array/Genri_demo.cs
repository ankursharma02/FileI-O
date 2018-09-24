using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Genri_demo
    {
        static void Display<G>(G s)
        {
            Console.WriteLine(" value of s is " + s);
        }
        public static void Main()
        {
            Display<int>(10);
            Display<string>("Hello");
            Display<double>(10.11);
            Display<char>('A');
            Console.ReadLine();

        }
    }
}

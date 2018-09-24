using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ann_method
    {
        public delegate void Print(int value);

        
          
            static void Main(string[] args)
            {
            Print p = delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); };
                 p(111);
                Console.Read();
            }

        
    }
}

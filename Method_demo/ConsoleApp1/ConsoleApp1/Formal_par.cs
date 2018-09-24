using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Formal_par
    {

        public  static void Main(string[] args)
        {
            
            Console.WriteLine("call method ");
            show_msg("ank");
            Console.ReadLine();

        }
        public  static void show_msg(String s)
        {
            Console.WriteLine("hello display " + s);
        }
    }
}

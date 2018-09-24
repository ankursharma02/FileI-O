using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class cmd_demo
    {
        public static void Main(String[] arg)
        {
            Console.WriteLine("arg length is " + arg.Length);
            foreach (string s in arg)
                Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

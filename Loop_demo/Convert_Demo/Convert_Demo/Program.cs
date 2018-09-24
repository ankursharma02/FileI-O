using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            Console.WriteLine(Convert.ToInt32(str));
            // Console.WriteLine(int.Parse(str));
            Console.WriteLine(sizeof(Int16));
            Console.WriteLine(sizeof(Int32));
            Console.WriteLine(sizeof(Int64));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(Double));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constr_demo
{
    struct Struct_demo
    {
        int i;
        public void display()
        {
            Console.WriteLine("method in struct ");
        }
        Struct_demo(int i)
        {
            this.i = i;
        }
        public static void Main()
        {
            Struct_demo d=new Struct_demo();
            Struct_demo d1 = new Struct_demo(10);

            d.display();

            Console.WriteLine(d.i);
            Console.WriteLine(d1.i);
            Console.ReadLine();

        }

    }
}

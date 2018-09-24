using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_inher_demo
{
    class multilevel_inher_demo
    {
        public void demo1()
        {
            Console.WriteLine("demo1()");
        }

    }
    class D : multilevel_inher_demo
    {
        public void dem02()
        {
            Console.WriteLine("demo2");

        }
    }
    class E : D
    {
        public void demo3()
        {
            Console.WriteLine("demo3");
        }
    }
    class F
    {
        static void Main()
        {
            E e = new E();
            e.demo1();
            Console.ReadLine();
        }
    }
}

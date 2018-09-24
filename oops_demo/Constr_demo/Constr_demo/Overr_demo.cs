using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constr_demo
{
    class A
    {
        public void demo()
        {
            Console.WriteLine("A.demo()");
        }
    }
    class B
    {
        public void demo()
        {
            Console.WriteLine("C.demo()");
        }
    }
    class C
    {
        public void demo()
        {
            Console.WriteLine("C.demo()");
        }
    }
    class Overr_demo
    {
        static void Main()
        {
            A a = new A();
            a.demo();
            B b = new B();
            b.demo();
            C c = new C();
            c.demo();
            Console.WriteLine();


        }
    }
}

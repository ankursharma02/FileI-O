using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overr_demo
{
    class A
    {
        public virtual void  demo()
        {
            Console.WriteLine("A.demo()");
        }
    }
    class B:A
    {
        public override void demo()
        {
            Console.WriteLine("B.demo()");
        }
    }
    class C:B
    {
        public override void demo()
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
            Console.ReadLine();


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_inher_demo
{
    class A
    {
       
        public void A_f1()
        {
            Console.WriteLine("A_f1()");
        }
        public void A_f2()
        {
            Console.WriteLine("A_f2()");
        }

    }
    class B : A
    {
        public void B_f1()
        {
            Console.WriteLine("B_f1()");
        }
        public void B_f2()
        {
            Console.WriteLine("B_f2()");
        }
    }
    class C
    {
        static void Main()
        {
            B b1 = new B();
            b1.A_f1();
            b1.A_f2();
            b1.B_f1();
            b1.B_f2();
            
            Console.ReadLine();
            
        }
    }

}

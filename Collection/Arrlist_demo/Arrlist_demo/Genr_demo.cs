using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist_demo
{
    class Genr_demo
    {
        public static bool Compare<T>(T A,T B)
        {
            if (A.Equals(B))
                return true;
           
                return false;
            
            
        }
        public static void add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }
        public static void sub<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1-d2);
        }
        public static void mul<X>(X a, X b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1*d2);
        }
        public static void Main()
        {
            Console.WriteLine(Compare(10,10.44));
            Console.Write(" for int value(10,10) = ");
            add<int>(10, 10);
            sub<int>(10, 10);
            mul<int>(10, 10);

            Console.Write(" for float value(10.34,22.43) = ");
            add<float>(10.34f, 22.43f);
            sub<float>(10.34f, 22.43f);
            mul<float>(10.34f, 22.43f);

            Console.ReadLine();
        }
    }
}

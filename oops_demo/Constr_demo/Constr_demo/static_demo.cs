using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constr_demo
{
    class static_demo
    {
        public int accno;
        public String name;
        public static float rateOfInterest = 8.8f;
        public static_demo(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }
    class TestAccount
    {
        public static void Main(string[] args)
        {
            static_demo a1 = new static_demo(101, "Sonoo");
            static_demo a2 = new static_demo(102, "Mahesh");
            a1.display();
            a2.display();
            Console.ReadLine();

        }
    }
}

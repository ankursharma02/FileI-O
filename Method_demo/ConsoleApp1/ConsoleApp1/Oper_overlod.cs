using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Money
    {
        private int rs;
        private int ps;
        public void read()
        {
            this.rs=Convert.ToInt32(Console.ReadLine());
            this.ps = Convert.ToInt32(Console.ReadLine());
        }
        public void show()
        {
            Console.WriteLine("money is " + rs + "." + ps);
        }
        public Money()
        {
            rs = ps = 0;
        }
        public Money(int rs, int ps)
        {
            this.rs = rs;
            this.ps = ps;

        }
        public Money(Money m1)
        {
            this.rs = m1.rs;
            this.ps = m1.ps;

        }
        public static Money operator +(Money m1, Money m2)
        {
            Money temp = new Money();
            temp.rs = m1.rs + m2.rs;
            temp.ps = m1.ps + m2.ps;
            if (temp.ps >= 100)
            {
                temp.rs++;
                temp.ps %= 100;
            }
            return temp;
            
        }


    }

    class Oper_overlod
    {

        public static void Main()
        {

            Money m1 = new Money(10, 99);
            Money m2 = new Money(3, 99);
            Money m3;
            m3 = m1 + m2;
            Console.WriteLine("Addition is ");
            m3.show();
            Console.ReadLine();
        }
    }
}

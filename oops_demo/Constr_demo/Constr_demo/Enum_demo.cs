using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constr_demo
{
    public enum Days
    {
        Mon,Tue,Wed,thu,Fri
    }
    class Enum_demo
    {
        static void Main()
        {
            Days d;
            d = Days.Mon;
            Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}

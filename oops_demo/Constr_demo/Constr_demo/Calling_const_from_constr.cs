using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constr_demo
{
    class Calling_const_from_constr
    {
        private int x;
        private int y;
        private int z;
        public Calling_const_from_constr(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
       // public Calling_const_from_constr(int x, int y)
       // {
       //     this.x = x;
       //     this.y = y;

       // }
        public Calling_const_from_constr(int x, int y) : this(x, y,0)
        {}
        public Calling_const_from_constr(int x) : this(x, 0, 0)
        { }
        public Calling_const_from_constr() : this(0, 0, 0)
        {
        }
        static void Main()
        {
            Calling_const_from_constr c1 = new Calling_const_from_constr(1, 2, 3);
            Console.WriteLine("c1 values x:" + c1.x + " y:" + c1.y + " z:" + c1.z);
            Calling_const_from_constr c2 = new Calling_const_from_constr(1, 2);
            Console.WriteLine("c2 values x:" + c2.x + " y:" + c2.y + " z:" + c2.z);
            Console.ReadLine();
        }
    }
}

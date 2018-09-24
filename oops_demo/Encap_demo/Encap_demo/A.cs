using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encap_demo
{
    class A
    {
        int std_id;
        string std_fname;
        string std_lname;
        public void read_std()
        {
            std_id = Convert.ToInt32(Console.ReadLine());
            std_fname = Console.ReadLine();
            std_lname = Console.ReadLine();

        }
        public void display_std()
        {
            Console.Write("id : " + std_id + " fname : " + std_fname + " lname :" + std_lname);
        }
    }
    class B
    {
        public static void Main()
        {
            A a = new A();
            Console.WriteLine("----------Enter Student id fname and lname-------------");
            a.read_std();
            Console.WriteLine("---------Details are------------------- ");
            a.display_std();
           
            Console.ReadLine();

        }
    }
}

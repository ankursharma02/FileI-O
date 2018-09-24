using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constr_demo
{
    class Constr_demo
    {
        int std_id;
        string std_fname;
        string std_lname;
        int std_age { set; get; } = 23;
        public Constr_demo(int std_id, string std_fname, string std_lname)
        {
            this.std_id = std_id;
            this.std_fname = std_fname;
            this.std_lname = std_lname;

        }
        public Constr_demo(Constr_demo d)
        {
            std_id = d.std_id;
            std_fname = d.std_fname;
            std_lname = d.std_lname;
        }
        public void display()
        {
            Console.WriteLine("std_id : " + std_id + " std_fname : " + std_fname +" std_lname : "+std_lname+" std_age"+std_age);

            Console.ReadLine();
        }
        ~Constr_demo()
        {
            Console.WriteLine("destructor()");
             Console.ReadLine();
        }
      
    }
    class Demo
    {
        public static void Main()
        {
            Constr_demo d = new Constr_demo(1,"sn","sd");
            d.display();
            Constr_demo d1 = new Constr_demo(d);
            d1.display();
        
            
          //  Console.ReadLine();

        }
    }
}

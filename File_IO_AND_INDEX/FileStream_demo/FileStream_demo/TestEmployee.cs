using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream_demo
{
    class TestEmployee
    {
        static void Main()
        {
            Employee emp = new Employee(1001, "scoot", "Manager", 20000.00, "Sales", "Mumbai");
            emp[0] = 1111;
            emp[1] = "ankur";
            Console.WriteLine("ENo:" + emp[0]);
            Console.WriteLine("EName:" + emp[1]);
            Console.WriteLine("job:" + emp[2]);
            Console.WriteLine("Salary:" + emp[3]);
            Console.WriteLine("Dname:" + emp[4]);
            Console.WriteLine("Location:" + emp[5]);
            
            Console.ReadLine();
        }
            
    }
}

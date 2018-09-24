using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cls_prop
    {
        public static void Main()
        {
            Employee_demo e1 = new Employee_demo();
            Console.WriteLine("--------Enter Employee details---------- ");
            Console.WriteLine("Enter Employee ID ");
            e1.PEmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name ");
            e1.pEName = Console.ReadLine();
            Console.WriteLine("Enter Employee Address ");
            e1.PEAddress = Console.ReadLine();
            Console.WriteLine("Enter Employee Age ");
            e1.PAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------Employee Details are ------------");
            Console.WriteLine("Employee ID  :" + e1.PEmpId);
            Console.WriteLine("Employee Name :" + e1.pEName);
            Console.WriteLine("Employee Address :" + e1.PEAddress);
            Console.WriteLine("Employee Age :" + e1.PAge);
            Console.ReadLine();
        }
    }
}

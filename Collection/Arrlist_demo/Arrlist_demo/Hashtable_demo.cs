using System;
using System.Collections;

namespace Arrlist_demo
{
    class Hashtable_demo
    {
        static int j=0;
        public static void Main()
        {
            Hashtable h1, h2, h3;
            h1 = new Hashtable();
            h2 = new Hashtable();
            h3 = new Hashtable();
            Console.WriteLine("How many Employee details u want to enter ");
            int n=Convert.ToInt32(Console.ReadLine());
            Hashtable[] h = new Hashtable[n];
            for (int i = 0; i < h.Length; i++)
            {
                Console.WriteLine("Enter  employee "+ (i+1)+" details ");
                h[i] = new Hashtable();
                add_emp_details(h[i]);
            }
            while (j < h.Length)
                show_emp_details(h[j]);

            Console.ReadLine();


        }
        public static void add_emp_details(Hashtable h)
        {
            Console.WriteLine("Enter Employee id");
            h.Add("empId", Console.ReadLine());
            Console.WriteLine("Enter Employee name");
            h.Add("empName", Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            h.Add("empSalary", Console.ReadLine());
            
         }
        public static void show_emp_details(Hashtable h)
        {
            Console.WriteLine("Employee " + (j+1) + " details are ");
            Console.WriteLine("=============================");
            foreach (object key in h.Keys)
                Console.WriteLine(key + " :" + h[key]);
            j++;
            Console.WriteLine("============================");
        }
    }
}

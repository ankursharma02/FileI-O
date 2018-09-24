using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Avg_std
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  number of student ");
            int std_no = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[std_no];
            Console.WriteLine("Enter marks of student ");
            double sum = 0;
            for (int i=0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
                
            }
            Console.WriteLine("avg marks of  std = " + sum / std_no);
            Console.ReadLine();
        }
    }
}

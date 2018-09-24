using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Copy_arr
    {
        public static void Main()
        {
            int[] arr = new int[8] { 11,12,13, 14,1, 2, 3, 4 };
            int[] arr1 = new int[5] { 5, 6,7,8,9 };
            arr1.CopyTo(arr,2);
            Console.WriteLine("arr values");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i]+"  ");
            Console.WriteLine();
            Console.WriteLine("arr1 values");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i]);
            Console.WriteLine("after sort");
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");
            Console.WriteLine("\nusing Array.copy");
            Array.Copy(arr,2, arr1, 3,2);

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + "  ");

            Console.WriteLine("arr1 value");
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + "  ");


            Console.ReadLine();
        }
    }
}

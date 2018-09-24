using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class arr_resize
    {
        public static void Main()
        {
            Console.WriteLine("enter no of element");
            int r = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[r];
            Console.WriteLine("Enter element in array ");
            
            for (int i=0;i<arr.Length;i++)
                 arr[i] = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arr, r + 1);
            Console.WriteLine("Enter value to insert ");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter element position");
            int el = Convert.ToInt32(Console.ReadLine());
            int temp = arr[el-1];
            
            arr[el-1] = val;
            

            for (int i = arr.Length -1; i > el; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[el ] = temp;


            Console.WriteLine("arr values are");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");
            Console.ReadLine();
        }
    }
}

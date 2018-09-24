using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Copy_arr1
    {
        public static void Main()
        {
            int[] arr = new int[5] { 1,2,3,4,5};
            int[] arr1 = new int[8] { 6,7,8,9,10,11,12,13};
            Console.WriteLine("Element of arr are ");
            foreach(int i in arr)
                Console.Write(i + " ");
     
            Console.WriteLine("\n Element of arr1 are ");
            foreach (int i in arr1)
                Console.Write(i + " ");
            // arr.CopyTo(arr1, 2);
            // Array.Copy(arr, arr1, 3);
            Array.Copy(arr, 2, arr1, 4, 3);
            Console.WriteLine("\n\nElement of arr are ");
            foreach (int i in arr)
                Console.Write(i + " ");

            Console.WriteLine("\n Element of arr1 are ");
            foreach (int i in arr1)
                Console.Write(i + " ");

            Array.Sort(arr1,3,4);
            Console.WriteLine("\n Element of arr1 after sort ");
            foreach (int i in arr1)
                Console.Write(i + " ");
            Array.Clear(arr1, 2, 5);
            Console.WriteLine("\n Element of arr1 after clear ");
            foreach (int i in arr1)
                Console.Write(i + " ");
            Console.WriteLine("\narr1 length " + arr1.Length);
            Array.Resize(ref arr1,9);
            Console.WriteLine("arr1 length after resize " + arr1.Length);


            Console.ReadLine();



        }
    }
}

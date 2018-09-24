using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class arr_demo_1
    {
        public static void Main()
        {
            int[] arr = new int[5];
            arr[3] = 4;
            arr[4] = 5;
            foreach (int i in arr)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}

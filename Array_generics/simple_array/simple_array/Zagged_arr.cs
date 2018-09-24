using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Zagged_arr
    {
        public static void Main()
        {
            int[][] arr = new int[8][];
            arr[0] = new int[4] {1,2,3,4 };
            arr[1] = new int[3] { 1, 2, 3 };
            arr[2] = new int[2] { 1, 2 };
            arr[3] = new int[3] { 1, 2, 3};
            arr[4] = new int[4] { 1, 2, 3,4 };
            arr[5] = new int[5] { 1, 2,3,4,5 };
            arr[6] = new int[4] { 1, 2, 3, 4 };
            arr[7] = new int[3] { 1, 2, 3 };



            Console.WriteLine("arr values -----");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j]+" ");
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}

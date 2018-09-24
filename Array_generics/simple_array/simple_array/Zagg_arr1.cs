
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Zagg_arr1
    {
        public static void Main()
        {
            Console.WriteLine("Enter no of row ");
            int r = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[r][];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine("Enter no of col for row " + i);

                int col = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[col];
                Console.WriteLine("Enter value in row " + i);
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("values in zagged array are ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");

                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

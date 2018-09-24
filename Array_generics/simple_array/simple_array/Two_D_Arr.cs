using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Two_D_Arr
    {
        public static void Main()
        {
            Console.WriteLine("Enter row and column ");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[r,c];
            Console.WriteLine("Enter values in matrix ");
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());


            int[,] arr1 = new int[r, c];
            Console.WriteLine("Enter values  in second matrix ");
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                int[,] arr2 = add_arr(arr, arr1);

            Console.WriteLine("matrix1 values  are  ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("matrix2 values  are  ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("addition of  matrix1 and matrix2   are  ");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
          
            Console.ReadLine();
        }
        public static int[,] add_arr(int[,] arr1, int[,] arr2)
        {
            int[,] arr3 = new int[arr1.GetLength(0), arr1.GetLength(1)];
            for (int i = 0; i < arr3.GetLength(0); i++)
                for (int j = 0; j < arr3.GetLength(1); j++)
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                

            return arr3;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_to_Words
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------Enter number to convert in word---------- ");
            int num = Convert.ToInt32(Console.ReadLine());//int.Parse(Console.ReadLine());
            String str_num = Convert.ToString(num);
            int len = str_num.Length;
            int factor = 10;
            for (int i = 2; i < len; i++)
                factor *= 10;
            int temp = num;
            while (factor != 0)
            {
                int n = temp / factor;
                temp %= factor;
                factor /= 10;
                switch (n)
                {
                    case 0:
                        Console.Write("Zero ");
                        break;
                    case 1:
                        Console.Write("One ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;

                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;


                }
            }
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            //Array.Reverse(arr);
            //foreach(int a in arr)
            //{
            //    Console.Write(a + " ");
            //}
          
            Console.ReadLine();
        }
    }


}

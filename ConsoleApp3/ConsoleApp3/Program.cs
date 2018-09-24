using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                Console.WriteLine("in  do block " + i);
            }
            while (i > 5);

            Console.WriteLine("foreach demo");
            char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
             
            }
            int[] arr = new int[4]{ 1,2,3,4};
            foreach (int a in arr)
            {
                Console.WriteLine(a);

            }
            Console.WriteLine("arr size " +arr.Length);
            Console.Read();
        }
    }
}

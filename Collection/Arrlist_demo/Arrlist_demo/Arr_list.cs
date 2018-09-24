using System;
using System.Collections;

namespace Arrlist_demo
{
    class Arr_list
    {
        static void Main(string[] args)
        {

            ArrayList arr = new ArrayList();
            arr.Add(11);
            arr.Add(22);
            arr.Add("addasd");
            arr.Add(33);
            arr.Add(44);
            arr.Add("ss");
            arr.Add(66);
            arr.Add(77);
            arr.Add("addasd");
            arr.Add(88);
            arr.Add(99);
            arr.Add("ass");
            
            Console.WriteLine("ArrayList values are ");
            foreach (object obj in arr)
            {
                Console.Write(obj+"  ");
            }
            arr.Insert(2,88);
            Console.WriteLine("\nArrayList values after insert ");
            foreach (object obj in arr)
            {
                Console.Write(obj+"  ");
            }
            arr.Remove("addasd");
            Console.WriteLine("\n ArrayList values after remove ");
            foreach (object obj in arr)
            {
                Console.Write(obj+"  ");
            }
            arr.RemoveAt(2);
            Console.WriteLine("\n ArrayList values after removeAt ");
            foreach (object obj in arr)
            {
                Console.Write(obj+" ");
            }
            arr.RemoveRange(2, 4);
            Console.WriteLine("\n ArrayList values after removerange ");
            foreach (object obj in arr)
            {
                Console.Write(obj+" ");
            }
            arr.Reverse();
            Console.WriteLine("\n ArrayList values after reverse ");
            foreach (object obj in arr)
            {
                Console.Write(obj + " ");
            }

            
            
            Console.ReadLine();


        }
    }
}

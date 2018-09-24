using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist_demo
{
    class Stack_demo
    {

        public static void Main(string[] args)
        {
            Stack<int> values = new Stack<int>();
            for(int i=0;i<20;i++)
            values.Push(i);
           
            foreach (int i in values)
            {
                Console.Write(i+" ,");
            }
            Console.WriteLine("avg = "+values.Average());
            Console.WriteLine("Peek element: " + values.Peek());
            Console.WriteLine("Pop: " + values.Pop());
            Console.WriteLine("After Pop, Peek element: " + values.Peek());
            Console.ReadLine();
        }
    }
}

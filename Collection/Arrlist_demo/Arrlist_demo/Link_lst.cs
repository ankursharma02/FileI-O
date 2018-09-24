using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist_demo
{
    class Link_lst
    {
        public static void Main(string[] args)
        {
            // Create a list of strings  
            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");
            names.AddFirst("John");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(" \naddafter\n ");

            LinkedListNode<string> node = names.Find("Ankit");
            names.AddAfter(node, "ankur");
              
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(" \naddbefore\n\n ");
            // LinkedListNode<string> node1 = names.Find("Ankit");
            names.AddBefore(node, "ankur");
            
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("after remove ");
            names.Remove("ankur");
            names.RemoveFirst();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("after removefirst ");
           
            names.RemoveFirst();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }



            Console.ReadLine();
        }

    }
}

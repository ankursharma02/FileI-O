using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist_demo
{
    class Hashset_demo
    {
        public static void Main()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");
            names.Add("hello");
            names.Add("hello");
            names.Add("hello");
            names.Add("hello");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Remove("hello");
            Console.WriteLine("after remove ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

           
            Console.WriteLine(names.Contains("hello"));
            Console.ReadLine();
            SortedSet<string> st = new SortedSet<string>();
            st.Add("asd");
            st.Add("da");
            st.Add("re");
            st.Add("yt");
            st.Add("ed");
            foreach (string i in st)
                Console.WriteLine(i);
            
            
            Console.ReadLine();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrlist_demo
{
    class Dict_demo
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "Sonoo");
            names.Add("2", "Sonoo");
            names.Add("3", "James");
            names.Add("4", "Ratan");
            names.Add("5", "Irfan");

            names.Add("10", "Sonoo");
            names.Add("9", "Peter");
            names.Add("8", "James");
            names.Add("7", "Ratan");
            names.Add("6", "Irfan");
            
            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.ReadLine();
        }

    }
}

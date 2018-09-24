using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rec_meth
    {
        public static void Main()
        {
            Console.WriteLine("Enter a String  to reverse");
            string str = Console.ReadLine();
            string str1 = reverse_str(str);
            Console.WriteLine("String := "+str);
            Console.WriteLine("reverse:= "+str1);
            Console.ReadLine();

        }
        public static string reverse_str(string s1)
        {
            char[] ch = s1.ToCharArray();
            if (s1.Length == 0)
                return "";
            else
                return ch[ch.Length - 1] + reverse_str(s1.Substring(0,s1.Length-1));

        }
    }
}

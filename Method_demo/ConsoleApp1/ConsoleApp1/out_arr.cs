using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class out_arr
    {
        public static void Main()
        {
            string a;
            string[] s3; 
            Console.WriteLine("Enter  string ");
            a = Console.ReadLine();
            string[] s1 = out_fun(out s3,a);
        for(int i=0;i<s1.Length;i++)
            Console.WriteLine(s1[i]);
            Console.ReadLine();
        }

        public static string[] out_fun(out string[]  s3,params string[] a)
        {
            // string s1 = "";
            s3 = new string[a.Length];
            s3[0] = a[0];
            for (int i = 1; i < a.Length; i++)
                s3[i]+= a[i];
            return s3;
        }

    }
}

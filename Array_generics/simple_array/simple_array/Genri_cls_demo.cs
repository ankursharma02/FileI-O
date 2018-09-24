using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_array
{
    class Genri_cls_demo<G,S>
    {
        public void display(G s)
        {
            Console.WriteLine("vlaue of s is " + s); ;
        }
        public void display(G s1,S s2)
        {
            Console.WriteLine("vlaue of s1 is " + s1+" s2="+s2); ;
        }

    }
    class Use_genr_cls
    {
        public static void Main()
        {
            Genri_cls_demo<string,int> obj1 = new Genri_cls_demo<string,int>();
            Genri_cls_demo<int,int> obj2 = new Genri_cls_demo<int,int>();
            Genri_cls_demo<int,double> obj3 = new Genri_cls_demo<int,double>();
            obj1.display("ankur",1);
            obj2.display(231);
            obj3.display(1,123.32);
            Console.ReadLine();
         }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("e:\\b.txt",FileMode.OpenOrCreate);
            for(byte i=65;i<90;i++)
            f.WriteByte(i);

           
            f.Close();
        }
    }
}

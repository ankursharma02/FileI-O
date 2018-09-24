using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_demo
{
    class Text_writer_demo
    {
        public static void Main()
        {
            //TextWriter tx = File.CreateText("e:\\f.txt");

            //    tx.WriteLine("Hello textwriter");
            //    tx.WriteLine("Hello again");

            //Console.WriteLine("Data stored success");
            using (TextWriter writer = File.CreateText("e:\\f.txt"))
            {
                writer.WriteLine("hello c#");
                writer.WriteLine("c# file handling by javatpoint");
            }
            using (TextReader tr = File.OpenText("e:\\f.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }

            Console.ReadLine();

        }
    }
}

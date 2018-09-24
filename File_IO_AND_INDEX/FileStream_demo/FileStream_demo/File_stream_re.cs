using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class File_stream_re
    {
        public static void Main()
        {
            FileStream fs = new FileStream("e://demo.txt",FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            //  string line = sr.ReadLine();
           
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(sr.Peek());
                Console.WriteLine(line);
            }
            Console.WriteLine(sr.Peek());
            sr.Close();
            fs.Close();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_demo
{
    class File_stream_wr
    {
        public static void Main()
        {
            FileStream fs = new FileStream("E://demo.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            
            sw.WriteLine("Hello demo");
            sw.WriteLine("new line");
            sw.Close();
            fs.Close();
            Console.WriteLine("File created successfully");
        }
    }
}

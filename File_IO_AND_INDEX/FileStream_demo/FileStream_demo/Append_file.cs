using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class Append_file
    {
        public static void Main()
        {

            FileStream fs = new FileStream("e://f.txt", FileMode.Open);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i < 5; i++)
                sw.WriteLine("append demo11");

            Console.WriteLine("append completed");
            sw.Flush();
            fs.Close();
            Console.ReadLine();
               
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class Delete_path_file
    {
        public static void Main()
        {
            string path = "e://f.txt";
            File.Delete(path);
            Console.WriteLine("File delete successfull");
            Console.ReadLine();
         }
    }
}

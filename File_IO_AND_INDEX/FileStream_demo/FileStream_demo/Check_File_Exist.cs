using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream_demo
{
    class Check_File_Exist
    {
        public static void Main()
        {
              string path = "e://f.txt";
          //  string path = "e://e.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exist ");


            }
            else
                Console.WriteLine("File not exist");
            Console.ReadLine();
        }
    }
}

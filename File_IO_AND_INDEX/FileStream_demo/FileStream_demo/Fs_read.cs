using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class Fs_read
    {
        public static void Main()
        {
            FileStream fs=new FileStream("E:\\b.txt",FileMode.OpenOrCreate);
            int i = 0;
            while ((i=fs.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            
            Console.ReadLine();
           
        }
    }
}

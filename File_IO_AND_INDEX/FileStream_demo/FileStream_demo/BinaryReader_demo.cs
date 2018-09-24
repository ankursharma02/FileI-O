using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class BinaryReader_demo
    {
        public  static void Main()
        {
            FileStream fs = new FileStream("e:/bin_wr_demo.dat", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            while (br.PeekChar() != -1)
            {
                Console.WriteLine(br.ReadInt32());
            }
            Console.ReadLine();
        }
    }
}

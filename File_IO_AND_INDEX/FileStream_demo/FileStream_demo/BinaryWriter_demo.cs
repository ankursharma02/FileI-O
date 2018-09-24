using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class BinaryWriter_demo
    {
        public static void Main()
        {
            FileStream fs = new FileStream("e:/bin_wr_demo.dat", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < 10; i++)
                bw.Write(i);
            bw.Close();
            fs.Close();
            Console.ReadLine();


        }
    }
}

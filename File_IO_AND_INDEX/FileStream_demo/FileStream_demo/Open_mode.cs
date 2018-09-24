using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class Open_mode
    {
        public static void Main()
        {
            FileStream fs = new FileStream("e://f.txt", FileMode.Open,FileAccess.Read,FileShare.Read);

            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine("try to add");
            //sw.Flush();
            sr.Close(); 
            fs.Close();

            Console.ReadLine();
        }
    }
}

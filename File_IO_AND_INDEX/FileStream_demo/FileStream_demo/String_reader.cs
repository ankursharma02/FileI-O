using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileStream_demo
{
    class String_reader
    {
        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the Home \n" +
                "It is nice home. \n" +
                "It provides full relax";
            // Creating StringBuilder instance  
            StringBuilder sb = new StringBuilder();
            // Passing StringBuilder instance into StringWriter  
            StringWriter writer = new StringWriter(sb);
            // Writing data using StringWriter  
            writer.WriteLine(text);
            writer.Flush();
            // Closing writer connection  
            writer.Close();
            // Creating StringReader instance and passing StringBuilder  
            StringReader reader = new StringReader(sb.ToString());
            // Reading data  
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
            Console.ReadLine();
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool append = true;
            string filename = "sample5";
            string fileExt = "txt";
            while (true)
            {
                using (StreamWriter sw 
                    = new StreamWriter(filename + "." + fileExt, append))
                {
                    string input = Console.ReadLine();
                    sw.WriteLine(input);
                }
                //Console.ReadKey();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ListFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\Materials\Sem-6\SE";
            string[] arr1 = Directory.GetFiles(path);

            

            foreach(string name in arr1)
                Console.WriteLine(name);

            Console.Read();
        }
    }
}

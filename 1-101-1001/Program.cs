using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_101_1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                Console.Write("1");
                for (j = 1; j <= i; j++)
                {
                    Console.Write("0");
                }
                if (i != 0)
                {
                    Console.Write("1");
                }

                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

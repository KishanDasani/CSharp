using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{
    class Program
    {
        static void Main(string[] args)
        {
            pattern1();
            pattern2();
            pattern3();
            pattern4();
        }

        static void pattern1()
        {
            int i, j;
            Console.WriteLine("Pattern1");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

        static void pattern2()
        {
            int i, j;
            Console.WriteLine("Pattern2");
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

        static void pattern3()
        {
            int i, j;
            Console.WriteLine("Pattern3");
            for (i = 5; i > 0; i--)
            {
                for (j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();
        }

        static void pattern4()
        {
            Console.WriteLine("Pattern4");
            int number, i, j, count = 1;
            number = 5;
            count = number - 1;
            for (j = 1; j <= number; j++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;

                for (i = 1; i <= 2 * j - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay3_Program4_
{
    //find the value at position p in given value n
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to find the value of the bit at position p in given value n");
            Console.WriteLine("Enter the number");
            int num;
            bool p1 = Int32.TryParse(Console.ReadLine(), out num);

            Console.WriteLine("Enter the position");
            int p;
            bool p2 = Int32.TryParse(Console.ReadLine(), out p);

            if(p1 && p2)
            {
                if(p < 32)
                {
                    int i = 1;

                    int mask = i << p;

                    Console.WriteLine((num & mask) != 0 ? "The Value at given position " + p + " for " + num + " is 1" : "The Value at given position " + p + " for " + num + " is 0");
                }
                else
                {
                    Console.WriteLine("Given Position Value is not valid as only 0 to 31 is allowed as position");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input Entered");
            }
            Console.ReadLine();
        }
    }
}

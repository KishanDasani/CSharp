using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay3_Program3_
{
    //check that third bit is 1 or 0
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to check that third bit in given number is 0 or 1");
            Console.WriteLine("Enter the number");
            int num;
            bool p1 = Int32.TryParse(Console.ReadLine(), out num);

            Console.WriteLine(p1 ? ((num & 8) != 0) ? "Third Bit is 1 in given value " + num : "Third Bit is 0 in given value " + num : "Invalid Input Entered");

            Console.ReadLine();
        }
    }
}

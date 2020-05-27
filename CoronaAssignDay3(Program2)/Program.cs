using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay3_Program2_
{
    //check the third digit (right to left) is 7?
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to check that the third digit (right to left) is 7 or not in given number");
            Console.WriteLine("Enter the number\nthe Range is -2147483647 to 2147483647");
            
            bool p1 = Int32.TryParse(Console.ReadLine(), out int value);

            if(p1)
            {
                int dividedValue = value / 100;

                dividedValue %= 10;

                Console.WriteLine((dividedValue == 7) ? "Yes, third digit in " + value + " is 7." : "No, third digit in " + value + " is not 7.");
            }
            else
            {
                Console.WriteLine("Invalid Input Entered ! \nMaybe Out of Range\nMaybe a Non Number value");
            }           

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay3_Program1_
{
    //program for checking the int is odd or even
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program for checking that the given input is odd or even");
            Console.WriteLine("Enter the number");
            int p;
            bool p1 = Int32.TryParse(Console.ReadLine(), out p);

            Console.WriteLine(p1 ? (p % 2 == 0 ? "Given number " + p + " is Even" : "Given number " + p + " is Odd") : "Invalid Input Value");
                 
            Console.ReadLine();
        }
    }
}

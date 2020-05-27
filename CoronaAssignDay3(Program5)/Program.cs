using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaAssignDay3_Program5_
{
    class Program
    {
        //changing the value at position p by the value v in value n
        static void Main(string[] args)
        {
            Console.WriteLine("Program for changing the value at position p by the value v in value n");
            Console.WriteLine("Enter a number: ");
            bool n1 = Int32.TryParse(Console.ReadLine(), out int n);

            Console.WriteLine("Enter the value (Either 0 or 1)");
            bool v1 = Int32.TryParse(Console.ReadLine(), out int v);

            Console.WriteLine("Enter the position where the value is to be replaced");
            bool p1 = Int32.TryParse(Console.ReadLine(), out int p);
            
            if(n1 && v1 && p1)
            {
                if(v == 0 || v == 1)
                {
                    if(p < 32 )
                    {
                        n = (v == 0) ? n & (~(1 << p)) : n | (1 << p);
                        Console.WriteLine("The Value of Given input after changing the bit value at "+ p + " with bit value of " + v1 + " is = " + n);
                    }
                    else
                    {
                        Console.WriteLine("The position entered is not valid as only 0 to 31 is allowed");
                    }                    
                }
                else
                {
                    Console.WriteLine("The value of bit to be replaced is neither 0 nor 1");
                }                
            }
            else
            {
                Console.WriteLine("Invalid Values may have been entered");
            }
                        
            Console.ReadLine();
        }
    }
}
